using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Drawings;

public partial class ThemeColors : ICollection, ICollection<ThemeColor>, IDictionary<string, Color2Type>
{

  private Dictionary<string, Color2Type> _Items = new();

  public IEnumerator<ThemeColor> GetEnumerator()
  {
    foreach (var item in _Items)
      yield return new ThemeColor { Name = item.Key, Value = item.Value };
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(ThemeColor item)
  {
    if (item.Name != null && item.Value != null)
      Add(item.Name, item.Value);
  }

  public void Clear()
  {
    _Items.Clear();
  }

  public bool Contains(ThemeColor item)
  {
    if (item.Name != null)
      return _Items.ContainsKey(item.Name);
    return false;
  }

  public void CopyTo(ThemeColor[] array, int arrayIndex)
  {
    var items = new List<ThemeColor>();
    foreach (var item in this) items.Add(item);
    items.CopyTo(array, arrayIndex);
  }

  public bool Remove(ThemeColor item)
  {
    if (item.Name != null)
    {
      return _Items.Remove(item.Name);
    }
    return false;
  }

  int ICollection<ThemeColor>.Count => Count();

  bool ICollection<ThemeColor>.IsReadOnly => false;

  public int Count()
  {
    return _Items.Count;
  }

  //public object? GetValue(string propName)
  //{
  //  var prop = GetKnownProperties()[propName];
  //  return prop?.GetValue(this, null);
  //}

  //public bool Set(string propName, Color2Type? value)
  //{
  //  var prop = this.GetType().GetProperty(propName);
  //  if (prop != null)
  //  {
  //    prop.SetValue(this, value);
  //    return true;
  //  }
  //  return false;
  //}


  public void Add(object item)
  {
    if (item is ThemeColor ThemeColor)
      Add(ThemeColor);
  }

  void ICollection.CopyTo(Array array, int index)
  {
    throw new NotImplementedException();
  }

  int ICollection.Count { get; }
  bool ICollection.IsSynchronized { get; }
  object ICollection.SyncRoot { get; } = new object();

  public void Add(string key, Color2Type value)
  {
    throw new NotImplementedException();
  }

  public bool ContainsKey(string key)
  {
    throw new NotImplementedException();
  }

  public bool Remove(string key)
  {
    throw new NotImplementedException();
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out Color2Type value)
  {
    throw new NotImplementedException();
  }

  public Color2Type? this[string key]
  {
    get
    {
      if (_Items.TryGetValue(key, out var value))
        return value;
      return null;
    }
    set 
    {
      if (value != null)
      {
        if (_Items.ContainsKey(key))
          _Items[key] = value;
        else
          _Items.Add(key, value);
      }
      else
      {
        _Items.Remove(key);
      }
    }
  }

  public ICollection<string> Keys => _Items.Keys;
  public ICollection<Color2Type> Values => _Items.Values;

  public void Add(KeyValuePair<string, Color2Type> item)
  {
    throw new NotImplementedException();
  }

  public bool Contains(KeyValuePair<string, Color2Type> item)
  {
    throw new NotImplementedException();
  }

  public void CopyTo(KeyValuePair<string, Color2Type>[] array, int arrayIndex)
  {
    throw new NotImplementedException();
  }

  public bool Remove(KeyValuePair<string, Color2Type> item)
  {
    throw new NotImplementedException();
  }

  int ICollection<KeyValuePair<string, Color2Type>>.Count { get; }
  public bool IsReadOnly { get; }

  IEnumerator<KeyValuePair<string, Color2Type>> IEnumerable<KeyValuePair<string, Color2Type>>.GetEnumerator()
  {
    throw new NotImplementedException();
  }
}