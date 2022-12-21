using System.Diagnostics;

namespace DocumentModel.Properties;

public partial class CorePropertiesImpl//: IEnumerable<KeyValuePair<string, object?>
{
  public int Count()
  {
    var coreProperties = typeof(CoreProperties).GetProperties().Where(item => item.Name != "Count").ToArray();
    int corePropertiesCount = 0;
    foreach (var prop in coreProperties)
      if (prop.GetValue(this, null) != null)
      {
        corePropertiesCount++;
      }
    return corePropertiesCount;
  }

  public object? Get(string propName)
  {
    var prop = typeof(CoreProperties).GetProperty(propName);
    return prop?.GetValue(this, null);
  }
}