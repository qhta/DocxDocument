using System.Collections;
using System.Collections.ObjectModel;

namespace DocumentModel.Interop;

/// <summary>
/// Represents a collection of items that supports indexed and keyed access, designed for interoperability scenarios.
/// </summary>
/// <remarks>This class extends ICollection&lt;T&gt; and provides additional methods for accessing items by integer
/// or object index, which is commonly required when interoperating with COM or dynamic collections. Implementations may
/// support both zero-based integer indexing and object-based keys, depending on the underlying collection. The
/// class is intended for use in scenarios where compatibility with external or legacy APIs is necessary.
/// </remarks>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
public class InteropCollection<ItemType>: IEnumerable<ItemType>
{
  /// <summary>
  /// The underlying list of items in the collection.
  /// </summary>
  protected readonly ObservableCollection<ItemType> _items = new();

  /// <summary>
  /// Gets the number of items in the collection.
  /// </summary>
  public int Count => _items.Count;

  /// <summary>
  /// Gets the item at the specified integer index.
  /// </summary>
  /// <param name="index">The zero-based index of the item to get.</param>
  /// <returns>The item at the specified index.</returns>
  public ItemType this[object index]
  {
    get
    {
      if (index is int intIndex)
        return _items[intIndex];
      if (index is string strIndex)
        return _items.FirstOrDefault(item => item is INamedItem namedItem && namedItem.Name == strIndex)!;

      return default!;
    }
    set
    {
      if (index is int intIndex)
        _items[intIndex] = value;
      if (index is string strIndex)
      {
        var item = _items.FirstOrDefault(i => i is INamedItem namedItem && namedItem.Name == strIndex);
        if (item != null)
        {
          var indexToUpdate = _items.IndexOf(item);
          _items[indexToUpdate] = value;
        }
      }
    }
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  public IEnumerator<ItemType> GetEnumerator()
  {
    return _items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }
}
