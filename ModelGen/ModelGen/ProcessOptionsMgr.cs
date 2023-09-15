using Newtonsoft.Json;

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
          using (var text = File.OpenText(filename))
          using (var reader = new Newtonsoft.Json.JsonTextReader(text))
          {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            var result = serializer.Deserialize<ProcessOptions>(reader);
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
      using (var text = File.CreateText(filename))
      {
        var serializer = new Newtonsoft.Json.JsonSerializer();
        serializer.Serialize(text, value);
      }
    }
  }

  public static void SaveInstanceToXml(ProcessOptions value)
  {
    lock (LockObj)
    {
      var filename = GetFilename();
      filename = Path.ChangeExtension(filename, ".xml");
      using (var stream = File.OpenWrite(filename))
      {
        var serializer = new QXmlSerializer(typeof(ProcessOptions));
        serializer.Serialize(stream, value);
      }
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
