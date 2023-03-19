namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtRunRuby Class.
/// </summary>
public class SdtRunRuby: ModelElement
{
  /// <summary>
  ///   SdtContentRunRuby.
  /// </summary>
  public SdtContentRunRuby? SdtContentRunRuby { get; set; }

  public SdtProperties? SdtProperties { get; set; }

  public SdtEndCharProperties? SdtEndCharProperties { get; set; }

  public BookmarkStart? BookmarkStart { get; set; }

  public BookmarkEnd? BookmarkEnd { get; set; }

  public CommentRangeStart? CommentRangeStart { get; set; }

  public CommentRangeEnd? CommentRangeEnd { get; set; }

  public MoveFromRangeStart? MoveFromRangeStart { get; set; }

  public MoveFromRangeEnd? MoveFromRangeEnd { get; set; }

  public MoveToRangeStart? MoveToRangeStart { get; set; }

  public MoveToRangeEnd? MoveToRangeEnd { get; set; }

  public CustomXmlInsRangeStart? CustomXmlInsRangeStart { get; set; }

  public CustomXmlInsRangeEnd? CustomXmlInsRangeEnd { get; set; }

  public CustomXmlDelRangeStart? CustomXmlDelRangeStart { get; set; }

  public CustomXmlDelRangeEnd? CustomXmlDelRangeEnd { get; set; }

  public CustomXmlMoveFromRangeStart? CustomXmlMoveFromRangeStart { get; set; }

  public CustomXmlMoveFromRangeEnd? CustomXmlMoveFromRangeEnd { get; set; }

  public CustomXmlMoveToRangeStart? CustomXmlMoveToRangeStart { get; set; }

  public CustomXmlMoveToRangeEnd? CustomXmlMoveToRangeEnd { get; set; }

  public CustomXmlConflictInsertionRangeStart? CustomXmlConflictInsertionRangeStart { get; set; }

  public CustomXmlConflictInsertionRangeEnd? CustomXmlConflictInsertionRangeEnd { get; set; }

  public CustomXmlConflictDeletionRangeStart? CustomXmlConflictDeletionRangeStart { get; set; }

  public CustomXmlConflictDeletionRangeEnd? CustomXmlConflictDeletionRangeEnd { get; set; }
}