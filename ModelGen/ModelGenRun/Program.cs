using System.Reflection;

using ModelGen;

using Qhta.TypeUtils;

public static class Program
{

  public static void Main(string[] args)
  {
    GenerateModelTypes(typeof(DocumentFormat.OpenXml.Packaging.WordprocessingDocument), MDS.ScannedNamespaces | MDS.ScannedTypes,
      new DisplayOptions
      { Namespaces = new string[]{ "*.Packaging*"},
        //TypeKindSelector = TKS.Enum,
        //Typenames = new string[]{ "*Values" },
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
    creator.RunOn(rootType);
  }
}
