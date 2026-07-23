using System.Collections.Concurrent;
using System.Xml.Schema;

using Qhta.OpenXmlTools;

namespace DocumentModel.OpenXml;

public static partial class OpenXmlModelConverter
{
  /// <summary>
  /// Adds a child element to the specified parent element, inserting it in the order defined by the schema for the parent element.
  /// </summary>
  /// <remarks>If the parent element defines a specific order for its child elements, the child is inserted
  /// according to that order. If the child element already has a parent, it is removed from its current parent before
  /// being added to the new parent. If the schema does not define an order, the child is appended to the end of the
  /// parent's children.</remarks>
  /// <param name="parentElement">The parent OpenXmlElement to which the child element will be added. This parameter cannot be null.</param>
  /// <param name="child">The child OpenXmlElement to add to the parent. This parameter cannot be null.</param>
  /// <exception cref="ArgumentNullException">Thrown when either the parentElement or child parameter is null.</exception>
  public static void AddChildUsingSchemaOrder(this DX.OpenXmlElement parentElement, DX.OpenXmlElement child)
  {
    if (parentElement == null)
      throw new ArgumentNullException(nameof(parentElement));
    if (child == null)
      throw new ArgumentNullException(nameof(child));

    var childOrder = WordprocessingSchema.GetChildOrder(parentElement);
    if (childOrder.Count == 0)
    {
      parentElement.AppendChild(child);
      return;
    }
    // this code creates a new child element with the normalized namespace if the child element's namespace does not match the normalized namespace defined by the Wordprocessing schema.
    // This causes the original child element is NOT added to the parent element, but instead a new child is added.
    //var legacyNamespace = child.NamespaceUri;
    //var modernNamespace = WordprocessingSchema.NormalizeNamespace(legacyNamespace);
    //if (!StringComparer.Ordinal.Equals(child.NamespaceUri, modernNamespace))
    //{
    //  var updatedOuterXml = child.OuterXml.Replace(
    //    legacyNamespace,
    //    modernNamespace);


    //  var partContainer = (parentElement.GetRootElement() as DX.OpenXmlPartRootElement)?.OpenXmlPart; // OpenXmlPartContainer
    //  if (partContainer == null)
    //    throw new InvalidOperationException("parentElement is not attached to an OpenXmlPart.");
    //  child = DX.OpenXmlUnknownElementExtensions.CreateUnknownElement(partContainer, updatedOuterXml);
    //}

    var childIndex = WordprocessingSchema.GetChildOrderIndex(childOrder, child);
    if (childIndex == WordprocessingSchema.UnknownOrder)
    {
      parentElement.AppendChild(child);
      return;
    }
    if (child.Parent != null)
      child.Remove();
    DX.OpenXmlElement? insertAfter = null;
    foreach (DX.OpenXmlElement existing in parentElement.ChildElements)
    {
      var existingIndex = WordprocessingSchema.GetChildOrderIndex(childOrder, existing);
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

  /// <summary>
  /// Represents schema for WML
  /// </summary>
  public static class WordprocessingSchema
  {
    ///// <summary>
    ///// URI of Wordprocessing namespace.
    ///// </summary>
    //public const string WordprocessingNamespace = "http://purl.oclc.org/ooxml/wordprocessingml/main";

    ///// <summary>
    ///// URI of Math namespace
    ///// </summary>
    //public const string MathNamespace = "http://purl.oclc.org/ooxml/officeDocument/math";

    ///// <summary>
    ///// URI of SchemaLibrary namespace
    ///// </summary>
    //public const string SchemaLibraryNamespace = "http://purl.oclc.org/ooxml/schemaLibrary/main";

    ///// <summary>
    ///// Gets a dictionary that maps namespace URIs to their corresponding aliases for Open XML word processing
    ///// documents.
    ///// </summary>
    ///// <remarks>This dictionary is initialized with a case-sensitive string comparer and contains predefined
    ///// namespace mappings used in Open XML document processing.</remarks>
    //public static readonly Dictionary<string, string> NamespaceAliases = new(StringComparer.Ordinal)
    //{
    //  ["http://schemas.openxmlformats.org/wordprocessingml/2006/main"] = WordprocessingNamespace,
    //  ["http://schemas.openxmlformats.org/officeDocument/2006/math"] = MathNamespace,
    //  ["http://schemas.openxmlformats.org/schemaLibrary/2006/main"] = SchemaLibraryNamespace
    //};

    /// <summary>
    /// Lazy-loaded schema instance.
    /// </summary>
    public static readonly Lazy<SchemaInfo?> Schema = new(LoadSchema);

    /// <summary>
    /// Cache for child-order entries. A key of the entry is prefixed local name of Schema element.
    /// </summary>
    public static readonly ConcurrentDictionary<string, IReadOnlyList<ChildOrderEntry>> Cache =
      new(StringComparer.Ordinal);

    /// <summary>
    /// Represents a sentinel value indicating that the order is unknown or not defined.
    /// </summary>
    /// <remarks>This constant is set to <see cref="int.MaxValue"/> and can be used in scenarios where a valid
    /// order cannot be determined or is not applicable. It is commonly used to signal an undefined or unspecified
    /// ordering in order-related operations.</remarks>
    public const int UnknownOrder = int.MaxValue;

    /// <summary>
    /// Retrieves the child order entries for the specified element, using the schema cache when available.
    /// </summary>
    /// <param name="element">The OpenXml element used to resolve its child order.</param>
    /// <returns>The ordered list of child entries for the element, or an empty list when unavailable.</returns>
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

    /// <summary>
    /// Gets the index of the specified child order entry in the provided order list based on the namespace and local
    /// name of the given element.
    /// </summary>
    /// <remarks>The method normalizes the namespace URI of the provided element before performing the search.
    /// If no matching entry is found, the method returns a constant value representing an unknown order.</remarks>
    /// <param name="order">The list of child order entries to search for a matching entry.</param>
    /// <param name="element">The OpenXmlElement whose namespace URI and local name are used to identify the corresponding child order entry.</param>
    /// <returns>The zero-based index of the matching child order entry if found; otherwise, a predefined constant indicating
    /// that the order is unknown.</returns>
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

    /// <summary>
    /// Loads and compiles the XML schema from a predefined location, returning a SchemaInfo object containing the
    /// schema's elements and groups.
    /// </summary>
    /// <remarks>This method attempts to locate and load the XML schema file. If the schema file cannot be
    /// found or an error occurs during loading or compilation, the method returns null. The returned SchemaInfo object
    /// provides access to the schema's elements and groups for further processing.</remarks>
    /// <returns>A SchemaInfo object containing the compiled schema, elements, and groups if the schema is successfully loaded;
    /// otherwise, null.</returns>
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
      } catch (Exception ex)
      {
        Debug.WriteLine($"Unable to load wml.xsd schema: {ex}");
        return null;
      }
    }


    /// <summary>
    /// Searches for the Wordprocessing schema file in the application base directory and its parents.
    /// </summary>
    /// <returns>The full path to the schema file, or null when it cannot be found.</returns>
    public static string? TryFindSchemaPath()
    {
      var relative = Path.Combine("Schema", "wml.xsd");
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

    /// <summary>
    /// Builds a cache key for the specified element and returns its qualified name when it matches the Wordprocessing namespace.
    /// </summary>
    /// <param name="element">The element used to build the key.</param>
    /// <param name="qualifiedName">The qualified name resolved for the element.</param>
    /// <returns>The cache key when the element belongs to the Wordprocessing namespace; otherwise, null.</returns>
    public static string? GetElementKey(DX.OpenXmlElement element, out XmlQualifiedName? qualifiedName)
    {
      var ns = NormalizeNamespace(element.NamespaceUri);
      qualifiedName = new XmlQualifiedName(element.LocalName, ns);
      return $"{ns}:{element.LocalName}";
    }

    /// <summary>
    /// Normalizes the namespace URI using the alias map for Wordprocessing namespaces.
    /// </summary>
    /// <param name="namespaceUri">The namespace URI to normalize.</param>
    /// <returns>The normalized namespace URI.</returns>
    public static string NormalizeNamespace(string? namespaceUri)
    {
      if (string.IsNullOrEmpty(namespaceUri))
        return string.Empty;
      //if (NamespaceAliases.TryGetValue(namespaceUri!, out var mapped))
        //return mapped;
      //namespaceUri = namespaceUri!.Replace("2006/", "").Replace("schemas.openxmlformats.org/", "purl.oclc.org/ooxml/");

      return namespaceUri!;
    }

    /// <summary>
    /// Normalizes the namespace portion of a qualified name.
    /// </summary>
    /// <param name="name">The qualified name to normalize.</param>
    /// <returns>A normalized qualified name.</returns>
    public static XmlQualifiedName NormalizeQualifiedName(XmlQualifiedName name)
    {
      return new XmlQualifiedName(name.Name, NormalizeNamespace(name.Namespace));
    }

    /// <summary>
    /// Provides information about a compiled set of Open XML schemas, including access to element and group definitions
    /// and methods for schema navigation and lookup.
    /// </summary>
    /// <remarks>The SchemaInfo class encapsulates the schema set and offers utility methods to build child
    /// element orders and resolve complex types. It is intended to facilitate structured handling and querying of XML
    /// schema definitions, particularly in scenarios involving Open XML document processing.</remarks>
    public sealed class SchemaInfo
    {
      /// <summary>
      /// Compiled schema set containing the Open XML schema definitions.
      /// </summary>
      public readonly XmlSchemaSet schemaSet;

      /// <summary>
      /// Map of qualified names to schema element definitions.
      /// </summary>
      public readonly Dictionary<XmlQualifiedName, XmlSchemaElement> elements;

      /// <summary>
      /// Map of qualified names to schema group definitions.
      /// </summary>
      public readonly Dictionary<XmlQualifiedName, XmlSchemaGroup> groups;

      /// <summary>
      /// Initializes a new instance with the provided schema set, elements, and groups.
      /// </summary>
      /// <param name="schemaSet">The compiled schema set.</param>
      /// <param name="elements">The element definitions indexed by qualified name.</param>
      /// <param name="groups">The group definitions indexed by qualified name.</param>
      public SchemaInfo
      (XmlSchemaSet schemaSet, Dictionary<XmlQualifiedName, XmlSchemaElement> elements,
        Dictionary<XmlQualifiedName, XmlSchemaGroup> groups)
      {
        this.schemaSet = schemaSet;
        this.elements = elements;
        this.groups = groups;
      }

      /// <summary>
      /// Builds the ordered list of child element entries for the specified element name.
      /// </summary>
      /// <param name="elementName">The qualified name of the schema element.</param>
      /// <returns>The ordered list of child element entries.</returns>
      public IReadOnlyList<ChildOrderEntry> BuildChildOrder(XmlQualifiedName elementName)
      {
        if (!elements.TryGetValue(elementName, out var element))
          return Array.Empty<ChildOrderEntry>();

        var complexType = element.ElementSchemaType as XmlSchemaComplexType ??
                          LookupComplexType(element.SchemaTypeName);
        if (complexType?.ContentTypeParticle == null)
          return Array.Empty<ChildOrderEntry>();

        var result = new List<ChildOrderEntry>();
        var order = 0;
        AddParticle(complexType.ContentTypeParticle, result, ref order, elementName.Namespace);
        return result;
      }

      /// <summary>
      /// Resolves a complex type by qualified name from the schema set.
      /// </summary>
      /// <param name="typeName">The qualified name of the schema type.</param>
      /// <returns>The complex type definition if found; otherwise, null.</returns>
      public XmlSchemaComplexType? LookupComplexType(XmlQualifiedName typeName)
      {
        if (typeName.IsEmpty)
          return null;

        return schemaSet.GlobalTypes[typeName] as XmlSchemaComplexType;
      }

      /// <summary>
      /// Adds child order entries for the specified particle to the provided order list.
      /// </summary>
      /// <param name="particle">The schema particle to evaluate.</param>
      /// <param name="order">The list to populate with child order entries.</param>
      /// <param name="position">The current position in the order list.</param>
      /// <param name="targetNamespace">The target namespace of the schema.</param>
      public void AddParticle
        (XmlSchemaParticle? particle, IList<ChildOrderEntry> order, ref int position, string targetNamespace)
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
            //Debug.WriteLine($"Processing element: \"{qualifiedName}\"");
            if (qualifiedName != null)
            {
              order.Add(new ChildOrderEntry(qualifiedName));
              position++;
            }
            else
            {
              throw new ApplicationException($"Unable to determine qualified name for element: {element}");
            }
            break;
          case XmlSchemaAny any:
            order.Add(new ChildOrderEntry(new WildcardMatcher(any, targetNamespace)));
            position++;
            break;
        }
      }

      /// <summary>
      /// Determines the qualified name for the specified schema element.
      /// </summary>
      /// <param name="element">The schema element to evaluate.</param>
      /// <returns>The resolved qualified name, or null when it cannot be determined.</returns>
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

      /// <summary>
      /// Finds the schema containing the specified schema object.
      /// </summary>
      /// <param name="obj">The schema object to trace.</param>
      /// <returns>The containing schema, or null if none is found.</returns>
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

    /// <summary>
    /// Entry for child-orders cache.
    /// </summary>
    [DebuggerDisplay("Name:\"{name}\" WildCard=\"{wildcard}\"")]
    public sealed class ChildOrderEntry
    {
      /// <summary>
      /// Qualified name matcher for a specific child element.
      /// </summary>
      public readonly XmlQualifiedName? name;

      /// <summary>
      /// Wildcard matcher for schema any particles.
      /// </summary>
      public readonly WildcardMatcher? wildcard;

      /// <summary>
      /// Initializes a new entry for a specific qualified name.
      /// </summary>
      /// <param name="name">The qualified name to match.</param>
      public ChildOrderEntry(XmlQualifiedName name)
      {
        this.name = name;
      }

      /// <summary>
      /// Initializes a new entry for a wildcard matcher.
      /// </summary>
      /// <param name="wildcard">The wildcard matcher to use.</param>
      public ChildOrderEntry(WildcardMatcher wildcard)
      {
        this.wildcard = wildcard;
      }

      /// <summary>
      /// Determines whether the entry matches the specified namespace URI and local name.
      /// </summary>
      /// <param name="namespaceUri">The namespace URI to match.</param>
      /// <param name="localName">The local name to match.</param>
      /// <returns>True if the entry matches; otherwise, false.</returns>
      public bool Matches(string namespaceUri, string localName)
      {
        if (name != null)
        {
          return StringComparer.Ordinal.Equals(name.Namespace ?? string.Empty, namespaceUri) &&
                 StringComparer.Ordinal.Equals(name.Name, localName);
        }
        return wildcard?.Matches(namespaceUri) == true;
      }

    }

    /// <summary>
    /// Provides functionality to evaluate wildcard rules against specified namespaces.
    /// </summary>
    /// <remarks>This class allows for flexible matching of namespaces based on defined rules, including
    /// options for allowing any namespace, local namespaces, and other namespaces. It is particularly useful in
    /// scenarios where XML schema validation is required, enabling developers to specify which namespaces are
    /// acceptable for a given context.</remarks>
    public sealed class WildcardMatcher
    {
      /// <summary>
      /// The target namespace used to evaluate wildcard rules.
      /// </summary>
      public readonly string targetNamespace;

      /// <summary>
      /// Indicates whether any namespace is allowed.
      /// </summary>
      public readonly bool allowAny;

      /// <summary>
      /// Indicates whether local (empty) namespace is allowed.
      /// </summary>
      public readonly bool allowLocal;

      /// <summary>
      /// Indicates whether namespaces other than the target namespace are allowed.
      /// </summary>
      public readonly bool allowOther;

      /// <summary>
      /// Allowed namespaces for the wildcard.
      /// </summary>
      public readonly string[] namespaces;

      /// <summary>
      /// Initializes a new wildcard matcher for the specified schema any element.
      /// </summary>
      /// <param name="any">The schema any element.</param>
      /// <param name="targetNamespace">The target namespace of the schema.</param>
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
        var parts = ns.Split([' ', '\t', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
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

      /// <summary>
      /// Determines whether the wildcard matches the specified namespace URI.
      /// </summary>
      /// <param name="namespaceUri">The namespace URI to match.</param>
      /// <returns>True if the namespace is allowed; otherwise, false.</returns>
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

    /// <summary>
    /// Compares two Xml qualified names for equality.
    /// </summary>
    public sealed class QualifiedNameComparer: IEqualityComparer<XmlQualifiedName>
    {
      /// <summary>
      /// Determines whether two qualified names are equal after namespace normalization.
      /// </summary>
      /// <param name="x">The first qualified name.</param>
      /// <param name="y">The second qualified name.</param>
      /// <returns>True if the qualified names are equal; otherwise, false.</returns>
      public bool Equals(XmlQualifiedName? x, XmlQualifiedName? y)
      {
        if (ReferenceEquals(x, y))
          return true;
        if (x is null || y is null)
          return false;

        return StringComparer.Ordinal.Equals(NormalizeNamespace(x.Namespace), NormalizeNamespace(y.Namespace)) &&
               StringComparer.Ordinal.Equals(x.Name, y.Name);
      }

      /// <summary>
      /// Produces a hash code for a qualified name using normalized namespace values.
      /// </summary>
      /// <param name="obj">The qualified name to hash.</param>
      /// <returns>The hash code for the qualified name.</returns>
      public int GetHashCode(XmlQualifiedName obj)
      {
        return HashCode.Combine(NormalizeNamespace(obj.Namespace), obj.Name);
      }
    }
  }
}
