namespace DocumentModel.Wordprocessing;

/// <summary>
/// Cell-Level Custom XML Element.
/// </summary>
public interface CustomXmlCell
{
  public CustomXmlProperties? CustomXmlProperties { get ; set; }
  
  public Collection<TableCell>? TableCells { get ; set; }
  
  public CustomXmlCell? ChildCustomXmlCell { get ; set; }
  
  public SdtCell? SdtCell { get ; set; }
  
  public ProofError? ProofError { get ; set; }
  
  public PermStart? PermStart { get ; set; }
  
  public PermEnd? PermEnd { get ; set; }
  
  public BookmarkStart? BookmarkStart { get ; set; }
  
  public MarkupRangeType? BookmarkEnd { get ; set; }
  
  public MarkupRangeType? CommentRangeStart { get ; set; }
  
  public MarkupRangeType? CommentRangeEnd { get ; set; }
  
  public MoveBookmarkType? MoveFromRangeStart { get ; set; }
  
  public MarkupRangeType? MoveFromRangeEnd { get ; set; }
  
  public MoveBookmarkType? MoveToRangeStart { get ; set; }
  
  public MarkupRangeType? MoveToRangeEnd { get ; set; }
  
  public TrackChangeType? CustomXmlInsRangeStart { get ; set; }
  
  public MarkupType? CustomXmlInsRangeEnd { get ; set; }
  
  public TrackChangeType? CustomXmlDelRangeStart { get ; set; }
  
  public MarkupType? CustomXmlDelRangeEnd { get ; set; }
  
  public TrackChangeType? CustomXmlMoveFromRangeStart { get ; set; }
  
  public MarkupType? CustomXmlMoveFromRangeEnd { get ; set; }
  
  public TrackChangeType? CustomXmlMoveToRangeStart { get ; set; }
  
  public MarkupType? CustomXmlMoveToRangeEnd { get ; set; }
  
  public TrackChangeType? CustomXmlConflictInsertionRangeStart { get ; set; }
  
  public MarkupType? CustomXmlConflictInsertionRangeEnd { get ; set; }
  
  public TrackChangeType? CustomXmlConflictDeletionRangeStart { get ; set; }
  
  public MarkupType? CustomXmlConflictDeletionRangeEnd { get ; set; }
  
  public InsertedRun? InsertedRun { get ; set; }
  
  public DeletedRun? DeletedRun { get ; set; }
  
  public MoveFromRun? MoveFromRun { get ; set; }
  
  public MoveToRun? MoveToRun { get ; set; }
  
  public RunConflictInsertion? RunConflictInsertion { get ; set; }
  
  public RunConflictDeletion? RunConflictDeletion { get ; set; }
  
}
