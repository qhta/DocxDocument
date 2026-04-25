namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the content of the document or part of the document.
/// This class extends <see cref = "ModelElementCollection{StoryContent}"/> and contains block-level markup, allowing elements such as paragraphs, tables, and other block content to exist as siblings within the document structure.
/// </summary>
[XmlRoot("Story", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DX.OpenXmlCompositeElement))]
public partial class Story<OpenXmlCollectionType>: ModelElement<OpenXmlCollectionType>
  where OpenXmlCollectionType: DX.OpenXmlCompositeElement
{

  /// <summary>
  /// Collection of items.
  /// </summary>
  [XmlArray("Items")]
  [XmlArrayItem("Paragraph", typeof(Paragraph))]
  [XmlArrayItem("Table", typeof(Table))]
  [XmlArrayItem("AltChunk", typeof(AltChunk))]
  [XmlArrayItem("SdtBlock", typeof(SdtBlock))]
  [XmlArrayItem("BookmarkStart", typeof(BookmarkStart))]
  [XmlArrayItem("ContentPart", typeof(ContentPart))]
  [XmlArrayItem("CustomXmlBlock", typeof(CustomXmlBlock))]
  [XmlArrayItem("CustomXmlInsRangeEnd", typeof(CustomXmlInsRangeEnd))]
  [XmlArrayItem("CustomXmlDelRangeEnd", typeof(CustomXmlDelRangeEnd))]
  [XmlArrayItem("CustomXmlMoveFromRangeEnd", typeof(CustomXmlMoveFromRangeEnd))]
  [XmlArrayItem("CustomXmlMoveToRangeEnd", typeof(CustomXmlMoveToRangeEnd))]
  [XmlArrayItem("CustomXmlConflictInsertionRangeEnd", typeof(CustomXmlConflictInsertionRangeEnd))]
  [XmlArrayItem("CustomXmlConflictDeletionRangeEnd", typeof(CustomXmlConflictDeletionRangeEnd))]
  [XmlArrayItem("BookmarkEnd", typeof(BookmarkEnd))]
  [XmlArrayItem("CommentRangeStart", typeof(CommentRangeStart))]
  [XmlArrayItem("CommentRangeEnd", typeof(CommentRangeEnd))]
  [XmlArrayItem("MoveFromRangeEnd", typeof(MoveFromRangeEnd))]
  [XmlArrayItem("MoveToRangeEnd", typeof(MoveToRangeEnd))]
  [XmlArrayItem("MoveFromRangeStart", typeof(MoveFromRangeStart))]
  [XmlArrayItem("MoveToRangeStart", typeof(MoveToRangeStart))]
  [XmlArrayItem("PermEnd", typeof(PermEnd))]
  [XmlArrayItem("PermStart", typeof(PermStart))]
  [XmlArrayItem("ProofError", typeof(ProofError))]
  [XmlArrayItem("InsertedRun", typeof(InsertedRun))]
  [XmlArrayItem("DeletedRun", typeof(DeletedRun))]
  [XmlArrayItem("MoveFromRun", typeof(MoveFromRun))]
  [XmlArrayItem("MoveToRun", typeof(MoveToRun))]
  [XmlArrayItem("RunConflictInsertion", typeof(RunConflictInsertion))]
  [XmlArrayItem("RunConflictDeletion", typeof(RunConflictDeletion))]
  [XmlArrayItem("SectionProperties", typeof(SectionProperties))]
  [XmlArrayItem("CustomXmlInsRangeStart", typeof(CustomXmlInsRangeStart))]
  [XmlArrayItem("CustomXmlDelRangeStart", typeof(CustomXmlDelRangeStart))]
  [XmlArrayItem("CustomXmlMoveFromRangeStart", typeof(CustomXmlMoveFromRangeStart))]
  [XmlArrayItem("CustomXmlMoveToRangeStart", typeof(CustomXmlMoveToRangeStart))]
  [XmlArrayItem("CustomXmlConflictInsertionRangeStart", typeof(CustomXmlConflictInsertionRangeStart))]
  [XmlArrayItem("CustomXmlConflictDeletionRangeStart", typeof(CustomXmlConflictDeletionRangeStart))]

  public StoryItemsCollection Items { get; set; } = new();


  /// <summary>
  /// Updates the Open XML composite element to reflect the current state of the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element to update.</param>
  protected void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    SetUpdatableElement(openXmlModeledCollection);
    var children = openXmlModeledCollection.Elements().ToArray();
    foreach (var child in children)
    {
      child.Remove();
    }
    foreach (var item in Items)
    {
      if (item is IUpdatable updatable)
      {
        var updatableElement = updatable.GetUpdatableElement();
        if (updatableElement is DX.OpenXmlElement openXmlElement)
        {
          item.UpdateData(openXmlElement);
          openXmlModeledCollection.AppendChild(openXmlElement);
        }
      }
    }
  }
}