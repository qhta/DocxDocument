namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public partial class TableRow
{
  /// <summary>
  /// Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  public Byte[]? RsidTableRowMarkRevision { get; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row
  /// </summary>
  public Byte[]? RsidTableRowAddition { get; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Deletion
  /// </summary>
  public Byte[]? RsidTableRowDeletion { get; set; }
  
  /// <summary>
  /// Revision Identifier for Table Row Properties
  /// </summary>
  public Byte[]? RsidTableRowProperties { get; set; }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public Byte[]? ParagraphId { get; set; }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  public Byte[]? TextId { get; set; }
  
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public DocumentModel.Wordprocessing.TablePropertyExceptions? TablePropertyExceptions { get; set; }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableRowProperties? TableRowProperties { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.TableCell>? TableCells { get; set; }
  
  public DocumentModel.Wordprocessing.CustomXmlCell? CustomXmlCell { get; set; }
  
  public DocumentModel.Wordprocessing.SdtCell? SdtCell { get; set; }
  
  public DocumentModel.Wordprocessing.ProofError? ProofError { get; set; }
  
  public DocumentModel.Wordprocessing.PermStart? PermStart { get; set; }
  
  public DocumentModel.Wordprocessing.PermEnd? PermEnd { get; set; }
  
  public DocumentModel.Wordprocessing.BookmarkStart? BookmarkStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? BookmarkEnd { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveFromRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveFromRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveToRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveToRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlInsRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlInsRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlDelRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlDelRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveFromRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveFromRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveToRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveToRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType2? CustomXmlConflictInsertionRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType2? CustomXmlConflictInsertionRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType2? CustomXmlConflictDeletionRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType2? CustomXmlConflictDeletionRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.InsertedRun? InsertedRun { get; set; }
  
  public DocumentModel.Wordprocessing.DeletedRun? DeletedRun { get; set; }
  
  public DocumentModel.Wordprocessing.MoveFromRun? MoveFromRun { get; set; }
  
  public DocumentModel.Wordprocessing.MoveToRun? MoveToRun { get; set; }
  
  public DocumentModel.Wordprocessing.RunConflictInsertion? RunConflictInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.RunConflictDeletion? RunConflictDeletion { get; set; }
  
}
