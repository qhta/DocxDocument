using System.Diagnostics;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace ScanOpenXmlTypes;

internal class Program
{
   static void Main(string[] args)
  {
    var cleaner = new OpenXmlCleaner();
    cleaner.VerboseLevel = 2;
    cleaner.ExampleFont = "Consolas";
    cleaner.CleanDocxFiles();
    //using var scanner = new OpenXmlScanner();
    //scanner.VerboseLevel = 2;
    ////scanner.ScanAssembly();
    ////scanner.ScanDocumentationFile();
    ////scanner.ScanSchemaFiles();
    //scanner.ScanDocxFiles();
  }

}
