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
  /// <param name="openXmlElement">The OpenXmlCollectionType element that provides the underlying XML data for the story.</param>
  protected Story(ModelElement parent, DX.OpenXmlCompositeElement? openXmlElement): base(parent, openXmlElement) { }

  /// <summary>
  /// Initializes a new instance of the Story class using the specified OpenXmlCollectionType element.
  /// </summary>
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

  public StoryItemsCollection Items => _Items ??= new StoryItemsCollection(this, GetUpdatableElement());

  private StoryItemsCollection? _Items;


  /// <summary>
  /// Gets a collection of paragraphs within the story, providing access to all paragraph elements contained in the story's items.
  /// This property retrieves a collection of paragraphs by filtering the items in the story to include only those that are of type <see cref="DMW.Paragraph"/>.
  /// </summary>
  public DMW.Paragraphs Paragraphs => _Paragraphs ??= new DMW.Paragraphs(this, Items);
  private DMW.Paragraphs? _Paragraphs;

}