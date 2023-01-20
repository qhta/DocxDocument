using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace DocumentModel;

public class NamedObjectList<T> : ICollection<T>, IEnumerable<T>, IDictionary<string, T>, INotifyCollectionChanged where T : class, INamedObject
{
  private readonly SortedDictionary<string, T> _dictionary = null!;

  public NamedObjectList() : this(StringComparer.InvariantCultureIgnoreCase) { }

  public NamedObjectList(IComparer<string> comparer)
  {
    _dictionary = new SortedDictionary<string, T>(comparer);
  }

  public void Add(T item)
  {
    var name = item.Name;
    if (!TryAdd(name, item))
      throw new InvalidOperationException($"{item.GetType()} \"{name}\" already exists");
    var aliasedObject = item as IAliasedObject;
    if (aliasedObject?.Aliases != null)
    {
      foreach (var alias in aliasedObject.Aliases)
      {
        if (!TryAdd(alias, item))
          throw new InvalidOperationException($"{item.GetType()} \"{alias}\" already exists");
      }
    }
  }

  public bool AddOrReplace(T item)
  {
    bool ok = AddOrReplace(item.Name, item);
    var aliasedObject = item as IAliasedObject;
    if (aliasedObject?.Aliases != null)
    {
      foreach (var alias in aliasedObject.Aliases)
        if (!AddOrReplace(alias, item))
          ok = false;
    }
    return ok;
  }

  public bool AddOrReplace(string name, T item)
  {
    if (!TryAdd(name, item))
    {
      _dictionary[name] = item;
      return false;
    }
    return true;
  }

  public bool TryAdd(string name, T item)
  {
    if (_dictionary.ContainsKey(name))
      return false;
    _dictionary.Add(name, item);
    return true;
  }

  public void Clear()
  {
    _dictionary.Clear();
  }

  public bool Contains(T item)
  {
    var name = item.Name;
    return _dictionary.ContainsKey(name);
  }

  public void CopyTo(T[] array, int arrayIndex)
  {
    _dictionary.Values.Distinct().ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(T item)
  {
    var name = item.Name;
    var ok = _dictionary.Remove(name);
    var aliasedObject = item as IAliasedObject;
    if (aliasedObject?.Aliases != null)
      foreach (var alias in aliasedObject.Aliases)
      {
        _dictionary.Remove(alias);
      }
    return ok;
  }

  public int Count => _dictionary.Values.Distinct().Count();

  public bool IsReadOnly => false;

  public IEnumerator<T> GetEnumerator()
  {
    return ((IEnumerable<T>)_dictionary.Values.Distinct()).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)_dictionary.Values.Distinct()).GetEnumerator();
  }

  public bool TryGetValue(string name, [NotNullWhen(true)] out T value)
  {
#pragma warning disable CS8601
    return _dictionary.TryGetValue(name, out value);
#pragma warning restore CS8601
  }

  public bool ContainsKey(string name)
  {
    return _dictionary.ContainsKey(name);
  }

  public bool Remove(string name)
  {
    return _dictionary.Remove(name);
  }

  public T this[string key]
  {
    get => _dictionary[key];
    set => _dictionary[key] = value;
  }

  public event NotifyCollectionChangedEventHandler? CollectionChanged;

  public void NotifyCollectionChanged(NotifyCollectionChangedEventArgs args) => CollectionChanged?.Invoke(this, args);

  public void Add(string key, T value)
  {
    ((IDictionary<string, T>)_dictionary).Add(key, value);
  }

  public ICollection<string> Keys => ((IDictionary<string, T>)_dictionary).Keys;

  public ICollection<T> Values => ((IDictionary<string, T>)_dictionary).Values;

  public void Add(KeyValuePair<string, T> item)
  {
    ((ICollection<KeyValuePair<string, T>>)_dictionary).Add(item);
  }

  public bool Contains(KeyValuePair<string, T> item)
  {
    return ((ICollection<KeyValuePair<string, T>>)_dictionary).Contains(item);
  }

  public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
  {
    ((ICollection<KeyValuePair<string, T>>)_dictionary).CopyTo(array, arrayIndex);
  }

  public bool Remove(KeyValuePair<string, T> item)
  {
    return ((ICollection<KeyValuePair<string, T>>)_dictionary).Remove(item);
  }

  IEnumerator<KeyValuePair<string, T>> IEnumerable<KeyValuePair<string, T>>.GetEnumerator()
  {
    return ((IEnumerable<KeyValuePair<string, T>>)_dictionary).GetEnumerator();
  }
}