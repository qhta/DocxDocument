using System.Collections.Concurrent;
using System.Xml.Schema;

namespace DocumentModel.OpenXml;

public static partial class OpenXmlModelConverter
{
  public static void AddChildUsingSchemaOrder(this DX.OpenXmlElement parentElement, DX.OpenXmlElement child)
  {
    if (parentElement == null)
      throw new ArgumentNullException(nameof(parentElement));
    if (child == null)
      throw new ArgumentNullException(nameof(child));

    var order = WordprocessingSchema.GetChildOrder(parentElement);
    if (order.Count == 0)
    {
      parentElement.AppendChild(child);
      return;
    }

    var childIndex = WordprocessingSchema.GetChildOrderIndex(order, child);
    if (childIndex == WordprocessingSchema.UnknownOrder)
    {
      parentElement.AppendChild(child);
      return;
    }
    if (child.Parent!=null)
      child.Remove();

    DX.OpenXmlElement? insertAfter = null;
    foreach (DX.OpenXmlElement existing in parentElement.ChildElements)
    {
      var existingIndex = WordprocessingSchema.GetChildOrderIndex(order, existing);
      if (existingIndex == WordprocessingSchema.UnknownOrder)
        continue;

      if (existingIndex <= childIndex)
      {
        insertAfter = existing;
        continue;
      }

      if (insertAfter != null)
        parentElement.InsertAfter(child, insertAfter);
      else
        parentElement.InsertBefore(child, existing);
      return;
    }

    if (insertAfter != null)
      parentElement.InsertAfter(child, insertAfter);
    else
      parentElement.AppendChild(child);
  }

  public static class WordprocessingSchema
  {
    public const string WordNamespace = "http://purl.oclc.org/ooxml/wordprocessingml/main";

    public static readonly Dictionary<string, string> NamespaceAliases = new(StringComparer.Ordinal)
    {
      ["http://schemas.openxmlformats.org/wordprocessingml/2006/main"] = WordNamespace
    };

    public static readonly Lazy<SchemaInfo?> Schema = new(LoadSchema);
    public static readonly ConcurrentDictionary<string, IReadOnlyList<ChildOrderEntry>> Cache = new(StringComparer.Ordinal);

    public const int UnknownOrder = int.MaxValue;

    public static IReadOnlyList<ChildOrderEntry> GetChildOrder(DX.OpenXmlElement element)
    {
      var schema = Schema.Value;
      if (schema == null)
        return Array.Empty<ChildOrderEntry>();

      var key = GetElementKey(element, out var qualifiedName);
      if (key == null || qualifiedName == null)
        return Array.Empty<ChildOrderEntry>();

      return Cache.GetOrAdd(key, _ => schema.BuildChildOrder(qualifiedName));
    }

    public static int GetChildOrderIndex(IReadOnlyList<ChildOrderEntry> order, DX.OpenXmlElement element)
    {
      var ns = NormalizeNamespace(element.NamespaceUri);
      var localName = element.LocalName;
      for (var i = 0; i < order.Count; i++)
      {
        if (order[i].Matches(ns, localName))
          return i;
      }
      return UnknownOrder;
    }

    public static SchemaInfo? LoadSchema()
    {
      try
      {
        var path = TryFindSchemaPath();
        if (path == null)
          return null;

        var schemaSet = new XmlSchemaSet
        {
          XmlResolver = new XmlUrlResolver()
        };
        schemaSet.Add(null, path);
        schemaSet.Compile();

        var comparer = new QualifiedNameComparer();
        var elements = new Dictionary<XmlQualifiedName, XmlSchemaElement>(comparer);
        var groups = new Dictionary<XmlQualifiedName, XmlSchemaGroup>(comparer);

        foreach (XmlSchema schema in schemaSet.Schemas())
        {
          foreach (DictionaryEntry entry in schema.Elements)
          {
            if (entry.Value is XmlSchemaElement element)
            {
              var qName = element.QualifiedName;
              if (qName.IsEmpty && !string.IsNullOrEmpty(element.Name))
                qName = new XmlQualifiedName(element.Name, schema.TargetNamespace ?? string.Empty);

              qName = NormalizeQualifiedName(qName);
              elements[qName] = element;
            }
          }

          foreach (DictionaryEntry entry in schema.Groups)
          {
            if (entry.Value is XmlSchemaGroup group)
            {
              var qName = group.QualifiedName;
              if (qName.IsEmpty && !string.IsNullOrEmpty(group.Name))
                qName = new XmlQualifiedName(group.Name, schema.TargetNamespace ?? string.Empty);

              qName = NormalizeQualifiedName(qName);
              groups[qName] = group;
            }
          }
        }

        return new SchemaInfo(schemaSet, elements, groups);
      }
      catch (Exception ex)
      {
        Debug.WriteLine($"Unable to load wml.xsd schema: {ex}");
        return null;
      }
    }

