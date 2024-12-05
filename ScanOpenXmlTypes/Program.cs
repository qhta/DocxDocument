using System.Diagnostics;
using System.Reflection;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace ScanOpenXmlTypes;

internal class Program
{
   static void Main(string[] args)
  {
    var docxPath = Assembly.GetExecutingAssembly().Location;
    docxPath = docxPath.Substring(0, docxPath.LastIndexOf('\\'));

    docxPath = Path.Combine(docxPath, "Clean");
    Directory.SetCurrentDirectory(docxPath);
    var cleaner = new OpenXmlCleaner();
    cleaner.VerboseLevel = 1;
    cleaner.ExampleFont = "Consolas";
    if (args.Length > 0)
    {
      cleaner.CleanDocxFile(args[0]);
    }
    else
    {
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
