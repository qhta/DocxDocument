namespace DocumentModel;

public partial class CustomProperties : IDictionary<string, object?>
{
  /// <summary>
  /// Adds any object value with a specified string key.
  /// </summary>
  /// <param name="key"></param>
  /// <param name="value"></param>
  public void Add(string key, object? value)
  {
    int id = 1;
    if (Count > 0)
      id = this.AsQueryable<CustomProperty>().Where(item => item.Id != null).Select(item => (int)item.Id!).Max();
    Add(new CustomProperty { Id = id + 1, Name = key, Value = value, FormatId = new Guid("{D5CDD505-2E9C-101B-9397-08002B2CF9AE}") });
  }

  /// <summary>
  /// Checks if a value for a specified string key exists.
  /// </summary>
  /// <param name="key"></param>
  /// <returns></returns>
  public bool ContainsKey(string key)
  {
    return this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == key) != null;
  }

  /// <summary>
  /// Removes a value for a specified string key.
  /// </summary>
  /// <param name="key"></param>
  /// <returns></returns>
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

  /// <summary>
  /// Tries to get an object value for a specified string key.
  /// </summary>
  /// <param name="key"></param>
  /// <param name="value"></param>
  /// <returns></returns>
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

  /// <summary>
  /// Gets/sets any object value for a specified string key.
  /// </summary>
  /// <param name="key"></param>
  /// <returns></returns>
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

  /// <summary>
  /// List of defined string keys.
  /// </summary>
  public ICollection<string> Keys
  {
    get => this.AsQueryable<CustomProperty>().Select(item => item.Name ?? string.Empty).ToList();
  }

  /// <summary>
  /// List of defined object values.
  /// </summary>
  public ICollection<object?> Values
  {
    get => this.AsQueryable<CustomProperty>().Select(item => item.Value).ToList();
  }

  /// <summary>
  /// Adds a name-value pair.
  /// </summary>
  /// <param name="pair"></param>
  public void Add(KeyValuePair<string, object?> pair)
  {
    Add(pair.Key, pair.Value);
  }

  /// <summary>
  /// Checks if a name-value pair is defined.
  /// </summary>
  /// <param name="pair"></param>
  /// <returns></returns>
  public bool Contains(KeyValuePair<string, object?> pair)
  {
    var item = this.AsQueryable<CustomProperty>().FirstOrDefault(item => item.Name == pair.Key);
    if (item != null)
    {
      return item.Value == pair.Value;
    }
    return false;
  }

  /// <summary>
  /// Copies defined name-value pairs to the specified array at specified array index.
  /// </summary>
  /// <param name="array"></param>
  /// <param name="arrayIndex"></param>
  public void CopyTo(KeyValuePair<string, object?>[] array, int arrayIndex)
  {
    this.AsQueryable<CustomProperty>()
      .Select(item => new KeyValuePair<string, object?>(item.Name ?? string.Empty, item.Value)).ToArray().CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes a specified name-value pair.
  /// </summary>
  /// <param name="pair"></param>
  /// <returns></returns>
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

  /// <summary>
  /// Enumerator for name-value pairs. Needs interface cast.
  /// </summary>
  /// <returns></returns>
  IEnumerator<KeyValuePair<string, object?>> IEnumerable<KeyValuePair<string, object?>>.GetEnumerator()
  {
    foreach (var item in this.AsQueryable<CustomProperty>())
      yield return new KeyValuePair<string, object?>(item.Name ?? string.Empty, item.Value);
  }
}
