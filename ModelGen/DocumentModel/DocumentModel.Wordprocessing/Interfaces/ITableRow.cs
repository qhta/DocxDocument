namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public interface ITableRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowMarkRevision { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowAddition { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Deletion
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Properties
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidTableRowProperties { get ; set; }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? ParagraphId { get ; set; }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? TextId { get ; set; }
  
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.ITablePropertyExceptions? TablePropertyExceptions { get ; set; }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ITableRowProperties? TableRowProperties { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ITableCell>? TableCells { get ; set; }
  
  public DocumentModel.Wordprocessing.ICustomXmlCell? CustomXmlCell { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtCell? SdtCell { get ; set; }
  
  public DocumentModel.Wordprocessing.IProofError? ProofError { get ; set; }
  
  public DocumentModel.Wordprocessing.IPermStart? PermStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IPermEnd? PermEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IBookmarkStart? BookmarkStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? BookmarkEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? CommentRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? CommentRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveBookmarkType? MoveFromRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? MoveFromRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveBookmarkType? MoveToRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? MoveToRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlInsRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlInsRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlDelRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlDelRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlMoveFromRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlMoveFromRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlMoveToRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlMoveToRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlConflictInsertionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlConflictInsertionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlConflictDeletionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlConflictDeletionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IInsertedRun? InsertedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.IDeletedRun? DeletedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveFromRun? MoveFromRun { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveToRun? MoveToRun { get ; set; }
  
  public DocumentModel.Wordprocessing.IRunConflictInsertion? RunConflictInsertion { get ; set; }
  
  public DocumentModel.Wordprocessing.IRunConflictDeletion? RunConflictDeletion { get ; set; }
  
}