    public static string? TryFindSchemaPath()
    {
      var relative = Path.Combine("Schema","wml.xsd");

      var directory = new DirectoryInfo(AppContext.BaseDirectory);
      while (directory != null)
      {
        var candidate = Path.Combine(directory.FullName, relative);
        if (File.Exists(candidate))
          return candidate;

        directory = directory.Parent;
      }

      return null;
    }

    public static string? GetElementKey(DX.OpenXmlElement element, out XmlQualifiedName? qualifiedName)
    {
      var ns = NormalizeNamespace(element.NamespaceUri);
      qualifiedName = null;
      if (!StringComparer.Ordinal.Equals(ns, WordNamespace))
        return null;

      qualifiedName = new XmlQualifiedName(element.LocalName, ns);
      return $"{ns}:{element.LocalName}";
    }

    public static string NormalizeNamespace(string? namespaceUri)
    {
      if (string.IsNullOrEmpty(namespaceUri))
        return string.Empty;

      if (NamespaceAliases.TryGetValue(namespaceUri, out var mapped))
        return mapped;

      return namespaceUri;
    }

    public static XmlQualifiedName NormalizeQualifiedName(XmlQualifiedName name)
    {
      return new XmlQualifiedName(name.Name, NormalizeNamespace(name.Namespace));
    }

    public sealed class SchemaInfo
    {
      public readonly XmlSchemaSet schemaSet;
      public readonly Dictionary<XmlQualifiedName, XmlSchemaElement> elements;
      public readonly Dictionary<XmlQualifiedName, XmlSchemaGroup> groups;

      public SchemaInfo(XmlSchemaSet schemaSet,
                        Dictionary<XmlQualifiedName, XmlSchemaElement> elements,
                        Dictionary<XmlQualifiedName, XmlSchemaGroup> groups)
      {
        this.schemaSet = schemaSet;
        this.elements = elements;
        this.groups = groups;
      }

      public IReadOnlyList<ChildOrderEntry> BuildChildOrder(XmlQualifiedName elementName)
      {
        if (!elements.TryGetValue(elementName, out var element))
          return Array.Empty<ChildOrderEntry>();

        var complexType = element.ElementSchemaType as XmlSchemaComplexType
                          ?? LookupComplexType(element.SchemaTypeName);

        if (complexType?.ContentTypeParticle == null)
          return Array.Empty<ChildOrderEntry>();

        var result = new List<ChildOrderEntry>();
        var order = 0;
        AddParticle(complexType.ContentTypeParticle, result, ref order, elementName.Namespace);
        return result;
      }

      public XmlSchemaComplexType? LookupComplexType(XmlQualifiedName typeName)
      {
        if (typeName == null || typeName.IsEmpty)
          return null;
        return schemaSet.GlobalTypes[typeName] as XmlSchemaComplexType;
      }

      public void AddParticle(XmlSchemaParticle? particle, List<ChildOrderEntry> order, ref int position, string targetNamespace)
      {
        if (particle == null)
          return;

        switch (particle)
        {
          case XmlSchemaSequence sequence:
            foreach (XmlSchemaObject item in sequence.Items)
              if (item is XmlSchemaParticle child)
                AddParticle(child, order, ref position, targetNamespace);
            break;

          case XmlSchemaChoice choice:
            foreach (XmlSchemaObject item in choice.Items)
              if (item is XmlSchemaParticle child)
                AddParticle(child, order, ref position, targetNamespace);
            break;

          case XmlSchemaAll all:
            foreach (XmlSchemaObject item in all.Items)
              if (item is XmlSchemaParticle child)
                AddParticle(child, order, ref position, targetNamespace);
            break;

          case XmlSchemaGroupRef groupRef:
            if (!groupRef.RefName.IsEmpty)
            {
              var groupName = NormalizeQualifiedName(groupRef.RefName);
              if (groups.TryGetValue(groupName, out var group) && group.Particle != null)
                AddParticle(group.Particle, order, ref position, targetNamespace);
            }
            break;

          case XmlSchemaElement element:
            var qualifiedName = GetQualifiedName(element);
            if (qualifiedName != null)
            {
              order.Add(new ChildOrderEntry(qualifiedName));
              position++;
            }
            break;

          case XmlSchemaAny any:
            order.Add(new ChildOrderEntry(new WildcardMatcher(any, targetNamespace)));
            position++;
            break;
        }
      }

