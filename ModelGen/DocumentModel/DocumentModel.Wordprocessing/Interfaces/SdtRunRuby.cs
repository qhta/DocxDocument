namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRunRuby Class.
/// </summary>
public interface SdtRunRuby // : DocumentModel.Wordprocessing.SdtElement
{
  /// <summary>
  /// SdtContentRunRuby.
  /// </summary>
  public SdtContentRunRuby? SdtContentRunRuby { get ; set; }
  
  public SdtProperties? SdtProperties { get ; set; }
  
  public SdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
  public Collection<BookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<MarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<MarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<MarkupRangeType>? CommentRangeEnds { get ; set; }
  
  public Collection<MoveBookmarkType>? MoveFromRangeStarts { get ; set; }
  
  public Collection<MarkupRangeType>? MoveFromRangeEnds { get ; set; }
  
  public Collection<MoveBookmarkType>? MoveToRangeStarts { get ; set; }
  
  public Collection<MarkupRangeType>? MoveToRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlInsRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlInsRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlDelRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlDelRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlMoveFromRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlMoveFromRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlMoveToRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlMoveToRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlConflictInsertionRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlConflictInsertionRangeEnds { get ; set; }
  
  public Collection<TrackChangeType>? CustomXmlConflictDeletionRangeStarts { get ; set; }
  
  public Collection<MarkupType>? CustomXmlConflictDeletionRangeEnds { get ; set; }
  
}
