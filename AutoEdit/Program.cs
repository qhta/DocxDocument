using AutoEdit;

using System.Xml.Linq;

public static class Program
{
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
            var filename = Path.GetFileNameWithoutExtension(filePath);
            var ShouldSerializeFile = filename + ".ShouldSerialize.cs";
            if (File.Exists(Path.Combine(Path.GetDirectoryName(filePath)!, ShouldSerializeFile)))
              continue;
            GenerateShouldSerializeFunctions.Run(filePath);
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

  static List<string> GetFiles(string path)
  {
    var result = new List<string>();
    foreach (var file in Directory.GetFiles(path, "*.cs"))
    {
      var filename = Path.GetFileNameWithoutExtension(file);
      if (filename.Equals("GlobalUsings", StringComparison.OrdinalIgnoreCase)
          || filename.Equals("Program", StringComparison.OrdinalIgnoreCase))
        continue;
      if (filename.Contains(".") || filename.EndsWith(".Properties", StringComparison.OrdinalIgnoreCase))
        continue;
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