namespace DocumentModel;

/// <summary>
///   Abstract document Property.
/// </summary>
public abstract class DocumentProperty : CollectionItem
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected DocumentProperty()
  {
  }

  /// <summary>
  /// Constructor that initializes the parent collection.
  /// </summary>
  /// <param name="propertiesCollection">Collection that contains this document property.</param>
  protected DocumentProperty(IElementCollection<CollectionItem> propertiesCollection) : base(propertiesCollection)
  {
  }

  /// <summary>
  ///   Property Category.
  /// </summary>
  [XmlAttribute]
  public virtual string? Category { get; set; }

  /// <summary>
  ///   Property Name.
  /// </summary>
  [XmlAttribute]
  public virtual string? Name { get; set; }

  /// <summary>
  ///   Value of the property
  /// </summary>
  public virtual Variant? Value { get; set; }

  /// <summary>
  ///   Expected value type
  /// </summary>
  public virtual string? Type { get; set; }

}