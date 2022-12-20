namespace DocumentModel.Properties;

public partial class CorePropertiesImpl
{
  public int Count
  {
    get
    {
      var coreProperties = typeof(CoreProperties).GetProperties();
      int corePropertiesCount = 0;
      foreach (var prop in coreProperties)
        if (prop.GetValue(this, null) != null)
          corePropertiesCount++;
      return corePropertiesCount;
    }
  }

  public object? Get(string propName)
  {
    var prop = typeof(CoreProperties).GetProperty(propName);
    return prop?.GetValue(this, null);
  }
}