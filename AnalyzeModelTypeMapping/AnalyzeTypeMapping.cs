namespace AnalyzeModelTypeMapping;

/// <summary>
///   Represents a mapping between a model type and an Open XML type for analysis and reporting purposes.
/// </summary>
/// <param name="ModelType">The fully qualified name of the model type.</param>
/// <param name="OpenXmlType">The fully qualified name of the corresponding Open XML type.</param>
public record struct TypeMapping(string ModelType, string OpenXmlType)
{
  /// <summary>
  ///   The fully qualified name of the model type.
  /// </summary>
  public string ModelType { get; } = ModelType;
  /// <summary>
  ///   The fully qualified name of the corresponding Open XML type.
  /// </summary>
  public string OpenXmlType { get; } = OpenXmlType;
}


/// <summary>
///   Represents a collection that maps <see cref="TypeMapping"/> instances to their count of occurrences.
///   Used for aggregating and reporting type mapping statistics.
/// </summary>
public class TypeMappings : Dictionary<TypeMapping, int>
{
}

/// <summary>
///   Analyzes model types and their mappings to Open XML elements and attributes, generating reports on type correspondence and usage statistics.
///   Uses reflection to inspect types, properties, and mapping attributes in the dependent project.
/// </summary>
public class AnalyzeTypeMapping
{
  private readonly List<Type> VisitedTypes = new();
  private readonly TypeMappings PropTypeMappings = new();
  private static readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.DocPart).Assembly;


  /// <summary>
  ///   Scans all non-abstract, non-enum, non-interface, non-generic types in the specified assembly and analyzes their property type mappings.
  /// </summary>
  /// <param name="modelAssembly">The assembly containing model types to analyze.</param>
  public void ScanPropTypeMappings(Assembly modelAssembly)
  {
    foreach (var type in modelAssembly.GetTypes().Where(type =>
               !type.IsEnum && !type.IsAbstract && !type.IsInterface && !type.IsGenericTypeDefinition))
    {
      if (!type.FullName!.Contains("+"))
      {
        AnalyzeType(type);
      }
    }
  }


  /// <summary>
  ///   Generates a report of the type mappings and their counts to a specified file in tab-delimited format.
  /// </summary>
  /// <param name="filePath">The file path to write the report to.</param>
  public void GenerateReport(string filePath)
  {
    using var writer = new StreamWriter(filePath);
    writer.WriteLine("ModelType;Format;Count");
    foreach (var (mapping, count) in PropTypeMappings)
    {
      writer.WriteLine($"{mapping.ModelType};{mapping.OpenXmlType};{count}");
    }
  }


  /// <summary>
  ///   Analyzes a given type to find its properties and their corresponding Open XML types, recursively analyzing nested types as needed.
  /// </summary>
  /// <param name="type">The model type to analyze for property-to-OpenXml type mappings.</param>
  private void AnalyzeType(Type type)
  {
    if (VisitedTypes.Contains(type))
      return;
    VisitedTypes.Add(type);

    Console.WriteLine($"Analyzing type: {type.FullName}");
    if (type.FullName! == "DocumentModel.Drawings.TabStop") Debug.Assert(true);
    var openXmlType = DocumentModel.OpenXml.OpenXmlTypeMap.GetOpenXmlTypeForModelType(type);
    if (openXmlType != null)
    {
      foreach (var prop in type.GetModelProperties())
      {
        var openXmlPropertyAttribute = prop.GetCustomAttribute<OpenXmlPropertyAttribute>();
        if (openXmlPropertyAttribute == null)
          continue;
        var propType = prop.PropertyType.GetNotNullableType();
        if (propType == typeof(Uri)) Debug.Assert(true);

        if (!propType.IsEnum && !propType.IsAbstract && !propType.IsInterface && !propType.IsGenericTypeDefinition)
        {
          if (propType.Namespace?.StartsWith("DocumentFormat.OpenXml") == true)
            continue;
          
          if (propType.IsClass && propType.GetModelProperties().Any() && propType.GetCustomAttribute<SimpleTypeAttribute>() == null)
          {
            AnalyzeType(propType);
            return;
          }
          
          var openXmlProp = DocumentModel.OpenXml.OpenXmlPropertyMap.GetOpenXmlProperty(prop, openXmlType);
          if (openXmlProp == null)
            continue;

          var openXmlPropType = openXmlProp.PropertyType.GetNotNullableType()!;
          if (propType == typeof(string) && openXmlPropType.BaseType == typeof(DX.OpenXmlLeafTextElement)) Debug.Assert(true);
          //var baseType = GetBaseType(openXmlPropType);
          if (propType == typeof(string) && openXmlPropType.BaseType == typeof(DX.OpenXmlLeafElement)) Debug.Assert(true);
        
          var openXmlPropTypeNameBaseType = GetOpenXmlTypeName(openXmlPropType);
          if (openXmlPropTypeNameBaseType.EndsWith("Dx.DX.OpenXmlCompositeElement"))
            continue;
          var mapping = new TypeMapping(FormatTypeName(propType), openXmlPropTypeNameBaseType);
          PropTypeMappings[mapping] = PropTypeMappings.TryGetValue(mapping, out var count) ? count + 1 : 1;
        }
      }
    }
  }

  /// <summary>
  ///   Gets the Open XML type name for a given type, including base type and property declarations if applicable.
  /// </summary>
  /// <param name="type">The type to get the Open XML type name for.</param>
  /// <returns>A formatted string representing the Open XML type name and its structure.</returns>
  private string GetOpenXmlTypeName(Type type)
  {
    if (type.Namespace=="DocumentFormat.OpenXml" || type.Namespace=="System")
      return FormatTypeName(type);
    var baseType = type.BaseType;
    if (baseType != null)
    {
      var valPropDeclarations = new List<string>();
      foreach (var valProp in type
                 .GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
      {
        var valPropType = valProp.PropertyType.GetNotNullableType()!;
        valPropDeclarations.Add($"{valProp.Name}: {FormatTypeName(valPropType)}");
      }
      if (valPropDeclarations.Count == 1)
          return $"{FormatTypeName(baseType)} {{ {string.Join(", ", valPropDeclarations)} }}";
      else
        return $"{FormatTypeName(baseType)}";
    }

    return FormatTypeName(type);
  }

  /// <summary>
  ///   Formats the type name, including generic arguments, using namespace abbreviations for Open XML types.
  /// </summary>
  /// <param name="type">The type to format.</param>
  /// <returns>A formatted type name string.</returns>
  private string FormatTypeName(Type type)
  {
    if (type.IsGenericType)
    {
      var genericType = type.GetGenericTypeDefinition();
      {
        var typeArgs = type.GetGenericArguments();
        return $"{SimpleTypeName(genericType)}<" + $"{string.Join(", ", typeArgs.Select(FormatTypeName))}>";
      }
    }
    return SimpleTypeName(type);
  }
  /// <summary>
  ///   Returns the simple type name with namespace abbreviation for Open XML types.
  /// </summary>
  /// <param name="type">The type to format.</param>
  /// <returns>A simple type name string with namespace abbreviation.</returns>
  private string SimpleTypeName(Type type)
  {
    var ns = type.Namespace!;
    if (Namespaces.Map.TryGetValue(ns, out var ns1))
      ns = ns1;
    var typeName = type.Name;
    var k = typeName.IndexOf('`');
    if (k > 0)
      typeName = typeName.Substring(0, k);
    return $"{ns}.{typeName}";
  }

  /// <summary>
  ///   Recursively finds the most relevant base type for an OpenXml property type, skipping common base types.
  /// </summary>
  /// <param name="openXmlPropType">The OpenXml property type to analyze.</param>
  /// <returns>The most relevant base type for the property type.</returns>
  private Type GetBaseType(Type openXmlPropType)
  {
    var baseType = openXmlPropType.BaseType;
    if (baseType == null)
      return openXmlPropType;
    if (baseType == typeof(System.Object))
      return openXmlPropType;
    if (baseType == typeof(System.ValueType))
      return openXmlPropType;
    if (baseType == typeof(DX.OpenXmlElement))
      return openXmlPropType;
    if (baseType == typeof(DX.OpenXmlSimpleType))
      return openXmlPropType;
    if (baseType == typeof(DX.OpenXmlLeafTextElement))
      return openXmlPropType;
    if (baseType == typeof(DX.OpenXmlLeafElement))
      return openXmlPropType;

    if (baseType.IsGenericType)
    {
      var genericType = baseType.GetGenericTypeDefinition();
      if (genericType == typeof(DX.OpenXmlSimpleValue<>))
        return openXmlPropType;
      if (genericType == typeof(DX.OpenXmlComparableSimpleValue<>))
        return openXmlPropType;
      if (genericType == typeof(DX.ListValue<>))
        return openXmlPropType;
      if (genericType == typeof(DX.OpenXmlComparableSimpleReference<>))
        return openXmlPropType;
    }

    return GetBaseType(baseType);
  }
}