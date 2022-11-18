// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using ModelGen;
using Namotion.Reflection;

public static class Program
{
  public static void Main(string[] args)
  {

    //var documentation = typeof(DocumentFormat.OpenXml.Math.MatrixProperties).GetXmlDocsElement();
    //if (documentation != null)
    //{
    //  var types = DocumentationReader.GetChildItemTypes(documentation,typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly);
    //  if (types != null)
    //  {
    //    foreach (var type in types)
    //    {
    //      Console.WriteLine($"Type: {type}");
    //    }
    //  }
    //}
    var filepath = Assembly.GetExecutingAssembly().Location;
    var index = filepath.IndexOf(@"\bin");
    if (index > 0)
      filepath = filepath.Substring(0, index);
    index = filepath.LastIndexOf(@"\");
    if (index > 0)
      filepath = filepath.Substring(0, index);
    filepath = Path.Combine(filepath, "GeneratedModel");
    var generator = new Generator("GeneratedModel", filepath);
    generator.GenLibrary(typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly);
  }


  //private static string XmlDocumentationKeyHelper(
  //  string typeFullNameString,
  //  string? memberNameString)
  //{
  //  string key = Regex.Replace(
  //    typeFullNameString, @"\[.*\]",
  //    string.Empty).Replace('+', '.');
  //  if (memberNameString != null)
  //  {
  //    key += "." + memberNameString;
  //  }
  //  return key;
  //}

}