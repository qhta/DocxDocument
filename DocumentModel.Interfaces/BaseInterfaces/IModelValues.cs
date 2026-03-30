namespace DocumentModel;

/// <summary>
/// Collection of simple values.
/// </summary>
/// <typeparam name="ItemType">Should be a value type or string</typeparam>
public interface IModelValues<ItemType>: IEnumerable<ItemType>
{
  /// <summary>
  /// Gets the item at the specified integer index.
  /// </summary>
  /// <param name="Index">The zero-based index of the item to get.</param>
  /// <returns>The item at the specified index.</returns>
  public ItemType this[object Index] { get; set; }
}