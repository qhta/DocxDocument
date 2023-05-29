using System.Reflection;

//using ModelParsing;
using DocumentModel;
using System.Diagnostics;
using Qhta.TypeUtils;

namespace CodeFix;

public static class Program
{

  public static void Main(string[] args)
  {
    FixModelTypes();
    //FixTypeConverter(typeof(DocumentFormat.OpenXml.Packaging.WordprocessingDocument));
  }

  public static void FixModelTypes()
  {
    var thisAssembly = Assembly.GetExecutingAssembly();
    var thisAssemblyName = thisAssembly.GetName().Name;
    var assembly = typeof(DocumentModel.Wordprocessing.Document).Assembly;
    var assemblyName = assembly.GetName().Name; 
    var codePath = assembly.Location;
    while (Path.GetFileName(codePath)!=thisAssemblyName)
      codePath = Path.GetDirectoryName(codePath);
    codePath = Path.GetDirectoryName(codePath);
    Debug.Assert(codePath!=null);
    Debug.Assert(assemblyName!=null);
    codePath = Path.Combine(codePath, assemblyName);
    Debug.WriteLine(codePath);
    Debug.Assert(codePath!=null);
    var files = Directory.GetFiles(codePath, "*.cs", new EnumerationOptions{ RecurseSubdirectories = true })
      .Where(file=>Path.GetFileName(file)!="GlobalUsings.cs").ToList();
    var model = assembly.GetTypes();
    var parser = new ModelParser(codePath, model);
    foreach (var file in files)
    { 
      var filename = file.Substring(codePath.Length+1);
      parser.ParseType(filename);
      break;
    }
    
  }

  //public static void FixTypeConverter(Type type)
  //{
  //  var filePath = Assembly.GetExecutingAssembly().Location;
  //  var index = filePath.IndexOf(@"\bin");
  //  if (index > 0)
  //    filePath = filePath.Substring(0, index);
  //  filePath = Path.GetDirectoryName(filePath) ?? "";
  //  filePath = Path.GetDirectoryName(filePath) ?? "";
  //  filePath = Path.Combine(filePath, "DocumentModel");
  //  var creator = new ConverterCreator("DocumentModel", filePath);
  //  creator.RunOn(type);
  //}
}

