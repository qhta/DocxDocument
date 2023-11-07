using DocumentFormat.OpenXml.Office.CustomUI;

namespace DocumentModel;

public partial class CustomProperties : IDictionary<string, object?>
{
  public void Add(string key, object? value)
  {
    int id = 1;
    if (Count > 0)
      id = this.AsQueryable<CustomProperty>().Where(item => item.Id != null).Select(item => (int)item.Id!).Max();
    Add(new CustomProperty { Id = id + 1, Name = key, Value = value, FormatId = new Guid("{D5CDD505-2E9C-101B-9397-08002B2CF9AE}") });
  }

  public bool ContainsKey(string key)
  {
    return this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == key) != null;
  }

  public bool Remove(string key)
  {
    var item = this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == key);
    if (item != null)
    {
      this.Remove(item);
      return true;
    }
    return false;
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out object? value)
  {
    var item = this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == key);
    if (item != null)
    {
      value = item.Value;
      return true;
    }
    value = null;
    return false;
  }

  public object? this[string key]
  {
    get
    {
      var item = this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == key);
      if (item != null)
      {
        return item.Value;
      }
      return null;
    }
    set
    {
      var item = this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == key);
      if (item != null)
      {
        item.Value = value;
      }
      else
        Add(key, value);
    }
  }

  public ICollection<string> Keys
  {
    get => this.AsQueryable<CustomProperty>().Select(item => item.Name ?? string.Empty).ToList();
  }
  public ICollection<object?> Values
  {
    get => this.AsQueryable<CustomProperty>().Select(item => item.Value).ToList();
  }

  public void Add(KeyValuePair<string, object?> pair)
  {
    Add(pair.Key, pair.Value);
  }

  public bool Contains(KeyValuePair<string, object?> pair)
  {
    var item = this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == pair.Key);
    if (item != null)
    {
      return item.Value == pair.Value;
    }
    return false;
  }

  public void CopyTo(KeyValuePair<string, object?>[] array, int arrayIndex)
  {
    this.AsQueryable<CustomProperty>()
      .Select(item => new KeyValuePair<string, object?>(item.Name ?? string.Empty, item.Value)).ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(KeyValuePair<string, object?> pair)
  {
    var item = this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == pair.Key);
    if (item != null)
    {
      if (item.Value == pair.Value)
        Remove(item);
    }
    return false;
  }

  IEnumerator<KeyValuePair<string, object?>> IEnumerable<KeyValuePair<string, object?>>.GetEnumerator()
  {
    foreach (var item in this.AsQueryable<CustomProperty>())
      yield return new KeyValuePair<string, object?>(item.Name ?? string.Empty, item.Value);
  }
}
