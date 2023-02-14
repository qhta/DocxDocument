namespace DocumentModel;

public class KnownDocumentProperties : ICollection<DocumentProperty>
{

  private Dictionary<string, PropertyInfo> _properties = null!;

  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    foreach (var prop in GetKnownProperties().Values)
    {
      string name = prop.Name;
      var value = GetValue(name);
      if (value != null)
      {
        var type = prop.PropertyType;
        if (type.Name.StartsWith("Nullable`"))
          type = prop.PropertyType.GenericTypeArguments[0];
        yield return new DocumentProperty { Name = name, Type = type, Value = value };
      }
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(DocumentProperty item)
  {
    if (item.Name != null)
      Set(item.Name, item);
  }

  public void Clear()
  {
    foreach (var prop in GetKnownProperties().Values) Set(prop.Name, null);
  }

  public bool Contains(DocumentProperty item)
  {
    if (item.Name != null && GetKnownProperties().ContainsKey(item.Name))
      return GetValue(item.Name) != null;
    return false;
  }

  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    var items = new List<DocumentProperty>();
    foreach (var item in this) items.Add(item);
    items.CopyTo(array, arrayIndex);
  }

  public bool Remove(DocumentProperty item)
  {
    if (item.Name != null && GetKnownProperties().ContainsKey(item.Name))
    {
      Set(item.Name, null);
      return true;
    }
    return false;
  }

  int ICollection<DocumentProperty>.Count => Count();

  bool ICollection<DocumentProperty>.IsReadOnly => false;

  public int Count()
  {
    var knownPropertiesCount = 0;
    foreach (var name in GetKnownProperties().Keys)
    {
      var item = GetValue(name);
      if (item != null)
        knownPropertiesCount++;
    }
    return knownPropertiesCount;
  }

  public object? GetValue(string propName)
  {
    var prop = GetKnownProperties()[propName];
    return prop?.GetValue(this, null);
  }

  public DocumentProperty? GetProperty(string propName)
  {
    var prop = GetKnownProperties()[propName];
    var value = prop?.GetValue(this, null);
    return new DocumentProperty(propName, prop?.PropertyType, value);
  }

  public bool Set(string propName, object? value)
  {
    var prop = this.GetType().GetProperty(propName);
    if (prop != null)
    {
      if (value != null && value.GetType() != prop.PropertyType)
      {
        if (value is String valStr)
        {
          var typeConverter = new ValueTypeConverter(prop.PropertyType);
          value = typeConverter.ConvertFromInvariantString(valStr);
        }
      }
      prop.SetValue(this, value);
      return true;
    }
    return false;
  }

  public Dictionary<string, PropertyInfo> GetKnownProperties()
  {
    if (_properties == null)
      _properties = this.GetType().GetProperties()
        .Where(item => item.Name != "Count" || item.Name != "IsReadOnly").ToDictionary(item => item.Name);
    return _properties;
  }

  public void Add(object item)
  {
    if (item is DocumentProperty documentProperty)
      Add(documentProperty);
  }
}