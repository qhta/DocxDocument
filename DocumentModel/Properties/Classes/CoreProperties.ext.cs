namespace DocumentModel.Properties;

public partial class CoreProperties : ICollection<DocumentProperty>
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
    if (_PropNames==null) 
      _PropNames = typeof(CoreProperties).GetProperties().Where(item => item.Name != "Count" || item.Name!="IsReadOnly").Select(item => item.Name).ToArray();
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
    foreach (var name in GetPropNames())
    {
      var item = Get(name);
      if (item!=null)
        array.SetValue(item, arrayIndex++);
    }
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