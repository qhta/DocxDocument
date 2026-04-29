namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specific collection of Story items in a Wordprocessing document, extending the generic ContentItemsCollection to handle ModelElement types. This collection is designed to accept any item and provides a mapping between OpenXml element types and model element types for proper data loading and synchronization within the document model.
/// </summary>
//[OpenXmlItem(typeof(DX.OpenXmlElement))]
public class StoryItemsCollection: ContentItemsCollection<ModelElement>
{

  /// <summary>
  /// Initializes a new instance of the StoryItemsCollection class with the specified parent model element and Open XML
  /// composite element as the data source.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that serves as the data source for the collection. Can be null.</param>
  public StoryItemsCollection(ModelElement parent, DX.OpenXmlCompositeElement? openXmlElement) : base(parent, openXmlElement)
  {
  }

  /// <summary>
  /// Static mapping between OpenXml element types and their corresponding model element types. This bidirectional dictionary allows for easy conversion and lookup between the two type systems, facilitating the loading and updating of model elements based on their OpenXml representations.
  /// </summary>
  private static readonly BiDiDictionary<Type, Type> _ModelElementTypeMapping = new()
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
  /// Gets the mapping between model element types and their corresponding mapped types.  
  /// </summary>
  /// <remarks>This property provides a bidirectional dictionary that associates each model element type with
  /// its mapped type. The mapping enables conversion or lookup operations between the two type systems, which is useful
  /// for scenarios such as serialization, deserialization, or type resolution in modeling frameworks.</remarks>
  public override BiDiDictionary<Type, Type> ModelElementTypeMapping => _ModelElementTypeMapping;
}
