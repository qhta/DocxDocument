using AnalyzeModelTypeMapping;

using System.Xml.Linq;

public static class Program
{
  public static void Main(string[] args)
  {
    var analyzer = new AnalyzeTypeMapping();
    analyzer.ScanPropTypeMappings(typeof(DocumentModel.Wordprocessing.Document).Assembly);
    var reportFileName = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "TypeMappingReport.txt"));
    analyzer.GenerateReport(reportFileName);
  }
}