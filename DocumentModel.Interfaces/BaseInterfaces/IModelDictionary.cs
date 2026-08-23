using System.Diagnostics.CodeAnalysis;

namespace DocumentModel;

/// <summary>
/// Defines a generic dictionary interface that maps keys of a specified type to values, supporting both standard and
/// default item access patterns for interoperability scenarios.
/// </summary>
/// <remarks>This interface extends the standard IDictionary interface to provide additional support for default
/// item access, which may be required for interoperability with certain COM or dynamic environments. Implementations
/// should ensure consistent behavior between standard and default item accessors.</remarks>
/// <typeparam name="TKey">The type of the keys or indices used to access items in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of the items stored in the dictionary.</typeparam>
// ReSharper disable once PossibleInterfaceMemberAmbiguity
public interface IModelDictionary<TKey, TValue> : IEnumerable<TValue>
  where TValue : IModelObject
{
  /// <summary>
  /// Adds the specified key and value to the dictionary.
  /// </summary>
  /// <param name="key">The key of the element to add to the dictionary.</param>
  /// <param name="value">The value of the element to add to the dictionary.</param>
  void Add(TKey key, TValue value);

  /// <summary>
  /// Removes the element with the specified key from the collection.
  /// </summary>
  /// <param name="key">The key of the element to remove.</param>
  /// <returns>true if the element is successfully removed; otherwise, false. This method also returns false if the key was not
  /// found in the collection.</returns>
  bool Remove(TKey key);

  /// <summary>
  /// Attempts to retrieve the value associated with the specified key.
  /// </summary>
  /// <param name="key">The key whose value to retrieve.</param>
  /// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise,
  /// the default value for the type of the value parameter. This parameter is passed uninitialized.</param>
  /// <returns>true if the object that implements the interface contains an element with the specified key; otherwise, false.</returns>
  bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);

  /// <summary>
  /// Gets the item associated with the specified index.
  /// </summary>
  /// <param name="Index">The key or index of the item to get.</param>
  /// <returns>The item associated with the specified index.</returns>
  public TValue Item(int Index);

  /// <summary>
  /// Gets the item associated with the specified index.
  /// </summary>
  /// <param name="Index">The key or index of the item to get.</param>
  /// <returns>The item associated with the specified index.</returns>
  public TValue Item(TKey Index);

}
