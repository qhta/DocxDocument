using System.Collections.ObjectModel;

namespace DocumentModel;

public class NamedObjectList<T>: ICollection<T> where T: class, INamedObject
{
  private readonly List<T> _list = new List<T>();
  private readonly Dictionary<string, T> _dictionary = new Dictionary<string, T>();

  public void Add(T item)
  {
    var name = item.Name;
    if (_dictionary.ContainsKey(name))
      throw new InvalidOperationException($"Key {name} already exists");
    _dictionary.Add(name, item);
    var aliasedObject = item as IAliasedObject;
    if (aliasedObject?.Aliases != null )
      foreach (var alias in aliasedObject.Aliases)
      {
        if (_dictionary.ContainsKey(alias))
          throw new InvalidOperationException($"Key {alias} already exists");
        _dictionary.Add(alias, item);
      }
    _list.Add(item);
  }

  public void Clear()
  {
    _list.Clear();
    _dictionary.Clear();
  }

  public bool Contains(T item)
  {
    var name = item.Name;
    return _dictionary.ContainsKey(name);
  }

  public void CopyTo(T[] array, int arrayIndex)
  {
    _list.CopyTo(array, arrayIndex);
  }

  public bool Remove(T item)
  {
    var name = item.Name;
    if (_dictionary.ContainsKey(name))
      _dictionary.Remove(name);
    var aliasedObject = item as IAliasedObject;
    if (aliasedObject?.Aliases != null)
      foreach (var alias in aliasedObject.Aliases)
      {
        if (_dictionary.ContainsKey(alias))
          _dictionary.Remove(alias);
      }
    return _list.Remove(item);
  }

  public int Count => _list.Count;

  public bool IsReadOnly => false;

  public IEnumerator<T> GetEnumerator()
  {
    return ((IEnumerable<T>)_list).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)_list).GetEnumerator();
  }

  public bool TryGetValue(string name, out T? value)
  {
    return _dictionary.TryGetValue(name, out value);
  }
}