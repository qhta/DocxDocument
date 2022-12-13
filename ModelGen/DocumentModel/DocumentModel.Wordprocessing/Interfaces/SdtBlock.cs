namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public interface SdtBlock
{
  /// <summary>
  /// Block-Level Structured Document Tag Content.
  /// </summary>
  public DocumentModel.Wordprocessing.SdtContentBlock? SdtContentBlock { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtProperties? SdtProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
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
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlConflictInsertionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlConflictInsertionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlConflictDeletionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlConflictDeletionRangeEnd { get ; set; }
  
}