      public static XmlQualifiedName? GetQualifiedName(XmlSchemaElement element)
      {
        if (!element.RefName.IsEmpty)
          return NormalizeQualifiedName(element.RefName);

        if (!element.QualifiedName.IsEmpty)
          return NormalizeQualifiedName(element.QualifiedName);

        if (!string.IsNullOrEmpty(element.Name))
        {
          var schema = GetSchema(element);
          var ns = schema?.TargetNamespace ?? string.Empty;
          return new XmlQualifiedName(element.Name, NormalizeNamespace(ns));
        }

        return null;
      }

      public static XmlSchema? GetSchema(XmlSchemaObject obj)
      {
        var current = obj;
        while (current != null)
        {
          if (current is XmlSchema schema)
            return schema;
          current = current.Parent;
        }

        return null;
      }
    }

    public sealed class ChildOrderEntry
    {
      public readonly XmlQualifiedName? name;
      public readonly WildcardMatcher? wildcard;

      public ChildOrderEntry(XmlQualifiedName name)
      {
        this.name = name;
      }

      public ChildOrderEntry(WildcardMatcher wildcard)
      {
        this.wildcard = wildcard;
      }

      public bool Matches(string namespaceUri, string localName)
      {
        if (name != null)
        {
          return StringComparer.Ordinal.Equals(name.Namespace ?? string.Empty, namespaceUri)
                 && StringComparer.Ordinal.Equals(name.Name, localName);
        }

        return wildcard?.Matches(namespaceUri) == true;
      }
    }

    public sealed class WildcardMatcher
    {
      public readonly string targetNamespace;
      public readonly bool allowAny;
      public readonly bool allowLocal;
      public readonly bool allowOther;
      public readonly string[] namespaces;

      public WildcardMatcher(XmlSchemaAny any, string targetNamespace)
      {
        this.targetNamespace = targetNamespace;
        var ns = any.Namespace;

        if (string.IsNullOrWhiteSpace(ns) || ns == "##any")
        {
          allowAny = true;
          namespaces = Array.Empty<string>();
          return;
        }

        var parts = ns.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        var values = new List<string>(parts.Length);

        foreach (var part in parts)
        {
          switch (part)
          {
            case "##local":
              allowLocal = true;
              break;
            case "##other":
              allowOther = true;
              break;
            case "##targetNamespace":
              values.Add(targetNamespace);
              break;
            default:
              values.Add(NormalizeNamespace(part));
              break;
          }
        }

        namespaces = values.ToArray();
      }

      public bool Matches(string namespaceUri)
      {
        namespaceUri = NormalizeNamespace(namespaceUri);

        if (allowAny)
          return true;
        if (allowLocal && string.IsNullOrEmpty(namespaceUri))
          return true;
        if (allowOther && !StringComparer.Ordinal.Equals(namespaceUri, targetNamespace))
          return true;

        foreach (var value in namespaces)
        {
          if (StringComparer.Ordinal.Equals(value, namespaceUri))
            return true;
        }

        return false;
      }
    }

    public sealed class QualifiedNameComparer : IEqualityComparer<XmlQualifiedName>
    {
      public bool Equals(XmlQualifiedName? x, XmlQualifiedName? y)
      {
        if (ReferenceEquals(x, y))
          return true;
        if (x is null || y is null)
          return false;

        return StringComparer.Ordinal.Equals(NormalizeNamespace(x.Namespace), NormalizeNamespace(y.Namespace))
               && StringComparer.Ordinal.Equals(x.Name, y.Name);
      }

      public int GetHashCode(XmlQualifiedName obj)
      {
        return HashCode.Combine(NormalizeNamespace(obj.Namespace), obj.Name);
      }
    }
  }
}