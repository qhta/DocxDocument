using System.Diagnostics;
using System.Reflection.Metadata;

namespace DocumentModel.Properties;

public partial class CoreProperties : IEnumerable<DocumentProperty>
{
  public int Count()
  {
    var properties = typeof(CoreProperties).GetProperties().Where(item => item.Name != "Count").ToArray();
    int corePropertiesCount = 0;
    foreach (var prop in properties)
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

  public bool Set(string propName, object? value)
  {
    var prop = typeof(CoreProperties).GetProperty(propName);
    if (prop != null)
    {
      prop.SetValue(this, value);
      return true;
    }
    return false;
  }

  public static string[] GetPropNames()
  {
    return typeof(CoreProperties).GetProperties().Where(item => item.Name != "Count").Select(item => item.Name).ToArray();
  }

  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    var properties = typeof(CoreProperties).GetProperties().Where(item => item.Name != "Count").ToArray();
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