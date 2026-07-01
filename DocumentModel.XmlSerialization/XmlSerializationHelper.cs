using System.Diagnostics;
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
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(Type dataType)
    => CreateXmlSerializer(dataType, null, out _);

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
    //var modelTypes = typeof(DMW.Document).Assembly.GetTypes()
    //  .Where(t => t.IsClass && !t.IsAbstract && !t.IsGenericType && !t.IsConstructedGenericType
    //            && !t.Implements(typeof(System.Collections.IDictionary))
    //  && t.GetConstructor([]) != null).ToArray();

    var knownTypes = new HashSet<Type>();
    if (modelTypes == null)
    {
      GetKnownTypes(rootType, knownTypes, new List<Type>());
      var openXmlElementTypes = knownTypes.Where(t => t.FullName!.Contains("DocumentFormat")).ToArray();
      modelTypes = knownTypes.ToArray();
    }
    Dictionary<string, List<Type>> ambiguousTypeNames = GetTypeNames(modelTypes);
    //Debug.WriteLine($"Ambiguous type names:\n{string.Join("\n",
    //  ambiguousTypeNames.Select(item => $"{item.Key}:{item.Value.Count}:\n  {String.Join("\n  ", item.Value.Select(t => t.FullName))}"))}");

    XmlAttributeOverrides? xmlAttributeOverrides = null;
    if (ambiguousTypeNames.Any())
    {
      var ambiguousTypes = ambiguousTypeNames.SelectMany(item => item.Value).ToArray();
      xmlAttributeOverrides = GetXmlAttributeOverrides(ambiguousTypes);
      //Debug.WriteLine($"XmlAttributeOverrides:\n{string.Join("\n",
      //  ambiguousTypes.Select(t => $"{xmlAttributeOverrides[t]?.XmlType?.TypeName} -> {t.FullName}"))}");
    }

    namespaces = new XmlSerializerNamespaces();
    namespaces.Add("", "DocumentModel");
    namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
    namespaces.Add("w", "DocumentModel.Wordprocessing");
    namespaces.Add("d", "DocumentModel.Drawings");
    namespaces.Add("wd", "DocumentModel.Wordprocessing.Drawings");
    namespaces.Add("dw", "DocumentModel.Drawings.Wordprocessing");
    namespaces.Add("m", "DocumentModel.Math");
    namespaces.Add("pr", "DocumentModel.Properties");

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
    try
    {
      return new XmlSerializer(rootType, xmlAttributeOverrides, modelTypes, xmlRootAttribute, null);
    }
    catch (Exception e)
    {
      Debug.WriteLine(e.GetInternalMessages());
      throw;
    }

    static void GetKnownTypes(Type? aType, HashSet<Type> knownTypes, List<Type> visitedTypes)
    {
      if (aType != null && aType != typeof(object))
      {
        if (visitedTypes.Contains(aType))
          return;
        //Debug.WriteLine($"GetKnownTypes for {aType.FullName}");
        visitedTypes.Add(aType);
        if ((aType.FullName ?? "").Contains("<>"))
          return;
        if (aType.Namespace == null)
          return;
        if (aType.Namespace.StartsWith("System"))
          return;
        if (aType == typeof(ValueType))
          return;
        if (aType.IsGenericType)
        {
          var arg = aType.GetGenericArguments()[0];
          if (arg.Name.Contains("<>"))
            return;
          if (arg.Namespace == null)
            return;
          if (arg.Namespace.StartsWith("System") || arg.Namespace.StartsWith("DocumentFormat") || arg.IsInterface)
          {
            knownTypes.Add(aType);
            //Debug.WriteLine($"Skipping known arg type: {arg.FullName}");
          }
          else
            if (!string.IsNullOrEmpty(arg.Namespace))
            {
              if (arg.Namespace.StartsWith("System") || arg.Namespace.StartsWith("DocumentFormat"))
              {
                //Debug.WriteLine($"Skipped known arg type: {arg.FullName}");
              }
              else
                knownTypes.Add(arg);
            }
        }
        else
        {
          if (aType.Namespace.StartsWith("System") || aType.Namespace.StartsWith("DocumentFormat") || aType.IsInterface)
          {
            //Debug.WriteLine($"Skipped known type: {aType.FullName}");
          }
          else
            knownTypes.Add(aType);
        }
        if (aType != typeof(string))
        {
          foreach (var iEnumerable in aType.GetInterfaces()
                     .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
          {
            var arg = iEnumerable.GetGenericArguments()[0];
            if (arg.Name.Contains("<>"))
              continue;
            if (arg.Namespace!.StartsWith("System") || arg.FullName == "DocumentModel.Drawings.Theme" || arg.IsInterface)
            {
              //Debug.WriteLine($"Continue known arg type: {arg.FullName}");
              continue;
            }
            if (!string.IsNullOrEmpty(arg.Namespace))
            {
              knownTypes.Add(arg);
            }
          }

          //Debug.WriteLine($"GetKnownTypes for {aType.BaseType?.FullName}");
          GetKnownTypes(aType.BaseType, knownTypes, visitedTypes);
          foreach (var property in aType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
          {
            if (property.CanWrite && property.GetCustomAttribute<XmlIgnoreAttribute>() == null)
            {
              GetKnownTypes(property.PropertyType, knownTypes, visitedTypes);
            }
          }
        }
        foreach (XmlIncludeAttribute xmlInclude in aType.GetCustomAttributes<XmlIncludeAttribute>())
        {
          GetKnownTypes(xmlInclude.Type, knownTypes, visitedTypes);
        }
      }
    }

    Dictionary<string, List<Type>> GetTypeNames(Type[] types)
    {
      Dictionary<string, List<Type>> typeNames = new Dictionary<string, List<Type>>();
      foreach (var aType in types)
      {

        var aName = aType.Name;
        if (aType.IsGenericType)
        {
          var k = aName.IndexOf('`');
          if (k >= 0)
            aName = aName.Substring(0, k);
          k = 0;
          foreach (var arg in aType.GetGenericArguments())
          {
            if (arg.Name.Contains("<>"))
              continue;

            k++;
            if (k == 1)
              aName += $"_of_{arg.Name}";
            else
              aName += $"_and_{arg.Name}";
          }
        }
        if (!typeNames.ContainsKey(aName))
          typeNames[aName] = new List<Type>();
        typeNames[aName].Add(aType);
      }
      List<string> singletonNames = typeNames.Where(kvp => kvp.Value.Count <= 1).Select(kvp => kvp.Key).ToList();
      foreach (var name in singletonNames)
        typeNames.Remove(name);
      return typeNames;
    }

    XmlAttributeOverrides GetXmlAttributeOverrides(IEnumerable<Type> types)
    {
      XmlAttributeOverrides overrides = new XmlAttributeOverrides();
      foreach (var aType in types)
      {
        if (aType != typeof(object))
        {
          // IXmlSerializable types provide their own XML contract and cannot
          // be overridden with XmlType metadata.
          if (typeof(IXmlSerializable).IsAssignableFrom(aType))
            continue;

          //Debug.WriteLine($"GetXmlAttributeOverrides for {aType.FullName}");

          var aName = aType.Namespace+"."+aType.Name;
          if (aType.IsGenericType)
          {
            var k = aName.IndexOf('`');
            if (k >= 0)
              aName = aName.Substring(0, k);
            k = 0;
            foreach (var arg in aType.GetGenericArguments())
            {
              if (arg.Name.Contains("<>"))
                continue;

              k++;
              if (k == 1)
                aName += $"_of_{arg.Namespace}.{arg.Name}";
              else
                aName += $"_and_{arg.Namespace}.{arg.Name}";
            }
          }
          aName = aName.Replace(".","_");
          overrides.Add(aType, new XmlAttributes { XmlType = new XmlTypeAttribute { TypeName = aName } });
        }
      }
      return overrides;
    }

    static string? GetXmlNamespace(Type type)
    {
      var xmlRoot = type.GetCustomAttribute<XmlRootAttribute>();
      if (!string.IsNullOrEmpty(xmlRoot?.Namespace))
        return xmlRoot?.Namespace;
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

  /// <summary>
  /// Retrieves a formatted string containing the messages of all inner exceptions for the specified exception.
  /// </summary>
  /// <remarks>This method is useful for logging or displaying detailed error information, especially when
  /// exceptions are nested. The returned string includes each inner exception message on a separate line.</remarks>
  /// <param name="ex">The exception from which to extract inner exception messages. Cannot be null.</param>
  /// <returns>A string listing the messages of all inner exceptions, each prefixed with "Inner Exception:". Returns "No inner
  /// exceptions" if there are none.</returns>
  public static string GetInternalMessages(this Exception ex)
  {
    var internalException = ex.InnerException;
    var messages = new List<string>();
    messages.Add(ex.Message);
    while (internalException != null)
    {
      messages.AddRange(internalException.GetInternalMessages().Split('\n'));
      internalException = internalException.InnerException;
    }
    return string.Join("\n", messages);
  }
}
