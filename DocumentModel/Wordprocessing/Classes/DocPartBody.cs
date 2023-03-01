namespace DocumentModel.Wordprocessing;

/// <summary>
///   Contents of Glossary Document Entry.
/// </summary>
public class DocPartBody
{
  public Collection<AltChunk>? AltChunks { get; set; }

  public CustomXmlBlock? CustomXmlBlock { get; set; }

  public SdtBlock? SdtBlock { get; set; }

  public Collection<Paragraph>? Paragraphs { get; set; }

  public Collection<Table>? Tables { get; set; }

  public ProofError? ProofError { get; set; }

  public PermStart? PermStart { get; set; }

  public PermEnd? PermEnd { get; set; }

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

  public InsertedRun? InsertedRun { get; set; }

  public DeletedRun? DeletedRun { get; set; }

  public MoveFromRun? MoveFromRun { get; set; }

  public MoveToRun? MoveToRun { get; set; }

  public RunConflictInsertion? RunConflictInsertion { get; set; }

  public RunConflictDeletion? RunConflictDeletion { get; set; }

  public SectionProperties? SectionProperties { get; set; }
}