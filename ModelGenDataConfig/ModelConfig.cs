using System.Diagnostics;

namespace ModelGenDataConfig;

public static class ModelConfig
{

  public static ModelConfigData CreateInstance(string? dataFolder)
  {
    DataFolder = dataFolder;
    Instance = new ModelConfigData(dataFolder);
    return Instance;
  }

  public static void LoadInstance(string? dataFolder)
  {
    //Debug.WriteLine($"ModelConfig.LoadInstance({dataFolder})");

    DataFolder = dataFolder;
    Instance = new ModelConfigData(dataFolder);
    Instance.LoadData(dataFolder);

  }
  public static string? DataFolder { get; private set; } = "";

  public static ModelConfigData? Instance { get; private set; } = null!;

  public static string GetAppDataBase()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    return path;
  }

  public static string GetFilename(string? dataFolder)
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (dataFolder!=null)
      path = Path.Combine(path, dataFolder);
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, "ModelConfig.txt");
    return path;
  }

  public static string GetFilename() => GetFilename(DataFolder);

  #region utils

  public static (string, string) SplitNameToTypeAndProperty(string fullPropName)
  {
    var k = fullPropName.LastIndexOf('.');
    if (k > 0 && k < fullPropName.Length - 1)
      return (fullPropName.Substring(0, k), fullPropName.Substring(k + 1));
    else
      return ("", fullPropName);
  }

  public static string JoinTypeAndProperty(string typeName, string propName)
  {
    if (!String.IsNullOrEmpty(typeName))
      return typeName + "." + propName;
    else
      return propName;
  }
  #endregion
}