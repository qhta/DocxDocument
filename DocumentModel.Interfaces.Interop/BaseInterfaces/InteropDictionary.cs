namespace DocumentModel.Interop;

/// <summary>
/// Defines a generic dictionary interface that maps keys of a specified type to values, supporting both standard and
/// default item access patterns for interoperability scenarios.
/// </summary>
/// <remarks>This interface extends the standard IDictionary interface to provide additional support for default
/// item access, which may be required for interoperability with certain COM or dynamic environments. Implementations
/// should ensure consistent behavior between standard and default item accessors.</remarks>
/// <typeparam name="IndexType">The type of the keys or indices used to access items in the dictionary.</typeparam>
/// <typeparam name="ItemType">The type of the items stored in the dictionary.</typeparam>
public interface InteropDictionary<IndexType, ItemType>: IDictionary<IndexType, ItemType>
{
  /// <summary>
  /// Gets the item associated with the specified index.
  /// </summary>
  /// <param name="Index">The key or index of the item to get.</param>
  /// <returns>The item associated with the specified index.</returns>
  public ItemType get_Item(IndexType Index);

  /// <summary>
  /// Gets the default item associated with the specified index.
  /// </summary>
  /// <param name="Index">The key or index of the item to get.</param>
  /// <returns>The default item associated with the specified index.</returns>
  public ItemType _Default(IndexType Index);
}
