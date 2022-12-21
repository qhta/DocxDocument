using System.Diagnostics;

namespace DocumentModel.Properties;

public partial class ExtendedPropertiesImpl
{
  public int Count()
  {
    var extendedProperties = typeof(ExtendedProperties).GetProperties().Where(item => item.Name != "Count");
    int extendedPropertiesCount = 0;
    foreach (var prop in extendedProperties)
      if (prop.GetValue(this, null) != null)
      {
        extendedPropertiesCount++;
      }
    return extendedPropertiesCount;
  }

  public object? Get(string propName)
  {
    var prop = typeof(ExtendedProperties).GetProperty(propName);
    return prop?.GetValue(this, null);
  }

}