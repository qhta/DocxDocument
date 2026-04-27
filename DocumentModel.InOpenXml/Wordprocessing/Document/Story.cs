namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the content of the document or part of the document.
/// This class extends <see cref = "ModelElementCollection{StoryContent}"/> and contains block-level markup, allowing elements such as paragraphs, tables, and other block content to exist as siblings within the document structure.
/// </summary>
[XmlRoot("Story", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DX.OpenXmlCompositeElement))]
[DirectAccess(true)]
public abstract partial class Story<OpenXmlCollectionType>: ModelElement<OpenXmlCollectionType>
  where OpenXmlCollectionType: DX.OpenXmlCompositeElement
{
  /// <summary>
  /// Default constructor for the Story class, initializing a new instance of the Story class.
  /// </summary>
  protected Story() { }

  /// <summary>
  /// Initializes a new instance of the Story class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement to associate with this story. Cannot be null. </param>
  protected Story(ModelElement parent) : base(parent) { }

  /// <summary>
  /// Initializes a new instance of the Story class using the specified OpenXmlCollectionType element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCollectionType element that provides the underlying XML data for the story.</param>
  protected Story(DX.OpenXmlCompositeElement openXmlElement) : base(openXmlElement) { }

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

  public StoryItemsCollection Items
  {
    get
    {
      if (_Items == null)
      {
        if (_openXmlElement != null)
          _Items = new StoryItemsCollection(this, _openXmlElement);
        else 
          _Items = new StoryItemsCollection(this);
      }
      return _Items;
    }
  }

  private StoryItemsCollection? _Items;


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