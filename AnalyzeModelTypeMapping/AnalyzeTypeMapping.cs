using System.Reflection;

namespace AnalyzeModelTypeMapping;

/// <summary>
/// Indicates a mapping between a model type and an Open XML type.
/// </summary>
/// <param name="ModelType"></param>
/// <param name="OpenXmlType"></param>
public record struct TypeMapping(Type ModelType, Type OpenXmlType)
{
  public Type ModelType { get; } = ModelType;
  public Type OpenXmlType { get; } = OpenXmlType;

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
  private static readonly TypeMappings PropTypeMappings = new();
  private static readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.DocPart).Assembly;

  public void ScanPropTypeMappings(Assembly modelAssembly)
  {
    foreach (var type in modelAssembly.GetTypes().Where(type => !type.IsEnum && !type.IsAbstract && !type.IsInterface))
    {
      AnalyzeType(type);
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
    writer.WriteLine("ModelType\tOpenXmlType\tCount");
    foreach (var (mapping, count) in PropTypeMappings)
    {
      writer.WriteLine($"{mapping.ModelType}\t{mapping.OpenXmlType}\t{count}");
    }
  }

  private void AnalyzeType(Type type)
  {
    var openXmlType = DocumentModel.OpenXml.OpenXmlTypeMap.GetOpenXmlTypeForModelType(type);
    if (openXmlType != null)
    {
      foreach (var prop in type.GetProperties())
      {
        var propType = prop.PropertyType;
        if (!propType.IsEnum && !propType.IsAbstract && !propType.IsInterface && !propType.IsGenericTypeDefinition)
        {
          var propOpenXmlType = DocumentModel.OpenXml.OpenXmlTypeMap.GetOpenXmlTypeForModelType(propType);
          if (propOpenXmlType != null && propOpenXmlType.Assembly == OpenXmlAssembly)
          {
            var mapping = new TypeMapping(propType, propOpenXmlType);
            PropTypeMappings[mapping] = PropTypeMappings.TryGetValue(mapping, out var count) ? count + 1 : 1;
          }
        }
      }
    }
  }
}