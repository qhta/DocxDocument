using System.Diagnostics;

namespace ModelGenRun;
public static class Program
{
  //static DocumentFormat.OpenXml.Wordprocessing.Zoom dummy;
  public static void Main(string[] args)
  {
    var options = new ProcessOptions
    {
      ScanTypeName = "DocumentFormat.OpenXml.Packaging.WordprocessingDocument",
      Display = MDS.ScannedNamespaces
      //| MDS.ScanValidation 
      | MDS.ScannedTypes,
      //| MDS.TypeRename,
      DisplayOptions = new DisplayOptions
      {
        Namespaces = new string[] { "*.Drawing*" },
        TypeKindSelector = TKS.Class,
        //Typenames = new string[] { "*Values" },
        TypesLimit = 0,
        DetailsLimit = 0,
        TypeStatusSelector = MSS.Accepted,
        TypeDataSelector = 0
                          | TDS.Metadata
                          | TDS.BaseTypes
                          | TDS.Properties
        //| TDS.EnumValues 
        //| TDS.ElementSchema 
        //| TDS.OutgoingRelationships
      }
    };
    GenerateModelTypes(options);
    //GenerateTypeConverters(typeof(DocumentFormat.OpenXml.Packaging.WordprocessingDocument));
  }

public static void GenerateModelTypes(ProcessOptions options)
{
  var filePath = Assembly.GetExecutingAssembly().Location;
  var index = filePath.IndexOf(@"\bin");
  if (index > 0)
    filePath = filePath.Substring(0, index);
  filePath = Path.GetDirectoryName(filePath) ?? "";
  filePath = Path.GetDirectoryName(filePath) ?? "";
  filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
  var creator = new ModelCreator("DocumentModel", filePath);
  creator.ModelMonitor = new ModelDisplay();
  creator.RunProcess(options);
}

public static void GenerateTypeConverters(Type rootType)
{
  var filePath = Assembly.GetExecutingAssembly().Location;
  var index = filePath.IndexOf(@"\bin");
  if (index > 0)
    filePath = filePath.Substring(0, index);
  filePath = Path.GetDirectoryName(filePath) ?? "";
  filePath = Path.GetDirectoryName(filePath) ?? "";
  filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
  var creator = new ConverterCreator("DocumentModel", filePath);
  creator.ModelMonitor = new ModelDisplay();
  creator.RunOn(rootType);
}
}
