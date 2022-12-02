namespace DocumentModel.Wordprocessing;

/// <summary>
/// Cell-Level Structured Document Tag.
/// </summary>
public interface ISdtCell // : DocumentModel.Wordprocessing.ISdtElement
{
  /// <summary>
  /// Cell-Level Structured Document Tag Content.
  /// </summary>
  public DocumentModel.Wordprocessing.ISdtContentCell? SdtContentCell { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtProperties? SdtProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
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
  
}
