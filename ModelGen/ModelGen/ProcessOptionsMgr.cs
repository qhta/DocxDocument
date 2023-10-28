using Newtonsoft.Json;

namespace ModelGen;
public static class ProcessOptionsMgr
{
  private static object LockObj = new object();

  public static string DataFolder = "";

  private static Dictionary<string, ProcessOptions> Instances = new();

  public static ProcessOptions GetInstance(string? dataFolder = null)
  {
    lock (LockObj)
    {
      if (dataFolder != null)
        DataFolder = dataFolder;
      var instanceKey = dataFolder ?? "";
      if (Instances.TryGetValue(instanceKey, out var result))
        return result;

      var filename = GetFilename();
      if (File.Exists(filename))
      {
        try
        {
          using (var textFile = File.OpenText(filename))
          {
            var text = textFile.ReadToEnd();
            //using (var reader = new Newtonsoft.Json.JsonTextReader(text))
            {
              //var serializer = new Newtonsoft.Json.JsonSerializer();
              result = JsonConvert.DeserializeObject<ProcessOptions>(text);
              if (result != null)
              {
                var aDataFolder = result.AppDataFolder;
                if (!string.IsNullOrEmpty(aDataFolder) && aDataFolder!=DataFolder)
                {
                  result = GetInstance(aDataFolder);
                  result.AppDataFolder = aDataFolder;
                }
                Instances.Add(instanceKey, result);
                return result;
              }
            }
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
  public static string GetFilename(string? dataFolder)
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    if (dataFolder != null)
      path = Path.Combine(path, dataFolder);
    path = Path.Combine(path, "ProcessOptions.json");
    return path;
  }

  public static string GetFilename() => GetFilename(DataFolder);

  public static Type[] GetGeneratorTypes()
  {
    var assembly = Assembly.GetAssembly(typeof(BaseCodeGenerator));
    return assembly!.GetTypes().Where(item=>item.BaseType == typeof(BaseCodeGenerator)).ToArray();
  }
}
