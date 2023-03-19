#nullable enable
namespace DocumentModel;

/// <summary>Represents the list of string
[TypeConverter(typeof(StringListTypeConverter))]
public class StringList : ICollection<string>, IEnumerable, IEquatable<StringList>
{
  private readonly List<string> _list = new();

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

}