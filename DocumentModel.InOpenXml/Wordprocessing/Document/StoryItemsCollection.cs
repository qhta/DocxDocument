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

  /// <summary>
  /// Static mapping from OpenXml element types to model element types. 
  /// </summary>
  private static readonly Dictionary<Type, Type> _OpenXml2ModelElementTypeMapping = new()
  {
    { typeof(DXW.Paragraph), typeof(DMW.Paragraph) },
    { typeof(DXW.Table), typeof(DMW.Table) },
    { typeof(DXW.AltChunk), typeof(DMW.AltChunk) },
    { typeof(DXW.SdtBlock), typeof(DMW.SdtBlock) },
    { typeof(DXW.BookmarkStart), typeof(DMW.BookmarkStart) },
    { typeof(DXW.ContentPart), typeof(DMW.ContentPart) },
    { typeof(DXW.CustomXmlBlock), typeof(DMW.CustomXmlBlock) },
    { typeof(DXW.CustomXmlInsRangeEnd), typeof(DMW.CustomXmlInsRangeEnd) },
    { typeof(DXW.CustomXmlDelRangeEnd), typeof(DMW.CustomXmlDelRangeEnd) },
    { typeof(DXW.CustomXmlMoveFromRangeEnd), typeof(DMW.CustomXmlMoveFromRangeEnd) },
    { typeof(DXW.CustomXmlMoveToRangeEnd), typeof(DMW.CustomXmlMoveToRangeEnd) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeEnd), typeof(DMW.CustomXmlConflictInsertionRangeEnd) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeEnd), typeof(DMW.CustomXmlConflictDeletionRangeEnd) },
    { typeof(DXW.BookmarkEnd), typeof(DMW.BookmarkEnd) },
    { typeof(DXW.CommentRangeStart), typeof(DMW.CommentRangeStart) },
    { typeof(DXW.CommentRangeEnd), typeof(DMW.CommentRangeEnd) },
    { typeof(DXW.MoveFromRangeEnd), typeof(DMW.MoveFromRangeEnd) },
    { typeof(DXW.MoveToRangeEnd), typeof(DMW.MoveToRangeEnd) },
    { typeof(DXW.MoveFromRangeStart), typeof(DMW.MoveFromRangeStart) },
    { typeof(DXW.MoveToRangeStart), typeof(DMW.MoveToRangeStart) },
    { typeof(DXW.PermEnd), typeof(DMW.PermEnd) },
    { typeof(DXW.PermStart), typeof(DMW.PermStart) },
    { typeof(DXW.ProofError), typeof(DMW.ProofError) },
    { typeof(DXW.InsertedRun), typeof(DMW.InsertedRun) },
    { typeof(DXW.DeletedRun), typeof(DMW.DeletedRun) },
    { typeof(DXW.MoveFromRun), typeof(DMW.MoveFromRun) },
    { typeof(DXW.MoveToRun), typeof(DMW.MoveToRun) },
    { typeof(DXO10W.RunConflictInsertion), typeof(DMW.RunConflictInsertion) },
    { typeof(DXO10W.RunConflictDeletion), typeof(DMW.RunConflictDeletion) },
    { typeof(DXW.SectionProperties), typeof(DMW.SectionProperties) },
    { typeof(DXW.CustomXmlInsRangeStart), typeof(DMW.CustomXmlInsRangeStart) },
    { typeof(DXW.CustomXmlDelRangeStart), typeof(DMW.CustomXmlDelRangeStart) },
    { typeof(DXW.CustomXmlMoveFromRangeStart), typeof(DMW.CustomXmlMoveFromRangeStart) },
    { typeof(DXW.CustomXmlMoveToRangeStart), typeof(DMW.CustomXmlMoveToRangeStart) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeStart), typeof(DMW.CustomXmlConflictInsertionRangeStart) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeStart), typeof(DMW.CustomXmlConflictDeletionRangeStart) },
  };

  /// <summary>
  /// Static mapping from OpenXml element types to model element types. 
  /// </summary>
  private static readonly Dictionary<Type, Type[]> _ModelType2OpenXmlElementMapping = new()
  {
    { typeof(DMW.Paragraph), [typeof(DXW.Paragraph)] },
    { typeof(DMW.Table), [typeof(DXW.Table)] },
    { typeof(DMW.AltChunk), [typeof(DXW.AltChunk)] },
    { typeof(DMW.SdtBlock), [typeof(DXW.SdtBlock)] },
    { typeof(DMW.BookmarkStart), [typeof(DXW.BookmarkStart)] },
    { typeof(DMW.ContentPart), [typeof(DXW.ContentPart)] },
    { typeof(DMW.CustomXmlBlock), [typeof(DXW.CustomXmlBlock)] },
    { typeof(DMW.CustomXmlInsRangeEnd), [typeof(DXW.CustomXmlInsRangeEnd)] },
    { typeof(DMW.CustomXmlDelRangeEnd), [typeof(DXW.CustomXmlDelRangeEnd)] },
    { typeof(DMW.CustomXmlMoveFromRangeEnd), [typeof(DXW.CustomXmlMoveFromRangeEnd)] },
    { typeof(DMW.CustomXmlMoveToRangeEnd), [typeof(DXW.CustomXmlMoveToRangeEnd)] },
    { typeof(DMW.CustomXmlConflictInsertionRangeEnd), [typeof(DXO10W.CustomXmlConflictInsertionRangeEnd)] },
    { typeof(DMW.CustomXmlConflictDeletionRangeEnd), [typeof(DXO10W.CustomXmlConflictDeletionRangeEnd)] },
    { typeof(DMW.BookmarkEnd), [typeof(DXW.BookmarkEnd)] },
    { typeof(DMW.CommentRangeStart), [typeof(DXW.CommentRangeStart)] },
    { typeof(DMW.CommentRangeEnd), [typeof(DXW.CommentRangeEnd)] },
    { typeof(DMW.MoveFromRangeEnd), [typeof(DXW.MoveFromRangeEnd)] },
    { typeof(DMW.MoveToRangeEnd), [typeof(DXW.MoveToRangeEnd)] },
    { typeof(DMW.MoveFromRangeStart), [typeof(DXW.MoveFromRangeStart)] },
    { typeof(DMW.MoveToRangeStart), [typeof(DXW.MoveToRangeStart)] },
    { typeof(DMW.PermEnd), [typeof(DXW.PermEnd)] },
    { typeof(DMW.PermStart), [typeof(DXW.PermStart)] },
    { typeof(DMW.ProofError), [typeof(DXW.ProofError)] },
    { typeof(DMW.InsertedRun), [typeof(DXW.InsertedRun)] },
    { typeof(DMW.DeletedRun), [typeof(DXW.DeletedRun)] },
    { typeof(DMW.MoveFromRun), [typeof(DXW.MoveFromRun)] },
    { typeof(DMW.MoveToRun), [typeof(DXW.MoveToRun)] },
    { typeof(DMW.RunConflictInsertion), [typeof(DXO10W.RunConflictInsertion)] },
    { typeof(DMW.RunConflictDeletion), [typeof(DXO10W.RunConflictDeletion)] },
    { typeof(DMW.SectionProperties), [typeof(DXW.SectionProperties)] },
    { typeof(DMW.CustomXmlInsRangeStart), [typeof(DXW.CustomXmlInsRangeStart)] },
    { typeof(DMW.CustomXmlDelRangeStart), [typeof(DXW.CustomXmlDelRangeStart)] },
    { typeof(DMW.CustomXmlMoveFromRangeStart), [typeof(DXW.CustomXmlMoveFromRangeStart)] },
    { typeof(DMW.CustomXmlMoveToRangeStart), [typeof(DXW.CustomXmlMoveToRangeStart)] },
    { typeof(DMW.CustomXmlConflictInsertionRangeStart), [typeof(DXO10W.CustomXmlConflictInsertionRangeStart)] },
    { typeof(DMW.CustomXmlConflictDeletionRangeStart), [typeof(DXO10W.CustomXmlConflictDeletionRangeStart)] },
  };

  /// <summary>
  /// Gets the mapping between OpenXml element types and their corresponding model element types.
  /// </summary>
  protected override Dictionary<Type, Type> OpenXmlElement2ModelTypeMapping => _OpenXml2ModelElementTypeMapping;

  /// <summary>
  /// Gets the mapping between model element types and their corresponding OpenXml element types.
  /// </summary>
  protected override Dictionary<Type, Type[]> ModelType2OpenXmlElementsMapping => _ModelType2OpenXmlElementMapping;
}
