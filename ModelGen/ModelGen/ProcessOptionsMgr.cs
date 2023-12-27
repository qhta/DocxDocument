using Newtonsoft.Json;

namespace ModelGen;
public static class ProcessOptionsMgr
{
  private static object LockObj = new object();

  public static string? DataFolder { get; set; }

  private static Dictionary<string, ProcessOptions> Instances = new();

  public static string? LoadInstanceName()
  {
    lock (LockObj)
    {
      var filename = GetFilename();
      if (File.Exists(filename))
      {
        try
        {
          using (var textFile = File.OpenText(filename))
          {
            var text = textFile.ReadToEnd();

            var options = JsonConvert.DeserializeObject<ProcessOptions>(text);
            return options?.AppDataFolder;
          }
        }
        catch (Exception ex)
        {
          Debug.WriteLine($"Error reading {filename}: {ex.Message}");
        }
      }
      return null;
    }
  }

  public static ProcessOptions CurrentInstance => GetInstance(DataFolder);

  public static ProcessOptions GetInstance(string? dataFolder = null)
  {
    lock (LockObj)
    {
      if (dataFolder != null)
        DataFolder = dataFolder;
      var instanceKey = dataFolder ?? "";
      if (Instances.TryGetValue(instanceKey, out var result))
        return result;

      var instance = LoadInstance(dataFolder);
      Instances.Add(instanceKey, instance);
      return instance;
    }
  }

    public static ProcessOptions LoadInstance(string? dataFolder = null)
  {
    lock (LockObj)
    {
      ProcessOptions result = new ProcessOptions();
      var filename = GetFilename(dataFolder);
      if (File.Exists(filename))
      {
        try
        {
          using (var textFile = File.OpenText(filename))
          {
            var text = textFile.ReadToEnd();

            var newResult = JsonConvert.DeserializeObject<ProcessOptions>(text);
            if (newResult != null)
            {
              if (dataFolder!=null)
                newResult.AppDataFolder = dataFolder;
              result = newResult;
            }
          }
        }
        catch (Exception ex)
        {
          Debug.WriteLine($"Error reading {filename}: {ex.Message}");
        }
      }
      return result;
    }
  }

  public static void SaveInstanceName(string name)
  {
    lock (LockObj)
    {
      var filename = GetFilename();
      using (var text = File.CreateText(filename))
      {
        var options = new ProcessOptions{ AppDataFolder=name };
        var serializer = new Newtonsoft.Json.JsonSerializer();
        serializer.Serialize(text, options);
      }
    }
  }

  public static void SaveInstance(ProcessOptions value)
  {
    lock (LockObj)
    {
      var filename = GetFilename(value.AppDataFolder);
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
  public static string GetFilename(string? dataFolder = null)
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

  public static Type[] GetGeneratorTypes()
  {
    var assembly = Assembly.GetAssembly(typeof(BaseCodeGenerator));
    return assembly!.GetTypes().Where(item => item.IsSubclassOf(typeof(BaseCodeGenerator))).ToArray();
  }
}
