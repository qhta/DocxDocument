using System.Xml;
using System.Xml.Serialization;
using System.Reflection;

namespace DocumentModel.XmlSerialization;

public static class XmlSerializationHelper
{

  /// <summary>
  /// Serializes an object to XML using its runtime type.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <returns>Serialized XML text.</returns>
  public static string SerializeObjectToXml(object data, Type[]? modelTypes = null)
  {
    var xmlSerializer = CreateXmlSerializer(data, modelTypes, out var namespaces);
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data, namespaces);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes XML to an object of the specified type.
  /// </summary>
  /// <param name="dataType">Target type.</param>
  /// <param name="xml">XML input.</param>
  /// <returns>Deserialized instance or null.</returns>
  public static object? DeserializeObjectFromXml(Type dataType, string xml)
  {
    var xmlSerializer = new XmlSerializer(dataType);
    using (var stringReader = new StringReader(xml))
    {
      return xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Creates an XmlSerializer for the given data object, handling type overrides for generic ModelElement types.
  /// </summary>
  /// <param name="dataType">The type of the object to serialize.</param>
  /// <param name="namespaces">Output parameter for XML namespaces.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(Type dataType, out XmlSerializerNamespaces namespaces)
    => CreateXmlSerializer(dataType, null, out namespaces);


  /// <summary>
  /// Creates an XmlSerializer for the given data object, handling type overrides for generic ModelElement types.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <param name="namespaces">Output parameter for XML namespaces.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(object data, out XmlSerializerNamespaces namespaces)
    => CreateXmlSerializer(data.GetType(), null, out namespaces);

  /// <summary>
  /// Creates an XmlSerializer for the given data object, handling type overrides for generic ModelElement types.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <param name="namespaces">Output parameter for XML namespaces.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(object data, Type[]? modelTypes, out XmlSerializerNamespaces namespaces)
  => CreateXmlSerializer(data.GetType(), modelTypes, out namespaces);

  /// <summary>
  /// Creates an XmlSerializer for the specified root type, including overrides for generic ModelElement types to ensure unique XML type names.
  /// </summary>
  /// <param name="rootType">The root type for the XmlSerializer.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <param name="namespaces">Output parameter for XML namespaces.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(Type rootType, Type[]? modelTypes, out XmlSerializerNamespaces namespaces)
  {
    var UniqueTypeNames = new HashSet<string>();
    XmlAttributeOverrides overrides = new XmlAttributeOverrides();
    //var modelTypes = typeof(DMW.Document).Assembly.GetTypes()
    //  .Where(t => t.IsClass && !t.IsAbstract && !t.IsGenericType && !t.IsConstructedGenericType
    //            && !t.Implements(typeof(System.Collections.IDictionary))
    //  && t.GetConstructor([]) != null).ToArray();

    var knownTypes = new HashSet<Type>();
    if (modelTypes == null)
    {
      GetKnownTypes(rootType, knownTypes, new List<Type>());
      modelTypes = knownTypes.ToArray();
    }

    //if (modelTypes != null)
    {
      foreach (var t in modelTypes)
      {
        //Debug.WriteLine($"GetXmlAttributeOverrides for {t.FullName}");
        GetXmlAttributeOverrides(t, new List<Type>());
      }
    }

    namespaces = new XmlSerializerNamespaces();
    namespaces.Add("", "DocumentModel");
    namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
    namespaces.Add("w", "DocumentModel.Wordprocessing");
    namespaces.Add("d", "DocumentModel.Drawings");
    namespaces.Add("wd", "DocumentModel.Wordprocessing.Drawings");
    namespaces.Add("dw", "DocumentModel.Drawings.Wordprocessing");
    namespaces.Add("m", "DocumentModel.Math");

    var rootNamespace = GetXmlNamespace(rootType);
    if (!string.IsNullOrEmpty(rootNamespace))
      AddNamespaceIfMissing(namespaces, rootNamespace!);

    foreach (var type in modelTypes)
    {
      var typeNamespace = GetXmlNamespace(type);
      if (!string.IsNullOrEmpty(typeNamespace))
        AddNamespaceIfMissing(namespaces, typeNamespace!);
    }

    var xmlRootAttribute = GetXmlRootAttribute(rootType);
    return new XmlSerializer(rootType, overrides, modelTypes, xmlRootAttribute, null);
    
    static void GetKnownTypes(Type? aType, HashSet<Type> knownTypes, List<Type> visitedTypes)
    {
      if (aType != null && aType != typeof(object))
      {
        if (visitedTypes.Contains(aType))
          return;
        visitedTypes.Add(aType);
        if ((aType.FullName ?? "").Contains("<>"))
          return;
        if (aType.IsGenericType /*&& aType.GetGenericTypeDefinition() == typeof(DM.ModelElement<>)*/)
        {
          var arg = aType.GetGenericArguments()[0];
          if (arg.Name.Contains("<>"))
            return;
          if (!string.IsNullOrEmpty(arg.Namespace))
          {
            knownTypes.Add(aType);
          }
        }
        else
        {
          knownTypes.Add(aType);
        }
        foreach (var iEnumerable in aType.GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
        {
          var arg = iEnumerable.GetGenericArguments()[0];
          if (arg.Name.Contains("<>"))
            continue;
          if (!string.IsNullOrEmpty(arg.Namespace))
          {
            knownTypes.Add(aType);
          }
        }
        //Debug.WriteLine($"GetKnownTypes for {aType.BaseType?.FullName}");
        GetKnownTypes(aType.BaseType, knownTypes, visitedTypes);
      }
    }

    static string? GetXmlNamespace(Type type)
    {
      var xmlRoot = type.GetCustomAttribute<XmlRootAttribute>();
      if (!string.IsNullOrEmpty(xmlRoot?.Namespace))
        return xmlRoot.Namespace;
      return type.Namespace;
    }

    static XmlRootAttribute? GetXmlRootAttribute(Type type)
    {
      var xmlRoot = type.GetCustomAttribute<XmlRootAttribute>();
      if (xmlRoot != null)
      {
        if (!string.IsNullOrEmpty(xmlRoot.Namespace))
          return null;

        return new XmlRootAttribute(xmlRoot.ElementName)
        {
          Namespace = type.Namespace,
          DataType = xmlRoot.DataType,
          IsNullable = xmlRoot.IsNullable,
        };
      }

      if (!string.IsNullOrEmpty(type.Namespace))
        return new XmlRootAttribute(type.Name) { Namespace = type.Namespace };

      return null;
    }

    static void AddNamespaceIfMissing(XmlSerializerNamespaces serializerNamespaces, string xmlNamespace)
    {
      if (serializerNamespaces.ToArray().Any(pair => pair.Namespace == xmlNamespace))
        return;

      var prefix = CreatePrefix(xmlNamespace, serializerNamespaces);
      serializerNamespaces.Add(prefix, xmlNamespace);
    }

    static string CreatePrefix(string xmlNamespace, XmlSerializerNamespaces serializerNamespaces)
    {
      var basePrefix = xmlNamespace
        .Split('.')
        .LastOrDefault()?.ToLowerInvariant() ?? "ns";

      basePrefix = new string(basePrefix.Where(char.IsLetter).ToArray());
      if (string.IsNullOrEmpty(basePrefix))
        basePrefix = "ns";

      var usedPrefixes = serializerNamespaces.ToArray().Select(item => item.Name).ToHashSet();
      if (!usedPrefixes.Contains(basePrefix))
        return basePrefix;

      int index = 1;
      while (usedPrefixes.Contains($"{basePrefix}{index}"))
        index++;
      return $"{basePrefix}{index}";
    }

    void GetXmlAttributeOverrides(Type? aType,List<Type> visitedTypes)
    {
      if (aType != null && aType != typeof(object))
      {
        if (visitedTypes.Contains(aType))
          return;
        visitedTypes.Add(aType);
        if ((aType.FullName ?? "").Contains("<>"))
          return;
        if (aType.IsGenericType /*&& aType.GetGenericTypeDefinition() == typeof(DM.ModelElement<>)*/)
        {
          var arg = aType.GetGenericArguments()[0];
          if (arg.Name.Contains("<>"))
            return;
          if (!string.IsNullOrEmpty(arg.Namespace))
          {
            var unique = $"ModelElementOf_{arg.Namespace!.Replace('.', '_')}_{arg.Name}";
            if (UniqueTypeNames.Add(unique))
              overrides.Add(aType, new XmlAttributes { XmlType = new XmlTypeAttribute(unique) });
          }
        }
        //Debug.WriteLine($"GetXmlAttributeOverrides2 for {aType.BaseType?.FullName}");
        GetXmlAttributeOverrides(aType.BaseType, visitedTypes);
      }
    }
  }
  /// <summary>
  /// Gets XML namespace for a model type based on its CLR namespace.
  /// </summary>
  /// <param name="type">Type for which XML namespace is generated.</param>
  /// <returns>XML namespace string.</returns>
  public static string GetXmlNamespaceForType(Type type)
  {
    var typeNamespace = type.Namespace ?? "DocumentModel";
    if (typeNamespace.StartsWith("DocumentModel.", StringComparison.Ordinal))
      return "urn:docmodel:" + typeNamespace.Substring("DocumentModel.".Length).ToLowerInvariant().Replace('.', ':');
    return "urn:docmodel:global";
  }

  /// <summary>
  /// Adds an XML type override for a closed generic AbstractColor{T}"/> type.
  /// </summary>
  /// <param name="overrides">Override collection to populate.</param>
  /// <param name="type">Closed generic abstract color type to override.</param>
  /// <param name="xmlTypeName">Unique XML type name.</param>
  /// <param name="xmlNamespace">XML namespace for the type.</param>
  public static void AddAbstractColorOverride(XmlAttributeOverrides overrides, Type type, string xmlTypeName, string xmlNamespace)
  {
    var attrs = new XmlAttributes
    {
      XmlType = new XmlTypeAttribute
      {
        TypeName = xmlTypeName,
        Namespace = xmlNamespace
      }
    };
    overrides.Add(type, attrs);
  }

}
