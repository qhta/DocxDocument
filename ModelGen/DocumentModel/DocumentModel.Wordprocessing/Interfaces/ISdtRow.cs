namespace DocumentModel.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public interface ISdtRow // : DocumentModel.Wordprocessing.ISdtElement
{
  /// <summary>
  /// Row-Level Structured Document Tag Content.
  /// </summary>
  public ISdtContentRow? SdtContentRow { get ; set; }
  
  public ISdtProperties? SdtProperties { get ; set; }
  
  public ISdtEndCharProperties? SdtEndCharProperties { get ; set; }
  
  public Collection<IBookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<IMarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? CommentRangeEnds { get ; set; }
  
  public Collection<IMoveBookmarkType>? MoveFromRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? MoveFromRangeEnds { get ; set; }
  
  public Collection<IMoveBookmarkType>? MoveToRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? MoveToRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlInsRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlInsRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlDelRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlDelRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlMoveFromRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlMoveFromRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlMoveToRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlMoveToRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlConflictInsertionRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlConflictInsertionRangeEnds { get ; set; }
  
  public Collection<ITrackChangeType>? CustomXmlConflictDeletionRangeStarts { get ; set; }
  
  public Collection<IMarkupType>? CustomXmlConflictDeletionRangeEnds { get ; set; }
  
}
