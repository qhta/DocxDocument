namespace DocumentModel;
/// <summary>
/// Model element that is part of a collection.
/// </summary>
public class CollectionItem: ModelElement, ICollectionItem
{
  /// <summary>
  /// Collection that contains this item.
  /// </summary>
  public ElementCollection<CollectionItem>? Collection { get; set; }
}