using System.Diagnostics;

namespace DocumentModel.Properties;

public partial class ExtendedProperties: IEnumerable<DocumentProperty>
{
  public int Count()
  {
    var properties = typeof(ExtendedProperties).GetProperties().Where(item => item.Name != "Count");
    int extendedPropertiesCount = 0;
    foreach (var prop in properties)
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

  public bool Set(string propName, object? value)
  {
    var prop = typeof(ExtendedProperties).GetProperty(propName);
    if (prop != null)
    {
      prop.SetValue(this, value);
      return true;
    }
    return false;
  }

  public static string[] GetPropNames()
  {
    return typeof(ExtendedProperties).GetProperties().Where(item => item.Name != "Count").Select(item => item.Name).ToArray();
  }

  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    var properties = typeof(ExtendedProperties).GetProperties().Where(item => item.Name != "Count").ToArray();
    foreach (var prop in properties)
    {
      var value = prop.GetValue(this, null);
      if (value != null)
      {
        yield return new DocumentProperty { Name = prop.Name, Value = value };
      }
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(object item)
  {
    if (item is DocumentProperty documentProperty)
    {
      if (documentProperty.Name != null)
        Set(documentProperty.Name, documentProperty);
    }
  }

}