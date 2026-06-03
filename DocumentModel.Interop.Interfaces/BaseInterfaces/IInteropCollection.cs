namespace DocumentModel.Interop;

/// <summary>
/// Represents a collection of items that supports indexed and keyed access, designed for interoperability scenarios.
/// </summary>
/// <remarks>This interface extends ICollection&lt;T&gt; and provides additional methods for accessing items by integer
/// or object index, which is commonly required when interoperating with COM or dynamic collections. Implementations may
/// support both zero-based integer indexing and object-based keys, depending on the underlying collection. The
/// interface is intended for use in scenarios where compatibility with external or legacy APIs is necessary.
/// </remarks>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
public interface IInteropCollection<ItemType> : IEnumerable<ItemType>
{
  /// <summary>
  /// Gets the item at the specified integer index.
  /// </summary>
  /// <param name="Index">The zero-based index of the item to get.</param>
  /// <returns>The item at the specified index.</returns>
  public ItemType this[object Index] { get; set; }

}
