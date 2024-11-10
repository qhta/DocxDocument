using System.Reflection;

using Qhta.OpenXmlTools;

namespace ScanOpenXmlTypes;

public class OpenXmlCleaner : DocumentCleaner
{

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
    try
    {
      File.Copy(docxFileName, newDocxFileName, true);
    } catch (Exception e)
    {
      Console.WriteLine(e);
      File.Copy(docxFileName, newDocxFileName, true);
    }

    CleanDocument(newDocxFileName);
  }

}
