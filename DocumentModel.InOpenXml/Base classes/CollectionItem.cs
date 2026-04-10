namespace DocumentModel;
/// <summary>
/// Abstract model element that is part of a collection.
/// </summary>
[XmlRoot("CollectionItem", Namespace = "DocumentModel")]
public abstract class CollectionItem : ModelElement, ICollectionItem
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
 /// <param name = "collection"></param>
 protected CollectionItem(IElementCollection<CollectionItem> collection)
 {
  SetCollection(collection);
 }
///// <summary>
///// Collection that contains this item.
///// </summary>
//[XmlIgnore]
//[JsonIgnore]
//[NotMapped]
//public object? Collection { get; set; }
///// <summary>
///// Collection property is defined  but not stored in OpenXml element
///// </summary>
///// <param name="value">Value to set locally</param>
//public void SetCollection(IElementCollection<CollectionItem>? value)
//{
//  Collection = value;
//}
}