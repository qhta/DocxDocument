namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Table Class.
/// </summary>
public record Table: BodyElement
{
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

  public TableProperties? TableProperties { get; set; }

  public TableGrid? TableGrid { get; set; }

  public Collection<TableRow>? TableRows { get; set; }

  public CustomXmlRow? CustomXmlRow { get; set; }

  public SdtRow? SdtRow { get; set; }

  public ProofError? ProofError { get; set; }

  public PermStart? PermStart { get; set; }

  public PermEnd? PermEnd { get; set; }

  public InsertedRun? InsertedRun { get; set; }

  public DeletedRun? DeletedRun { get; set; }

  public MoveFromRun? MoveFromRun { get; set; }

  public MoveToRun? MoveToRun { get; set; }

  public RunConflictInsertion? RunConflictInsertion { get; set; }

  public RunConflictDeletion? RunConflictDeletion { get; set; }
}