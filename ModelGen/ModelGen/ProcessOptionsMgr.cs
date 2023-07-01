using System.Text.Json;

namespace ModelGen;
public static class ProcessOptionsMgr
{
  public static ProcessOptions GetInstance()
  {
    var filename = GetFilename();
    if (File.Exists(filename))
    {
      try
      {
        using (var stream = File.OpenRead(filename))
        {
          var result = JsonSerializer.Deserialize<ProcessOptions>(stream);
          if (result != null)
            return result;
        }
      }
      catch// (Exception ex)
      {
      }
    }
    return new ProcessOptions();
  }

  public static void SaveInstance(ProcessOptions value)
  {
    var filename = GetFilename();
    using (var stream = File.OpenWrite(filename))
      JsonSerializer.Serialize<ProcessOptions>(stream, value);
  }

  public static string GetFilename()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, "ProcessOptions.json");
    return path;
  }
}
