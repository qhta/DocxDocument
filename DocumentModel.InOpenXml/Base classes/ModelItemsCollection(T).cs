namespace DocumentModel;

/// <summary>
///   Represents a collection of model items, which are created from OpenXml elements,
///   which are the child elements of a parent OpenXml element.
/// </summary>
[DataContract]
[XmlRoot("ModelItemsCollection", Namespace = "DocumentModel")]

public abstract partial class ModelItemsCollection<ItemType> : ElementCollection<ItemType>
  where ItemType : notnull
{
  //private Dictionary<DX.OpenXmlElement, ItemType> _itemsDictionary = new();
  private readonly List<ItemType> _items = new List<ItemType>();
  private readonly BiDiDictionary<object, ItemType> _index = new BiDiDictionary<object, ItemType>();
  private readonly DX.OpenXmlCompositeElement _dataSource;

  /// <summary>
  /// Initializes a new instance of the ModelItemsCollection class using the specified OpenXmlCompositeElement as the
  /// data source.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the underlying data for the collection. Cannot be null.</param>
  protected ModelItemsCollection(DX.OpenXmlCompositeElement openXmlElement)
  {
    _dataSource = openXmlElement;
  }

}
