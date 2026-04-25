namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specific collection of story items in a Wordprocessing document, extending the generic ContentItemsCollection to handle ModelElement types. This collection is designed to accept any item and provides a mapping between OpenXml element types and model element types for proper data loading and synchronization within the document model.
/// </summary>
public class ParagraphItemsCollection: ContentItemsCollection<ModelElement>
{

  /// <summary>
  /// Static mapping between OpenXml element types and their corresponding model element types. This bidirectional dictionary allows for easy conversion and lookup between the two type systems, facilitating the loading and updating of model elements based on their OpenXml representations.
  /// </summary>
  private static readonly BiDiDictionary<Type, Type> _ModelElementTypeMapping = new()
  {
    { typeof(DXM.Accent), typeof(DMM.Accent) },
    { typeof(DXM.Bar), typeof(DMM.Bar) },
    { typeof(DXM.BorderBox), typeof(DMM.BorderBox) },
    { typeof(DXM.Box), typeof(DMM.Box) },
    { typeof(DXM.Delimiter), typeof(DMM.Delimiter) },
    { typeof(DXM.EquationArray), typeof(DMM.EquationArray) },
    { typeof(DXM.Fraction), typeof(DMM.Fraction) },
    { typeof(DXM.MathFunction), typeof(DMM.Function) },
    { typeof(DXM.GroupChar), typeof(DMM.GroupChar) },
    { typeof(DXM.LimitLower), typeof(DMM.LimitLower) },
    { typeof(DXM.LimitUpper), typeof(DMM.LimitUpper) },
    { typeof(DXM.Matrix), typeof(DMM.Matrix) },
    { typeof(DXM.Nary), typeof(DMM.Nary) },
    { typeof(DXM.OfficeMath), typeof(DMM.OfficeMath) },
    { typeof(DXM.Paragraph), typeof(DMM.Paragraph) },
    { typeof(DXM.Phantom), typeof(DMM.Phantom) },
    { typeof(DXM.Run), typeof(DMM.Run) },
    { typeof(DXM.Radical), typeof(DMM.Radical) },
    { typeof(DXM.PreSubSuper), typeof(DMM.PreSubSuper) },
    { typeof(DXM.Subscript), typeof(DMM.Subscript) },
    { typeof(DXM.SubSuperscript), typeof(DMM.SubSuperscript) },
    { typeof(DXM.Superscript), typeof(DMM.Superscript) },
    { typeof(DXW.BidirectionalOverride), typeof(DMW.BidirectionalOverride) },
    { typeof(DXW.BookmarkStart), typeof(DMW.BookmarkStart) },
    { typeof(DXW.ContentPart), typeof(DMW.ContentPart) },
    { typeof(DXW.CustomXmlRun), typeof(DMW.CustomXmlRun) },
    { typeof(DXW.BidirectionalEmbedding), typeof(DMW.BidirectionalEmbedding) },
    { typeof(DXW.Hyperlink), typeof(DMW.Hyperlink) },
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
    { typeof(DXW.ParagraphProperties), typeof(DMW.ParagraphProperties) },
    { typeof(DXW.ProofError), typeof(DMW.ProofError) },
    { typeof(DXW.Run), typeof(DMW.Run) },
    { typeof(DXW.SubDocumentReference), typeof(DMW.SubDocumentReference) },
    { typeof(DXW.InsertedRun), typeof(DMW.InsertedRun) },
    { typeof(DXW.DeletedRun), typeof(DMW.DeletedRun) },
    { typeof(DXW.MoveFromRun), typeof(DMW.MoveFromRun) },
    { typeof(DXW.MoveToRun), typeof(DMW.MoveToRun) },
    { typeof(DXO10W.RunConflictInsertion), typeof(DMW.RunConflictInsertion) },
    { typeof(DXO10W.RunConflictDeletion), typeof(DMW.RunConflictDeletion) },
    { typeof(DXW.SdtRun), typeof(DMW.SdtRun) },
    { typeof(DXW.SimpleField), typeof(DMW.SimpleField) },
    { typeof(DXW.CustomXmlInsRangeStart), typeof(DMW.CustomXmlInsRangeStart) },
    { typeof(DXW.CustomXmlDelRangeStart), typeof(DMW.CustomXmlDelRangeStart) },
    { typeof(DXW.CustomXmlMoveFromRangeStart), typeof(DMW.CustomXmlMoveFromRangeStart) },
    { typeof(DXW.CustomXmlMoveToRangeStart), typeof(DMW.CustomXmlMoveToRangeStart) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeStart), typeof(DMW.CustomXmlConflictInsertionRangeStart) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeStart), typeof(DMW.CustomXmlConflictDeletionRangeStart) },  };

  /// <summary>
  /// Gets the mapping between model element types and their corresponding mapped types.  
  /// </summary>
  /// <remarks>This property provides a bidirectional dictionary that associates each model element type with
  /// its mapped type. The mapping enables conversion or lookup operations between the two type systems, which is useful
  /// for scenarios such as serialization, deserialization, or type resolution in modeling frameworks.</remarks>
  public override BiDiDictionary<Type, Type> ModelElementTypeMapping => _ModelElementTypeMapping;
}
