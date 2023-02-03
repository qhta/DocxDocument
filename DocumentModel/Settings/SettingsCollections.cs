namespace DocumentModel.Properties;

public class SettingsCollections : ICollection<Setting>
{
  private Dictionary<string, Setting> _settings = null!;

  public IEnumerator<Setting> GetEnumerator()
  {
    foreach (var prop in GetSettings().Values)
    {
      string name = prop.Name;
      var value = GetValue(name);
      if (value != null)
      {
        var typeName = prop.PropertyType.Name;
        if (typeName.StartsWith("Nullable`"))
          typeName = prop.PropertyType.GenericTypeArguments[0].Name;
        Variant variant = (value is Variant valVariant) ? valVariant : new Variant(value);
        yield return new Setting { Name = name, Type = variant.VariantType, Value = variant };
      }
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(Setting item)
  {
    if (item.Name != null)
      Set(item.Name, item);
  }

  public void Clear()
  {
    foreach (var prop in GetSettings().Values) Set(prop.Name, null);
  }

  public bool Contains(Setting item)
  {
    if (item.Name != null && GetSettings().ContainsKey(item.Name))
      return GetValue(item.Name) != null;
    return false;
  }

  public void CopyTo(Setting[] array, int arrayIndex)
  {
    var items = new List<Setting>();
    foreach (var item in this) items.Add(item);
    items.CopyTo(array, arrayIndex);
  }

  public bool Remove(Setting item)
  {
    if (item.Name != null && GetSettings().ContainsKey(item.Name))
    {
      Set(item.Name, null);
      return true;
    }
    return false;
  }

  int ICollection<Setting>.Count => Count();

  bool ICollection<Setting>.IsReadOnly => false;

  public int Count()
  {
    var corePropertiesCount = 0;
    foreach (var name in GetSettings().Keys)
    {
      var item = GetValue(name);
      if (item != null)
        corePropertiesCount++;
    }
    return corePropertiesCount;
  }

  public object? GetValue(string propName)
  {
    var prop = GetSettings()[propName];
    return prop?.GetValue(this, null);
  }

  public Setting? GetProperty(string propName)
  {
    var prop = GetSettings()[propName];
    var value = prop?.GetValue(this, null);
    Variant? variant = (value is Variant valVariant) ? valVariant : (value != null) ? new Variant(value) : null;
    return new Setting(propName, prop?.PropertyType, variant);
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
        else if (value is Variant variant)
          value = variant.ToType(prop.PropertyType, null);
      }
      prop.SetValue(this, value);
      return true;
    }
    return false;
  }

  public Dictionary<string, PropertyInfo> GetSettings()
  {
    if (_properties == null)
      _properties = this.GetType().GetProperties()
        .Where(item => item.Name != "Count" || item.Name != "IsReadOnly").ToDictionary(item => item.Name);
    return _properties;
  }

  public void Add(object item)
  {
    if (item is Setting Setting)
      Add(Setting);
  }
}