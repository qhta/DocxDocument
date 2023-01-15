using System.Reflection;

using ModelGen;

using Qhta.TypeUtils;

public static class Program
{

  public static void Main(string[] args)
  {
    //GenerateModelTypes();
    GenerateTypeConverter(typeof(DocumentFormat.OpenXml.Packaging.WordprocessingDocument));
  }

  public static void GenerateModelTypes()
  {
    var filePath = Assembly.GetExecutingAssembly().Location;
    var index = filePath.IndexOf(@"\bin");
    if (index > 0)
      filePath = filePath.Substring(0, index);
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.Combine(filePath, "DocumentModel");
    var creator = new ModelCreator("DocumentModel", filePath);
    creator.RunOn(typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly);
  }

  public static void GenerateTypeConverter(Type type)
  {
    var filePath = Assembly.GetExecutingAssembly().Location;
    var index = filePath.IndexOf(@"\bin");
    if (index > 0)
      filePath = filePath.Substring(0, index);
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.GetDirectoryName(filePath) ?? "";
    filePath = Path.Combine(filePath, "DocumentModel");
    var creator = new ConverterCreator("DocumentModel", filePath);
    creator.RunOn(type);
  }
}
