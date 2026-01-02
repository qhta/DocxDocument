namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public class DocumentProperties : ICollection<DocumentProperty>
{
  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    foreach (var prop in GetKnownProperties(this).Values)
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
    foreach (var prop in GetKnownProperties(this).Values) Set(prop.Name, null);
  }

  public bool Contains(DocumentProperty item)
  {
    if (item.Name != null && GetKnownProperties(this).ContainsKey(item.Name))
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
    if (item.Name != null && GetKnownProperties(this).ContainsKey(item.Name))
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
    foreach (var name in GetKnownProperties(this).Keys)
    {
      var item = GetValue(name);
      if (item != null)
        knownPropertiesCount++;
    }
    return knownPropertiesCount;
  }

  public object? GetValue(string propName)
  {
    var prop = GetKnownProperties(this)[propName];
    return prop?.GetValue(this, null);
  }

  public DocumentProperty? GetProperty(string propName)
  {
    var prop = GetKnownProperties(this)[propName];
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

  static readonly Dictionary<Type, Dictionary<string, DocumentProperty>> _knownTypeProperties = new();
  public static Dictionary<string, PropertyModel> GetKnownProperties(object obj)
  {
    return GetKnownProperties(obj.GetType());
  }

  public static Dictionary<string, PropertyInfo> GetKnownProperties(Type ofType)
  {
    if (!_knownTypeProperties.TryGetValue(ofType, out var _properties))
    {
      _properties = ofType.GetProperties()
        .Where(item => item.Name != "Count" || item.Name != "IsReadOnly").ToDictionary(item => item.Name);
      _knownTypeProperties.Add(ofType, _properties);
    }
    return _properties;
  }

  public Dictionary<string, PropertyInfo> GetKnownProperties()
  {
    return GetKnownProperties(this.GetType());
  }

  public void Add(object item)
  {
    if (item is DocumentProperty documentProperty)
      Add(documentProperty);
  }
}