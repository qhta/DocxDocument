#nullable enable
namespace DocumentModel;

/// <summary>Represents the list of string
[TypeConverter(typeof(StringListTypeConverter))]
public class StringList : ICollection<string>, IEnumerable
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
}