namespace DocumentModel;

/// <summary>
/// Provides helper methods for XML serialization and deserialization of objects, including handling of type overrides for generic types and management of XML namespaces.
/// </summary>
public static class XmlSerializationHelper
{
  /// <summary>
  /// Namespace mappings for XML serialization,
  /// including default and commonly used namespaces for document model elements.
  /// </summary>
  public static readonly XmlSerializerNamespaces Namespaces = createSerializerNamespaces();

  private static XmlSerializerNamespaces createSerializerNamespaces()
  {
    var namespaces = new XmlSerializerNamespaces();
    namespaces.Add("", "DocumentModel");
    namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
    namespaces.Add("w", "DocumentModel.Wordprocessing");
    namespaces.Add("d", "DocumentModel.Drawings");
    namespaces.Add("wd", "DocumentModel.Wordprocessing.Drawings");
    namespaces.Add("dw", "DocumentModel.Drawings.Wordprocessing");
    namespaces.Add("m", "DocumentModel.Math");
    namespaces.Add("pr", "DocumentModel.Properties");
    return namespaces;
  }

  /// <summary>
  /// Serializes an object to XML using its runtime type.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <returns>Serialized XML text.</returns>
  public static string SerializeObjectToXml(object data, Type[]? modelTypes = null)
  {
    var xmlSerializer = CreateXmlSerializer(data, modelTypes);
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data, Namespaces);
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
    => CreateXmlSerializer(dataType, null);


  /// <summary>
  /// Creates an XmlSerializer for the given data object, handling type overrides for generic ModelElement types.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(object data)
    => CreateXmlSerializer(data.GetType(), null);

  /// <summary>
  /// Creates an XmlSerializer for the given data object, handling type overrides for generic ModelElement types.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(object data, Type[]? modelTypes)
  => CreateXmlSerializer(data.GetType(), modelTypes);

  /// <summary>
  /// Creates an XmlSerializer for the specified root type, including overrides for generic ModelElement types to ensure unique XML type names.
  /// </summary>
  /// <param name="rootType">The root type for the XmlSerializer.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(Type rootType, Type[]? modelTypes)
  {
    if (modelTypes == null)
      modelTypes = XmlSerializationHelper.GetKnownTypes(rootType);
    //Debug.WriteLine($"$ModelTypes: {modelTypes.Count()}");
    //foreach (var knownType in modelTypes)
    //{
    //  Debug.WriteLine($"  {knownType.FullName}");
    //}
    Dictionary<string, List<Type>> ambiguousTypeNames = GetTypeNamesDictionary(modelTypes);
    //if (ambiguousTypeNames.Any())
    //{
    //  Debug.WriteLine($"Ambiguous type names: {ambiguousTypeNames.Count}");
    //  foreach (var item in ambiguousTypeNames)
    //  {
    //    Debug.WriteLine($"  {item.Key}");
    //    foreach (var type in item.Value)
    //    {
    //      Debug.WriteLine($"    {type.FullName}");
    //    }
    //  }
    //}
    XmlAttributeOverrides? xmlAttributeOverrides = null;
    if (ambiguousTypeNames.Any())
    {
      var ambiguousTypes = ambiguousTypeNames.SelectMany(item => item.Value).ToArray();
      xmlAttributeOverrides = GetXmlAttributeOverrides(ambiguousTypes);
    }

    var rootNamespace = GetXmlNamespace(rootType);
    if (!string.IsNullOrEmpty(rootNamespace))
      AddNamespaceIfMissing(Namespaces, rootNamespace!);

    foreach (var type in modelTypes)
    {
      var typeNamespace = GetXmlNamespace(type);
      if (!string.IsNullOrEmpty(typeNamespace))
        AddNamespaceIfMissing(Namespaces, typeNamespace!);
    }

    var xmlRootAttribute = GetXmlRootAttribute(rootType);

    var supportedTypes = modelTypes.Where(t => !t.IsGenericType).ToArray();
    try
    {
      return new XmlSerializer(rootType, xmlAttributeOverrides, supportedTypes, xmlRootAttribute, null);
    }
    catch (Exception e)
    {
      Debug.WriteLine(e.GetInternalMessages());
      throw;
    }

  }

  /// <summary>
  /// Retrieves an array of known types for XML serialization by scanning the assembly containing the DocumentModel.Wordprocessing.Document type for types marked with the DataContractAttribute, and also includes their generic base types.
  /// </summary>
  /// <returns>An array of known types for XML serialization.</returns>
  private static Type[] GetModelTypes()
  {
    var dataContractTypes = typeof(DocumentModel.Wordprocessing.Document).Assembly.GetTypes()
      .Where(t => t.GetCustomAttribute<DataContractAttribute>() != null).ToList();
    dataContractTypes.AddRange(typeof(DocumentModel.Base64Binary).Assembly.GetTypes()
      .Where(t => t.GetCustomAttribute<DataContractAttribute>() != null).ToList());
    return dataContractTypes.Distinct().ToArray();
  }

