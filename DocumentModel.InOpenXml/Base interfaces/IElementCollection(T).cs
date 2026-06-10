namespace DocumentModel;
/// <summary>
/// Represents a collection of elements that are associated with a parent model element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
public interface IElementCollection<ItemType> : 
  ICollection<ItemType>,
  INotifyPropertyChanged,
  INotifyCollectionChanged
{
  /// <summary>
  /// Attempts to add an item to the collection. Returns true if the item was added successfully, or false if the item could not be added (e.g., due to validation rules or constraints).
  /// </summary>
  /// <param name="item">The item to add to the collection.</param>
  /// <returns>True if the item was added successfully; otherwise, false.</returns>
  public bool TryAdd(ItemType item);
}
