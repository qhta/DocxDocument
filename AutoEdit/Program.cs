using AutoEdit;

using System.Xml.Linq;

using DocumentFormat.OpenXml.Drawing;

using Path = System.IO.Path;

/// <summary>
/// Entry point for the AutoEdit utilities used to process project source files.
/// </summary>
public static class Program
{
  /// <summary>
  /// Discovers the primary project referenced by the tooling project and runs selected transformers over its C# files.
  /// </summary>
  /// <param name="args">Optional command-line arguments (currently unused).</param>
  public static void Main(string[] args)
  {
    // Load the main project file
    string projectDir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
    var mainProjectFile = Directory.GetFiles(projectDir, "*.csproj", SearchOption.TopDirectoryOnly).FirstOrDefault();
    if (mainProjectFile != null)
    {
      var doc = XDocument.Load(mainProjectFile);
      var firstReference = doc.Descendants("ProjectReference").FirstOrDefault();
      if (firstReference != null)
      {
        var projectFileName = firstReference.Attribute("Include")?.Value;
        if (projectFileName != null)
        {
          var projectPath = Path.GetDirectoryName(projectFileName)!;
          projectPath = Path.GetFullPath(Path.Combine(projectDir, projectPath));

          var fileList = GetFiles(projectPath);
          foreach (var filePath in fileList)
          {
            //MoveEnumType.Run(filePath);
            //GenerateShouldSerializeFunctions.Run(filePath);
            //AddPrivateFieldsWithUpdate.Run(filePath);
            //AddOpenXmlPropertyAttribute.Run(filePath);
            //AddOpenXmlEnumTypeAttribute.Run(filePath);
            //AddOpenXmlTypeAttribute.Run(filePath);
            //RemoveDuplicateDocComments.Run(filePath);
            AddOpenXmlEnumTypeAttribute.Run(filePath);
          }
        }
      }
    }
  }

  static readonly string[] ignoredDirs =
  [
    "obj",
    "bin",
    "Attributes",
    "Base classes",
    "Base interfaces",
    "Converters",
    "Helpers",
  ];

  /// <summary>
  /// Recursively collects C# files under the specified directory, skipping ignored folders and helper files.
  /// </summary>
  /// <param name="path">Root directory to scan.</param>
  /// <returns>List of file paths that satisfy the inclusion rules.</returns>
  static List<string> GetFiles(string path)
  {
    var result = new List<string>();
    foreach (var file in Directory.GetFiles(path, "*.cs"))
    {
      var filename = Path.GetFileNameWithoutExtension(file);
      if (filename.Equals("GlobalUsings", StringComparison.OrdinalIgnoreCase)
          || filename.Equals("Program", StringComparison.OrdinalIgnoreCase))
        continue;
      if (filename.Contains(".") && !filename.EndsWith(".Properties", StringComparison.OrdinalIgnoreCase))
        continue;
      //if (filename.EndsWith("NonVisualDrawingShapeExtensionList"))
      result.Add(file);
    }
    foreach (var dir in Directory.GetDirectories(path))
    {
      var dirName = Path.GetFileName(dir);
      if (ignoredDirs.Contains(dirName, StringComparer.OrdinalIgnoreCase))
        continue;
      result.AddRange(GetFiles(dir));
    }
    return result;
  }
}