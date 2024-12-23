using System.Diagnostics;
using System.Reflection;

using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace ScanOpenXmlTypes;

public class Program
{
  static void Main(string[] args)
  {
    var docxPath = Assembly.GetExecutingAssembly().Location;
    docxPath = docxPath.Substring(0, docxPath.LastIndexOf('\\'));

    docxPath = Path.Combine(docxPath, "CleanIt");
    Directory.SetCurrentDirectory(docxPath);
    var cleaner = new OpenXmlCleaner();
    var argList = args.ToList();
    var verboseLevel = 1;
    if (argList.Count > 0)
    {
      var k = argList.IndexOf("-v");
      if (k >= 0)
      {
        if (k < argList.Count - 1)
        {
          verboseLevel = int.Parse(argList[k + 1]);
          argList.RemoveAt(k + 1);
        }
        argList.RemoveAt(k);
      }
    }
    if (argList.Count > 0)
    {
      cleaner.VerboseLevel = verboseLevel;
      cleaner.ExampleFont = "Consolas";
      cleaner.CleanDocxFile(args[0]);
    }
    else
    {
      cleaner.VerboseLevel = verboseLevel;
      cleaner.ExampleFont = "Consolas";
      cleaner.CleanDocxFiles();
    }
    //using var scanner = new OpenXmlScanner();
    //scanner.VerboseLevel = 2;
    ////scanner.ScanAssembly();
    ////scanner.ScanDocumentationFile();
    ////scanner.ScanSchemaFiles();
    //scanner.ScanDocxFiles();
  }

}
