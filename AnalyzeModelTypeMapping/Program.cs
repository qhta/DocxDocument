public static class Program
{
  public static void Main(string[] args)
  {
    ListOpenXmlLeafElements(typeof(DX.UInt64Value));

    //var analyzer = new AnalyzeTypeMapping();
    //analyzer.ScanPropTypeMappings(typeof(DocumentModel.Wordprocessing.Document).Assembly);
    //var basePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
    //var reportFileName = Path.Combine(basePath, "TypeMappingReport.csv");
    //analyzer.GenerateReport(reportFileName);
  }

  /// <summary>
  /// Lists all OpenXmlLeafElement types that have a single property of given type.
  /// </summary>
  /// <param name="propertyType">The property type to filter by.</param>
  private static void ListOpenXmlLeafElements(Type propertyType)
  {
    var OpenXmlEnumTypes = typeof(DXW.ActiveRecord).Assembly.GetTypes().Where(type => type.BaseType?.Name.StartsWith("OpenXmlLeafElement") == true && type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Length == 1 && type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly).Any(prop => prop.PropertyType == propertyType));
    foreach (var type in OpenXmlEnumTypes)
    {
      Console.WriteLine($"Found OpenXmlLeafElement type: {type.FullName}");
    }
  }
}