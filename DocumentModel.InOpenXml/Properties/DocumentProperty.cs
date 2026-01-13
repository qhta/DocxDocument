namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
public abstract class DocumentProperty: CollectionItem, ICollectionItem
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected DocumentProperty()
  {
  }

  protected DocumentProperty(IElementCollection<CollectionItem> propertiesCollection) : base(propertiesCollection)
  {
  }

  /// <summary>
  ///   Property Category.
  /// </summary>
  public virtual string? Category { get; set; }
  /// <summary>
  ///   Property Name.
  /// </summary>
  public virtual string? Name { get; set; }
  /// <summary>
  ///   Value of the property
  /// </summary>
  public virtual object? Value { get; set; }
  /// <summary>
  ///   Expected value type
  /// </summary>
  public virtual Type? Type { get; set; }
}