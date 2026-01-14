namespace DocumentModel;
/// <summary>
/// Abstract model element that is part of a collection.
/// </summary>
public abstract class CollectionItem: ModelElement, ICollectionItem//, IEquatable<CollectionItem>
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

//  /// <summary>
//  /// Determines whether the current CollectionItem is equal to another CollectionItem instance.
//  /// </summary>
//  /// <param name="other">The CollectionItem to compare with the current instance. Can be null.</param>
//  /// <returns>true if the specified CollectionItem is equal to the current instance; otherwise, false.</returns>
//  public bool Equals(CollectionItem? other)
//  {
//    if (other is null) return false;
//    if (ReferenceEquals(this, other)) return true;
//    return false;
//    //return DeepComparer.DeepEqual(this, other);
//  }

//  /// <summary>
//  /// Determines whether the specified object is equal to the current CollectionItem instance.
//  /// </summary>
//  /// <remarks>Equality is determined by comparing the runtime type and the values of the CollectionItem. This
//  /// method overrides Object.Equals(Object).</remarks>
//  /// <param name="obj">The object to compare with the current CollectionItem instance.</param>
//  /// <returns>true if the specified object is a CollectionItem and is equal to the current instance; otherwise, false.</returns>
//#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
//  public override bool Equals(object? obj)
//  {
//    if (obj is null) return false;
//    if (ReferenceEquals(this, obj)) return true;
//    if (obj.GetType() != GetType()) return false;
//    return Equals((CollectionItem)obj);
//  }

}