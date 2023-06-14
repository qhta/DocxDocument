namespace ModelGenRun;
public static class Program
{
  //static DocumentFormat.OpenXml.Wordprocessing.Paragraph dummy;
  public static void Main(string[] args)
  {
    GenerateModelTypes(typeof(DocumentFormat.OpenXml.Packaging.WordprocessingDocument), 
      MDS.ScannedNamespaces/* | MDS.ScanValidation | MDS.ScannedTypes*/ ,
      new DisplayOptions
      { Namespaces = new string[]{ "*.Wordprocessing"},
        TypeKindSelector = TKS.Class,
        //Typenames = new string[] { "*Values" },
        TypesLimit = 0,
        DetailsLimit = 0,
        TypeStatusSelector = MSS.Accepted,
        TypeDataSelector = /*TDS.Metadata | TDS.BaseTypes | TDS.Properties | TDS.EnumValues*/ TDS.ElementSchema | TDS.OutgoingRelationships
      });
    //GenerateTypeConverters(typeof(DocumentFormat.OpenXml.Packaging.WordprocessingDocument));
  }

  public static void GenerateModelTypes(Type rootType, MDS display = MDS.None, DisplayOptions? options = null)
  {
    var filePath = Assembly.GetExecutingAssembly().Location;
    var index = filePath.IndexOf(@"\bin");
    if (index > 0)
      filePath = filePath.Substring(0, index);
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.Combine(filePath, @"ModelGen\DocumentModel");
    var creator = new ModelCreator("DocumentModel", filePath);
    creator.ModelMonitor=new ModelDisplay();
    creator.RunOn(rootType, display, options);
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
    creator.ModelMonitor=new ModelDisplay();
    creator.RunOn(rootType);
  }
}
