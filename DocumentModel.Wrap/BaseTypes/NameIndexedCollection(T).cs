using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

using Qhta.TestHelper;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public class NameIndexedCollection<T> : ICollection, ICollection<T>, IEnumerable<T>, INotifyCollectionChanged, IEquatable<NameIndexedCollection<T>> 
  where T : class, INamedObject, IEquatable<T>
{
  private readonly SortedDictionary<string, T> _dictionary = null!;

  public NameIndexedCollection()
  {
    _dictionary = new SortedDictionary<string, T>();
  }

  public NameIndexedCollection(IComparer<string> comparer)
  {
    _dictionary = new SortedDictionary<string, T>(comparer);
  }

  public NameIndexedCollection(Func<string, string> keyFunc)
  {
    _dictionary = new SortedDictionary<string, T>();
    _keyFunc = keyFunc;
  }

  public NameIndexedCollection(IComparer<string> comparer, Func<string, string> keyFunc)
  {
    _dictionary = new SortedDictionary<string, T>(comparer);
    _keyFunc = keyFunc;
  }
  private Func<string, string>? _keyFunc;

  static int n=0;
  public void Add(T item)
  {
    n++;
    var name = item.Name;
    if (name == null)
      throw new InvalidOperationException($"{item.GetType()} must have a name to be added to named collection");
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
    var name = item.Name;
    if (name == null)
      throw new InvalidOperationException($"{item.GetType()} must have a name to be added to named collection");
    bool ok = AddOrReplace(name, item);
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
      var oldItem = _dictionary[name];
      _dictionary[name] = item;
      NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, item, oldItem));
      return false;
    }
    return true;
  }

  public bool TryAdd(string name, T item)
  {
    if (_keyFunc != null)
      name = _keyFunc(name);
    if (_dictionary.ContainsKey(name))
      return false;
    _dictionary.Add(name, item);
    NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
    return true;
  }

  public void Clear()
  {
    _dictionary.Clear();
  }

  public bool Contains(T item)
  {
    var name = item.Name;
    if (name != null)
      return _dictionary.ContainsKey(name);
    return _dictionary.Values.Contains(item);
  }

  public void CopyTo(T[] array, int arrayIndex)
  {
    _dictionary.Values.Distinct().ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(T item)
  {
    var name = item.Name;
    if (name == null)
      throw new InvalidOperationException($"{item.GetType()} must have a name to be removed from named collection");
    var ok = _dictionary.Remove(name);
    if (ok)
      NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, null, item));
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

  public T? this[string key]
  {
    get => _dictionary[key];
    set
    {
      if (value != null)
        _dictionary[key] = value;
      else
        _dictionary.Remove(key);
    }
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

  public void CopyTo(Array array, int index)
  {
    throw new NotImplementedException();
  }

  [NonComparable]
  public bool IsSynchronized { get; set; }
  [NonComparable]
  public object SyncRoot { get; } = new object();

  //IEnumerator<KeyValuePair<string, T>> IEnumerable<KeyValuePair<string, T>>.GetEnumerator()
  //{
  //  return ((IEnumerable<KeyValuePair<string, T>>)_dictionary).GetEnumerator();
  //}

    public bool Equals(NameIndexedCollection<T>? other)
  {
    if (other == null)
      return false;
    return Enumerable.SequenceEqual<KeyValuePair<string, T>>(this._dictionary, other._dictionary);
  }

  public override int GetHashCode()
  {
    var result = _dictionary.Count();
    foreach (var item in _dictionary)
      result = HashCode.Combine(result, item.GetHashCode());
    return result;
  }
}