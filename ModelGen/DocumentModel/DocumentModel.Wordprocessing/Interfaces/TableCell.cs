namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Cell.
/// </summary>
public interface TableCell
{
  /// <summary>
  /// Table Cell Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TableCellProperties? TableCellProperties { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.AltChunk>? AltChunks { get ; set; }
  
  public DocumentModel.Wordprocessing.CustomXmlBlock? CustomXmlBlock { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtBlock? SdtBlock { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Paragraph>? Paragraphs { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Table>? Tables { get ; set; }
  
  public DocumentModel.Wordprocessing.ProofError? ProofError { get ; set; }
  
  public DocumentModel.Wordprocessing.PermStart? PermStart { get ; set; }
  
  public DocumentModel.Wordprocessing.PermEnd? PermEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.BookmarkStart? BookmarkStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? BookmarkEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveFromRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveFromRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveToRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveToRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlInsRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlInsRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlDelRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlDelRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveFromRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveFromRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveToRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveToRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType2? CustomXmlConflictInsertionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType2? CustomXmlConflictInsertionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType2? CustomXmlConflictDeletionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType2? CustomXmlConflictDeletionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.InsertedRun? InsertedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.DeletedRun? DeletedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveFromRun? MoveFromRun { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveToRun? MoveToRun { get ; set; }
  
  public DocumentModel.Wordprocessing.RunConflictInsertion? RunConflictInsertion { get ; set; }
  
  public DocumentModel.Wordprocessing.RunConflictDeletion? RunConflictDeletion { get ; set; }
  
}
