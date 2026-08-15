namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specific collection of Story items in a Wordprocessing document, extending the generic ContentItemsCollection to handle ModelElement types. This collection is designed to accept any item and provides a mapping between OpenXml element types and model element types for proper data loading and synchronization within the document model.
/// </summary>
//[OpenXmlItem(typeof(DX.OpenXmlElement))]
public class StoryItemsCollection: ContentItemsCollection
{
  /// <summary>
  /// Default constructor needed for XML serialization. Initializes a new instance of the StoryItemsCollection class.
  /// </summary>
  public StoryItemsCollection() { }

  /// <summary>
  /// Initializes a new instance of the StoryItemsCollection class with the specified parent model element and Open XML
  /// composite element as the data source.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  /// <param name="dataSource">The OpenXmlCompositeElement that serves as the data source for the collection. Can be null.</param>
  public StoryItemsCollection(ModelElement parent, DX.OpenXmlCompositeElement? dataSource) : base(parent, dataSource)
  {
  }
}
