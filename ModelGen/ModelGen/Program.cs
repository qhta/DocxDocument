// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Wordprocessing;

using ModelGen;
using Namotion.Reflection;

public static class Program
{
  public static void Main(string[] args)
  {
    //var typeInfo = TypeManager.RegisterType(typeof(DocumentFormat.OpenXml.Wordprocessing.Rsids));
    //TypeReflector.WaitDone();
    //TypeInspector.InspectType(typeInfo);
    var filepath = Assembly.GetExecutingAssembly().Location;
    var index = filepath.IndexOf(@"\bin");
    if (index > 0)
      filepath = filepath.Substring(0, index);
    index = filepath.LastIndexOf(@"\");
    if (index > 0)
      filepath = filepath.Substring(0, index);
    filepath = Path.Combine(filepath, "DocumentModel");
    var generator = new ModelCreator("DocumentModel", filepath);
    generator.RunOn(typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly);
  }

}