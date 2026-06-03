using System.Collections;

namespace DocumentModel.Interop;

/// <summary>
/// Defines a generic dictionary class that maps keys of a specified type to values, supporting both standard and
/// default item access patterns for interoperability scenarios.
/// </summary>
/// <remarks>This class extends the standard IDictionary class to provide additional support for default
/// item access, which may be required for interoperability with certain COM or dynamic environments. Implementations
/// should ensure consistent behavior between standard and default item accessors.</remarks>
/// <typeparam name="KeyType">The type of the keys or indices used to access items in the dictionary.</typeparam>
/// <typeparam name="ItemType">The type of the items stored in the dictionary.</typeparam>
public class InteropDictionary<KeyType, ItemType>: IDictionary<KeyType, ItemType>
  where KeyType : notnull

{
  /// <summary>
  /// The underlying dictionary that stores the key-value pairs.
  /// </summary>
  protected Dictionary<KeyType, ItemType> _dictionary = new();

  /// <summary>
  /// Gets the item associated with the specified index.
  /// </summary>
  /// <param name="index">The key or index of the item to get.</param>
  /// <returns>The item associated with the specified index.</returns>
  public ItemType Item(int index) => _dictionary.ElementAt(index).Value;

  /// <summary>
  /// Gets the item associated with the specified index.
  /// </summary>
  /// <param name="index">The key or index of the item to get.</param>
  /// <returns>The item associated with the specified index.</returns>
  public ItemType Item(KeyType index) => _dictionary[index];

  /// <summary>
  /// Gets the default item associated with the specified index.
  /// </summary>
  /// <param name="index">The key or index of the item to get.</param>
  /// <returns>The default item associated with the specified index.</returns>
  public ItemType? _Default(KeyType index) => default;

  /// <summary>
  /// Returns an enumerator that iterates through the dictionary.
  /// </summary>
  /// <returns>An enumerator for the dictionary.</returns>
  public IEnumerator<KeyValuePair<KeyType, ItemType>> GetEnumerator()
  {
    return _dictionary.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)_dictionary).GetEnumerator();
  }

  /// <summary>
  /// Adds a key-value pair to the dictionary.
  /// </summary>
  /// <param name="item">The key-value pair to add.</param>
  public void Add(KeyValuePair<KeyType, ItemType> item)
  {
    _dictionary.Add(item.Key, item.Value);
  }

  /// <summary>
  /// Removes all keys and values from the dictionary.
  /// </summary>
  public void Clear()
  {
    _dictionary.Clear();
  }

  /// <summary>
  /// Determines whether the dictionary contains a specific key-value pair.
  /// </summary>
  /// <param name="item">The key-value pair to locate in the dictionary.</param>
  /// <returns>true if the dictionary contains the specified key-value pair; otherwise, false.</returns>
  public bool Contains(KeyValuePair<KeyType, ItemType> item)
  {
    return _dictionary.Contains(item);
  }

  /// <summary>
  /// Copies the elements of the dictionary to an array, starting at a particular array index.
  /// </summary>
  /// <param name="array"></param>
  /// <param name="arrayIndex"></param>
  public void CopyTo(KeyValuePair<KeyType, ItemType>[] array, int arrayIndex)
  {
    _dictionary.ToArray().CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the first occurrence of a specific key-value pair from the dictionary.
  /// </summary>
  /// <param name="item"></param>
  /// <returns></returns>
  public bool Remove(KeyValuePair<KeyType, ItemType> item)
  {
    return _dictionary.Remove(item.Key);
  }

  /// <summary>
  /// Gets the number of key-value pairs contained in the dictionary.
  /// </summary>
  public int Count => _dictionary.Count;

  /// <summary>
  /// Gets a value indicating whether the dictionary is read-only. Always returns false, as this implementation allows modification of the dictionary.
  /// </summary>
  public bool IsReadOnly => false;

  /// <summary>
  /// Determines whether the dictionary contains a specific key.
  /// </summary>
  /// <param name="key">The key to locate in the dictionary.</param>
  /// <returns>true if the dictionary contains the specified key; otherwise, false.</returns>
  public bool ContainsKey(KeyType key)
  {
    return _dictionary.ContainsKey(key);
  }

  /// <summary>
  /// Adds a key-value pair to the dictionary. If the key already exists, an exception is thrown.
  /// </summary>
  /// <param name="key">The key of the element to add.</param>
  /// <param name="value">The value of the element to add.</param>
  public void Add(KeyType key, ItemType value)
  {
    _dictionary.Add(key, value);
  }

  /// <summary>
  /// Removes the element with the specified key from the dictionary.
  /// </summary>
  /// <param name="key">The key of the element to remove.</param>
  /// <returns>true if the element is successfully removed; otherwise, false.</returns>
  public bool Remove(KeyType key)
  {
    return _dictionary.Remove(key);
  }

  /// <summary>
  /// Tries to get the value associated with the specified key. Returns true if the key exists in the dictionary; otherwise, false. The value parameter is set to the value associated with the key if it exists, or the default value of ItemType if it does not exist.
  /// </summary>
  /// <param name="key">The key of the value to get.</param>
  /// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
  /// <returns>true if the dictionary contains an element with the specified key; otherwise, false.</returns>
  public bool TryGetValue(KeyType key, out ItemType value)
  {
    return _dictionary.TryGetValue(key, out value!);
  }

  /// <summary>
  /// Gets or sets the value associated with the specified key. If the key does not exist in the dictionary, a new key-value pair is added with the specified key and value. If the key already exists, the value is updated to the new value.
  /// </summary>
  /// <param name="key">The key of the value to get or set.</param>
  /// <returns>The value associated with the specified key.</returns>
  ItemType IDictionary<KeyType, ItemType>.this[KeyType key] { get => _dictionary[key]; set => _dictionary[key] = value; }

  /// <summary>
  /// Gets a collection containing the keys in the dictionary.
  /// </summary>
  public ICollection<KeyType> Keys => _dictionary.Keys;

  /// <summary>
  /// Gets a collection containing the values in the dictionary.
  /// </summary>
  public ICollection<ItemType> Values => _dictionary.Values;
}
