using AnalyzeModelTypeMapping;

using System.Xml.Linq;

public static class Program
{
  public static void Main(string[] args)
  {
    var analyzer = new AnalyzeTypeMapping();
    analyzer.ScanPropTypeMappings(typeof(DocumentModel.Wordprocessing.Document).Assembly);
    var basePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
    var reportFileName = Path.Combine(basePath, "TypeMappingReport.csv");
    analyzer.GenerateReport(reportFileName);
    //analyzer.GenerateUnmappedReport(Path.Combine(basePath, "UnmappedPropTypes.txt"));
  }
}