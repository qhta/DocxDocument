using System.Diagnostics;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace ScanOpenXmlTypes;

internal class Program
{
  static void Main(string[] args)
  {
    using var scanner = new OpenXmlScanner();
    scanner.VerboseLevel = 2;
    //scanner.ScanAssembly();
    scanner.ScanDocumentationFile();
  }

}
