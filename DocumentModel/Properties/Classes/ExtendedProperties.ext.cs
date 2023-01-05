using System.Diagnostics;
using System.Text.Json.Nodes;

using Qhta.Conversion;

namespace DocumentModel.Properties;

public partial class ExtendedProperties : ICollection<DocumentProperty>
{
  public int Count()
  {
    int corePropertiesCount = 0;
    foreach (var name in GetPropNames())
    {
      var item = Get(name);
      if (item != null)
        corePropertiesCount++;
    }
    return corePropertiesCount;
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
      if (value is String valStr && value.GetType() != prop.PropertyType)
      {
        var typeConverter = new ValueTypeConverter(prop.PropertyType, null, null, null, null);
        value = typeConverter.ConvertFromInvariantString(valStr);
      }
      prop.SetValue(this, value);
      return true;
    }
    return false;
  }

  public static string[] GetPropNames()
  {
    if (_PropNames == null)
      _PropNames = typeof(ExtendedProperties).GetProperties().Where(item => item.Name != "Count" || item.Name != "IsReadOnly").Select(item => item.Name).ToArray();
    return _PropNames;
  }

  private static string[] _PropNames = null!;

  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    foreach (var name in GetPropNames())
    {
      var value = Get(name);
      if (value != null)
      {
        yield return new DocumentProperty { Name = name, Value = value };
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
      Add(documentProperty);
  }

  public void Add(DocumentProperty item)
  {
    if (item.Name != null)
      Set(item.Name, item);
  }

  public void Clear()
  {
    foreach (var name in GetPropNames())
    { Set(name, null); }
  }

  public bool Contains(DocumentProperty item)
  {
    if (item.Name != null && GetPropNames().Contains(item.Name))
      return Get(item.Name) != null;
    return false;
  }

  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    var items = new List<DocumentProperty>();
    foreach (var item in this)
    {
      items.Add(item);
    }
    items.CopyTo(array, arrayIndex);
  }

  public bool Remove(DocumentProperty item)
  {
    if (item.Name != null && GetPropNames().Contains(item.Name))
    {
      Set(item.Name, null);
      return true;
    }
    return false;
  }

  int ICollection<DocumentProperty>.Count => Count();

  bool ICollection<DocumentProperty>.IsReadOnly => false;
}