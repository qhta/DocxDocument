namespace DocumentModel;
/// <summary>
/// Abstract model element that is part of a collection.
/// </summary>
public abstract class CollectionItem: ModelElement, ICollectionItem
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected CollectionItem()
  {
  }

  /// <summary>
  /// Protected constructor to initialize the collection item with its containing collection.
  /// </summary>
  /// <param name="collection"></param>
  protected CollectionItem(IElementCollection<CollectionItem> collection)
  {
    Collection = collection;
  }

  /// <summary>
  /// Collection that contains this item.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public IElementCollection<CollectionItem>? Collection { get; set; }


}