  /// <summary>
  /// Recursively collects the base types of the provided types that are generic, returning an array of these base types.
  /// </summary>
  /// <param name="types">The types to analyze for generic base types.</param>
  /// <returns>An array of generic base types.</returns>
  private static Type[] GetGenericBaseTypes(IEnumerable<Type> types)
  {
    var baseGenericTypes = types.Where(t => t.BaseType != null && t.BaseType.IsGenericType).Select(t => t.BaseType!).ToList();
    if (baseGenericTypes.Any())
      baseGenericTypes.AddRange(GetGenericBaseTypes(baseGenericTypes));
    return baseGenericTypes.ToArray();
  }

  /// <summary>
  /// Recursively collects known types for XML serialization starting from the specified root type, avoiding system types and already visited types to prevent infinite loops.
  /// </summary>
  /// <param name="rootType">The root type to start collecting known types from.</param>
  /// <returns>An array of known types for XML serialization.</returns>
  private static Type[] GetKnownTypes(Type? rootType)
  {
    var knownTypes = new HashSet<Type>();
    GetKnownTypesRecursive(rootType, knownTypes, new List<Type>());
    //var openXmlElementTypes = knownTypes.Where(t => t.FullName!.Contains("DocumentFormat")).ToArray();
    return knownTypes.ToArray();

  }

