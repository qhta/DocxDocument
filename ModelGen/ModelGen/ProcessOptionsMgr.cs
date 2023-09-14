using System.Text.Json;

namespace ModelGen;
public static class ProcessOptionsMgr
{
  private static object LockObj = new object();
  public static ProcessOptions GetInstance()
  {
    lock (LockObj)
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
        catch (Exception ex)
        {
          Debug.WriteLine($"Error reading {filename}: {ex.Message}");
        }
      }
      return new ProcessOptions();
    }
  }

  public static void SaveInstance(ProcessOptions value)
  {
    lock (LockObj)
    {
      var filename = GetFilename();
      using (var stream = File.OpenWrite(filename))
        JsonSerializer.Serialize<ProcessOptions>(stream, value);
    }
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
