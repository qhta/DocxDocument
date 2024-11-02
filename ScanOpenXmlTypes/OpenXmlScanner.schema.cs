using System.Reflection;
using OpenXmlDatabase;

using OpenXmlModels = OpenXmlDatabase.Models;
using Type = System.Type;

namespace ScanOpenXmlTypes;

public partial class OpenXmlScanner : IDisposable, IAsyncDisposable
{
  public void ScanSchemaFiles()
  {
    var schemaPath = Assembly.GetExecutingAssembly().Location;
    schemaPath = schemaPath.Substring(0, schemaPath.LastIndexOf('\\'));
    schemaPath = Path.Combine(schemaPath, "Schemas");
    var schemaFiles = Directory.GetFiles(schemaPath, "*.xsd");
    foreach (var schemaFile in schemaFiles)
    {
      ScanSchemaFile(schemaFile);
    }
  }


  public void ScanSchemaFile(string schemaFileName)
  {
    Console.WriteLine($"Parsing schema file {schemaFileName}");
  }
}
