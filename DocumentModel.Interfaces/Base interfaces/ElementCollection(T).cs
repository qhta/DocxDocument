namespace DocumentModel;

/// <summary>
/// Represents a collection of elements that are associated with a parent model element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
public interface ElementCollection<ItemType> : ICollection<ItemType>
  where ItemType: CollectionItem
{
  /// <summary>
  /// Gets the first item in the collection, or null if the collection is empty.
  /// </summary>
  public ItemType? First { get; }

  /// <summary>
  /// Gets the last item in the collection, or null if the collection is empty.
  /// </summary>

  public ItemType? Last { get; }
}
