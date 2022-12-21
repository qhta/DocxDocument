namespace DocumentModel.Wordprocessing;

public partial class SettingsImpl
{
  public int Count
  {
    get
    {
      var settingsProperties = typeof(Settings).GetProperties().Where(item => item.Name!="Count").ToArray();
      int settingsCount = 0;
      foreach (var prop in settingsProperties)
        if (prop.GetValue(this, null) != null)
        {
          settingsCount++;
        }
      return settingsCount;
    }
  }

  public object? Get(string propName)
  {
    var prop = typeof(Settings).GetProperty(propName);
    return prop?.GetValue(this, null);
  }
}