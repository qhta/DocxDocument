namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specific collection of Run items in a Wordprocessing document, extending the generic ContentItemsCollection to handle ModelElement types. This collection is designed to accept any item and provides a mapping between OpenXml element types and model element types for proper data loading and synchronization within the document model.
/// </summary>
public class RunItemsCollection: ContentItemsCollection
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="parent">Model element that owns this collection. Cannot be null.</param>
  /// <param name="openXmlRun">The OpenXml Run element to be wrapped by the collection. Can be null.</param>
  public RunItemsCollection(DMW.Run parent, DXW.Run? openXmlRun) : base(parent, openXmlRun)
  {
  }

  /// <summary>
  /// Checks if the specified item is acceptable for this collection.
  /// </summary>
  /// <param name="item">The item to check.</param>
  /// <returns>True if the item is acceptable; otherwise, false.</returns>
  public override bool AcceptSourceItem(DX.OpenXmlElement item)
  {
    return item is not DXW.RunProperties;
  }
}