  /// <summary>
  /// Recursively collects known types for XML serialization, avoiding system types and already visited types to prevent infinite loops.
  /// </summary>
  /// <param name="aType">The type to analyze for known types.</param>
  /// <param name="knownTypes">A collection of known types to be populated.</param>
  /// <param name="visitedTypes">A list of types that have already been visited to prevent infinite recursion.</param>
  private static void GetKnownTypesRecursive(Type? aType, HashSet<Type> knownTypes, List<Type> visitedTypes)
  {
    if (aType != null && aType != typeof(object))
    {
      if (visitedTypes.Contains(aType))
        return;
      visitedTypes.Add(aType);
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
          visitedTypes.Add(aType);
          //Debug.WriteLine($"Skipping known arg type: {arg.FullName}");
        }
        else
        {
          GetKnownTypesRecursive(arg, knownTypes, visitedTypes);
        }
      }
      else
      {
        if (!(aType.Namespace.StartsWith("System") || aType.Namespace.StartsWith("DocumentFormat") || aType.IsInterface))
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
        GetKnownTypesRecursive(aType.BaseType, knownTypes, visitedTypes);
        foreach (var property in aType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
          Type propertyType = property.PropertyType;
          if (property.GetCustomAttribute<XmlIgnoreAttribute>() == null
              && (property.CanWrite || propertyType.IsEnumerable()))
          {
            GetKnownTypesRecursive(propertyType, knownTypes, visitedTypes);
          }
        }
      }
      foreach (XmlIncludeAttribute xmlInclude in aType.GetCustomAttributes<XmlIncludeAttribute>())
      {
        GetKnownTypesRecursive(xmlInclude.Type, knownTypes, visitedTypes);
      }
    }
  }

  /// <summary>
  /// Builds a dictionary mapping type names to lists of types that share the same name, used to identify ambiguous type names for XML serialization.
  /// </summary>
  /// <param name="types">An array of types to process.</param>
  /// <returns>A dictionary where the keys are type names and the values are lists of types that share the same name.</returns>
  private static Dictionary<string, List<Type>> GetTypeNamesDictionary(Type[] types)
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

  /// <summary>
  /// Retrieves the XML namespace for a given type, prioritizing the XmlRootAttribute's namespace if present, otherwise falling back to the type's CLR namespace.
  /// </summary>
  /// <param name="type">The type for which to retrieve the XML namespace.</param>
  /// <returns>The XML namespace for the specified type, or null if none is found.</returns>
  private static string? GetXmlNamespace(Type type)
  {
    var xmlRoot = type.GetCustomAttribute<XmlRootAttribute>();
    if (!string.IsNullOrEmpty(xmlRoot?.Namespace))
      return xmlRoot?.Namespace;
    return type.Namespace;
  }

  /// <summary>
  /// Retrieves the XmlRootAttribute for a given type, ensuring that the namespace is set to the type's CLR namespace if it is not already specified.
  /// </summary>
  /// <param name="type">The type for which to retrieve the XmlRootAttribute.</param>
  /// <returns>The XmlRootAttribute for the specified type, or null if none is found.</returns>
  private static XmlRootAttribute? GetXmlRootAttribute(Type type)
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

  /// <summary>
  /// Adds a namespace to the XmlSerializerNamespaces collection if it is not already present, ensuring that each namespace has a unique prefix.
  /// </summary>
  /// <param name="serializerNamespaces">The XmlSerializerNamespaces collection to which the namespace will be added.</param>
  /// <param name="xmlNamespace">The XML namespace to add.</param>
  private static void AddNamespaceIfMissing(XmlSerializerNamespaces serializerNamespaces, string xmlNamespace)
  {
    if (serializerNamespaces.ToArray().Any(pair => pair.Namespace == xmlNamespace))
      return;

    var prefix = CreatePrefix(xmlNamespace, serializerNamespaces);
    serializerNamespaces.Add(prefix, xmlNamespace);
  }

  /// <summary>
  /// Generates XmlAttributeOverrides for a collection of types, ensuring that each type has a unique XML type name to avoid conflicts during serialization.
  /// </summary>
  /// <param name="types">The collection of types for which to generate XmlAttributeOverrides.</param>
  /// <returns>An XmlAttributeOverrides object containing the overrides for the specified types.</returns>
  private static XmlAttributeOverrides GetXmlAttributeOverrides(IEnumerable<Type> types)
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

        var aName = aType.Namespace + "." + aType.Name;
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
        aName = aName.Replace(".", "_");
        overrides.Add(aType, new XmlAttributes { XmlType = new XmlTypeAttribute { TypeName = aName } });
      }
    }
    return overrides;
  }

  /// <summary>
  /// Creates a unique prefix for the given XML namespace, ensuring that it does not conflict with existing prefixes in the provided XmlSerializerNamespaces collection.
  /// </summary>
  /// <param name="xmlNamespace">The XML namespace for which to create a prefix.</param>
  /// <param name="serializerNamespaces">The collection of existing XML serializer namespaces.</param>
  /// <returns>A unique prefix for the given XML namespace.</returns>
  private static string CreatePrefix(string xmlNamespace, XmlSerializerNamespaces serializerNamespaces)
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

  private static readonly Dictionary<string, List<Type>> _typeCache = new Dictionary<string, List<Type>>();

  /// <summary>
  /// Initializes the type cache by populating it with known types, allowing for efficient type resolution during serialization and deserialization. This method scans the known types and adds them to the cache based on their type names, ensuring that each type can be quickly retrieved by name when needed.
  /// </summary>
  public static void InitTypeCache()
  {
    var knownTypes = GetModelTypes();
    foreach (var type in knownTypes)
    {
      var elementName = type.GetElementName();
      if (elementName == null)
        continue;
      var (ns, localName) = SplitTypeName(elementName);
      if (!_typeCache.ContainsKey(localName))
      {
        _typeCache[localName] = new List<Type>();
      }
      _typeCache[localName].Add(type);
    }
  }

  /// <summary>
  /// Gets the element name for a given Type, returning its full name
  /// or XmlRoot name if available. 
  /// </summary>
  /// <param name="type">The type for which to get the element name.</param>
  /// <returns>The element name for the specified type.</returns>
  public static string? GetElementName(this Type type)
  {
    var rootElementAttribute = type.GetCustomAttribute<XmlRootAttribute>();
    if (rootElementAttribute != null && !string.IsNullOrEmpty(rootElementAttribute.ElementName))
      return rootElementAttribute.Namespace + "." + rootElementAttribute.ElementName;
    var str = type.FullName ?? type.Name;
    var ss = str.Split(',');
    str = ss[0];
    if (str.Contains('<') || str.Contains('`'))
      return null;
    var k = str.IndexOf('`');
    if (k >= 0)
      str = str.Substring(0, k);
    return str;
  }

  /// <summary>
  /// Splits a fully qualified type name into its namespace and local name components.
  /// If the type name does not contain a namespace,
  /// the namespace will be returned as an empty string, and the local name will be the entire type name.
  /// </summary>
  /// <param name="typename"></param>
  /// <returns></returns>
  public static (string Namespace, string LocalName) SplitTypeName(string typename)
  {
    var k = typename.LastIndexOf('.');
    return (Namespace: k >= 0 ? typename.Substring(0, k) : string.Empty, LocalName: k >= 0 ? typename.Substring(k + 1) : typename);
  }

  /// <summary>
  /// Found a type by its name from the cache of known types.
  /// If the type is not found in the cache, it throws a TypeLoadException. This method is useful for resolving types during deserialization when only the type name is available.
  /// </summary>
  /// <param name="typeName">The name of the type to resolve.</param>
  /// <param name="prefix">The prefix to use when resolving the type. If multiple types with the same name exist, the type in the namespace corresponding to the prefix will be returned.</param>
  /// <returns>The resolved type.</returns>
  /// <exception cref="TypeLoadException"></exception>
  public static Type ResolveType(string typeName, string prefix)
  {
    if (!_typeCache.Any())
      InitTypeCache();
    if (_typeCache.TryGetValue(typeName, out var foundTypes) && foundTypes.Count > 0)
    {
      if (foundTypes.Count == 1)
        return foundTypes[0];
      else
      {
        var preferredNamespace = Namespaces.ToArray().FirstOrDefault(ns => ns.Name == prefix)?.Namespace;
        foreach (var type in foundTypes)
        {
          if (type.Namespace == preferredNamespace)
            return type;
        }
        preferredNamespace = "DocumentModel.Wordprocessing";
        foreach (var type in foundTypes)
        {
          if (type.Namespace == preferredNamespace)
            return type;
        }

        throw new TypeLoadException($"Ambiguous type '{typeName}' could not be resolved.");
      }
    }
    throw new TypeLoadException($"Type '{typeName}' could not be found in known types.");
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
