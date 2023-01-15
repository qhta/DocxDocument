namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtRunRuby Class.
/// </summary>
public class SdtRunRuby
{
  /// <summary>
  ///   SdtContentRunRuby.
  /// </summary>
  public SdtContentRunRuby? SdtContentRunRuby { get; set; }

  public SdtProperties? SdtProperties { get; set; }

  public SdtEndCharProperties? SdtEndCharProperties { get; set; }

  public BookmarkStart? BookmarkStart { get; set; }

  public MarkupRangeType? BookmarkEnd { get; set; }

  public MarkupRangeType? CommentRangeStart { get; set; }

  public MarkupRangeType? CommentRangeEnd { get; set; }

  public MoveBookmarkType? MoveFromRangeStart { get; set; }

  public MarkupRangeType? MoveFromRangeEnd { get; set; }

  public MoveBookmarkType? MoveToRangeStart { get; set; }

  public MarkupRangeType? MoveToRangeEnd { get; set; }

  public TrackChangeType? CustomXmlInsRangeStart { get; set; }

  public MarkupType? CustomXmlInsRangeEnd { get; set; }

  public TrackChangeType? CustomXmlDelRangeStart { get; set; }

  public MarkupType? CustomXmlDelRangeEnd { get; set; }

  public TrackChangeType? CustomXmlMoveFromRangeStart { get; set; }

  public MarkupType? CustomXmlMoveFromRangeEnd { get; set; }

  public TrackChangeType? CustomXmlMoveToRangeStart { get; set; }

  public MarkupType? CustomXmlMoveToRangeEnd { get; set; }

  public TrackChangeType2? CustomXmlConflictInsertionRangeStart { get; set; }

  public MarkupType2? CustomXmlConflictInsertionRangeEnd { get; set; }

  public TrackChangeType2? CustomXmlConflictDeletionRangeStart { get; set; }

  public MarkupType2? CustomXmlConflictDeletionRangeEnd { get; set; }
}