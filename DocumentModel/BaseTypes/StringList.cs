namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// Represents the list of string
/// </summary>
[TypeConverter(typeof(StringListTypeConverter))]
public class StringList : ICollection, ICollection<string>, IEnumerable, IEquatable<StringList>
{
  private readonly List<string> _list = new();

  /// <summary>
  /// Default constructor
  /// </summary>
  public StringList() { }

  public StringList(string? str)
  {
    if (str != null)
    {
      var ss = str.Split(',');
      foreach (var s in ss)
      { _list.Add(s); }
    }
  }

  /// <inheritdoc />
  public IEnumerator<string> GetEnumerator()
  {
    return _list.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(string item)
  {
    _list?.Add(item);
  }

  public void Clear()
  {
    _list?.Clear();
  }

  public bool Contains(string item)
  {
    return _list?.Contains(item) ?? false;
  }

  public void CopyTo(string[] array, int arrayIndex)
  {
    _list?.CopyTo(array, arrayIndex);
  }

  public bool Remove(string item)
  {
    return _list?.Remove(item) ?? false;
  }

  public int Count => _list?.Count ?? 0;

  public bool IsReadOnly => false;

  public override string ToString()
  {
    return String.Join(", ", _list.ToArray());
  }

  public static implicit operator StringList?(string? str) => (str!=null) ? new StringList(str) : null;

  public static implicit operator string? (StringList? value) => value?.ToString();

  public override bool Equals(object? obj)
  {
    if (obj == null) return false;
    if (obj is StringList other)
      return Equals(other);
    if (obj is string str)
      return Count == 1 && _list[0].Equals(str);
    return false;
  }

  public bool Equals(StringList? other)
  {
    if (other == null) return false;
    if (this.Count != other.Count) return false;
    for (int i = 0; i < this.Count; i++)
      if (!this._list[i].Equals(other._list[i])) return false;
    return true;
  }

  public override int GetHashCode()
  {
    var result = 0;
    foreach (var item in _list)
      result = HashCode.Combine(result, item.GetHashCode());
    return result;
  }

  void ICollection.CopyTo(Array array, int index)
  {
    if (array is string[] ss)
      _list.CopyTo(ss, index);
  }

  bool ICollection.IsSynchronized { get; }
  object ICollection.SyncRoot { get; } = new object();
}