using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Reflection;

using DX = DocumentFormat.OpenXml;

using DocumentModel.OpenXml;

using Qhta.TypeUtils;

namespace AnalyzeModelTypeMapping;

/// <summary>
/// Indicates a mapping between a model type and an Open XML type.
/// </summary>
/// <param name="ModelType"></param>
/// <param name="OpenXmlType"></param>
public record struct TypeMapping(string ModelType, string OpenXmlType)
{
  public string ModelType { get; } = ModelType;
  public string OpenXmlType { get; } = OpenXmlType;

}

/// <summary>
/// Represents a collection that maps <see cref="TypeMapping"/> instances to their count of occurrences.
/// </summary>
public class TypeMappings : Dictionary<TypeMapping, int>
{
}

/// <summary>
/// This class gets all types from the dependent project and analyzes their mappings to Open XML elements and attributes.
/// </summary>
public class AnalyzeTypeMapping
{
  private readonly List<Type> VisitedTypes = new();
  private readonly TypeMappings PropTypeMappings = new();
  private static readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.DocPart).Assembly;

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
  /// Generates a report of the type mappings and their counts to a specified file.
  /// Uses tab-delimited format.
  /// </summary>
  /// <param name="filePath"></param>
  public void GenerateReport(string filePath)
  {
    using var writer = new StreamWriter(filePath);
    writer.WriteLine("ModelType;OpenXmlType;Count");
    foreach (var (mapping, count) in PropTypeMappings)
    {
      writer.WriteLine($"{mapping.ModelType};{mapping.OpenXmlType};{count}");
    }
  }


  /// <summary>
  /// Analyzes a given type to find its properties and their corresponding Open XML types.
  /// </summary>
  /// <param name="type"></param>
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
          var mapping = new TypeMapping(FormatTypeName(propType), openXmlPropTypeNameBaseType);
          PropTypeMappings[mapping] = PropTypeMappings.TryGetValue(mapping, out var count) ? count + 1 : 1;
        }
      }
    }
  }

  /// <summary>
  /// Gets the Open XML type name for a given type.
  /// </summary>
  /// <param name="type">The type to get the Open XML type name for.</param>
  /// <returns></returns>
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
      if (valPropDeclarations.Count > 0)
        return
          $"base: {FormatTypeName(baseType)} {{ {string.Join(", ", valPropDeclarations)} }}";
      else
        return $"base: {FormatTypeName(baseType)}";
    }

    return FormatTypeName(type);
  }

  private static Dictionary<string, string> namespaces = new Dictionary<string, string>
  {
    { "DocumentFormat.OpenXml", "DX" },
    { "DocumentFormat.OpenXml.Bibliography", "DXB" },
    { "DocumentFormat.OpenXml.CustomProperties", "DXCP" },
    { "DocumentFormat.OpenXml.CustomXmlSchemaReferences", "DXCXSR" },
    { "DocumentFormat.OpenXml.Drawing", "DXD" },
    { "DocumentFormat.OpenXml.Drawing.Diagrams", "DXDD" },
    { "DocumentFormat.OpenXml.Drawing.Pictures", "DXDP" },
    { "DocumentFormat.OpenXml.Drawing.Wordprocessing", "DXDW" },
    { "DocumentFormat.OpenXml.ExtendedProperties", "DXEP" },
    { "DocumentFormat.OpenXml.Math", "DXM" },
    { "DocumentFormat.OpenXml.Office2010.Drawing", "DXO10D" },
    { "DocumentFormat.OpenXml.Office2010.Drawing.Pictures", "DXO10DP" },
    { "DocumentFormat.OpenXml.Office2010.Word", "DXO10W" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas", "DXO10WDC" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingGroup", "DXO10WDG" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingShape", "DXO10WDS" },
    { "DocumentFormat.OpenXml.Office2013.Drawing", "DXO13D" },
    { "DocumentFormat.OpenXml.Office2013.Theme", "DXO13T" },
    { "DocumentFormat.OpenXml.Office2013.Word", "DXO13W" },
    { "DocumentFormat.OpenXml.Office2016.Drawing", "DXO16D" },
    { "DocumentFormat.OpenXml.Office2019.Drawing", "DXO19D" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.SVG", "DXO19DS" },
    { "DocumentFormat.OpenXml.Office2019.Word.Cid", "DXO19WC" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification", "DXO21DDC" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.Livefeed", "DXO21DL" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes", "DXO21DSS" },
    { "DocumentFormat.OpenXml.Office2021.MipLabelMetaData", "DXO21MLMD" },
    { "DocumentFormat.OpenXml.Office2021.Word.CommentsExt", "DXO21WCE" },
    { "DocumentFormat.OpenXml.Office.Drawing", "DXOD" },
    { "DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed", "DXODY21OE" },
    { "DocumentFormat.OpenXml.Office.Word", "DXOW" },
    { "DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink", "DXOY21SL" },
    { "DocumentFormat.OpenXml.Packaging", "DXPP" },
    { "DocumentFormat.OpenXml.Vml", "DXV" },
    { "DocumentFormat.OpenXml.Vml.Office", "DXVO" },
    { "DocumentFormat.OpenXml.VariantTypes", "DXVT" },
    { "DocumentFormat.OpenXml.Wordprocessing", "DXW" },
  };

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
  private string SimpleTypeName(Type type)
  {
    var ns = type.Namespace!;
    if (namespaces.TryGetValue(ns, out var ns1))
      ns = ns1;
    var typeName = type.Name;
    var k = typeName.IndexOf('`');
    if (k > 0)
      typeName = typeName.Substring(0, k);
    return $"{ns}.{typeName}";
  }

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