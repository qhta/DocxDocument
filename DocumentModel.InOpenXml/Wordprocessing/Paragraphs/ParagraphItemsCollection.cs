namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specific collection of Paragraph items in a Wordprocessing document, extending the generic ContentItemsCollection to handle ModelElement types. This collection is designed to accept any item and provides a mapping between OpenXml element types and model element types for proper data loading and synchronization within the document model.
/// </summary>
public class ParagraphItemsCollection: ContentItemsCollection
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="parent">Model element that owns this collection. Cannot be null.</param>
  /// <param name="openXmlParagraph">The OpenXml Paragraph element to be wrapped by the collection. Can be null.</param>

  public ParagraphItemsCollection(DMW.Paragraph parent, DXW.Paragraph? openXmlParagraph): base(parent, openXmlParagraph)
  {
  }

  /// <summary>
  /// Accepts source items. ParagraphProperties are not accepted.
  /// </summary>
  /// <param name="item"></param>
  /// <returns></returns>
  public override bool AcceptSourceItem(DX.OpenXmlElement item)
  {
    return item.GetType()!=typeof(DXW.ParagraphProperties);
  }
}
