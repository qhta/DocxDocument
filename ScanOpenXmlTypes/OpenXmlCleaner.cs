using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ScanOpenXmlTypes;
internal class OpenXmlCleaner
{
  public int VerboseLevel { get; set; } = 3;

  public void CleanDocxFiles()
    {
      var docxPath = Assembly.GetExecutingAssembly().Location;
      docxPath = docxPath.Substring(0, docxPath.LastIndexOf('\\'));
      docxPath = Path.Combine(docxPath, "Clean");
      var docxFiles = Directory.GetFiles(docxPath, "*.docx");
      foreach (var schemaFile in docxFiles)
      {
        CleanDocxFile(schemaFile);
      }
    }
    public void CleanDocxFile(string docxFileName)
    {
      if (VerboseLevel > 0)
        Console.WriteLine($"Cleaning documentation file {docxFileName}");
      var newDocxDirectory = Path.GetDirectoryName(docxFileName) + "Packed";
      var newDocxFileName = Path.Combine(newDocxDirectory, Path.GetFileName(docxFileName));
      if (!Directory.Exists(newDocxDirectory))
        Directory.CreateDirectory(newDocxDirectory);
      File.Copy(docxFileName, newDocxFileName, true);
      var cleaner = new Qhta.OpenXmlTools.OpenXmlCleaner();
      cleaner.VerboseLevel = VerboseLevel;
    cleaner.CleanDocument(newDocxFileName);

    }

  }
