using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;

/// <summary>
///   Upper limit (n-ary).
/// </summary>
public record SuperArgument
{
  public ArgumentProperties? ArgumentProperties { get; set; }

  public Accent? Accent { get; set; }

  public Bar? Bar { get; set; }

  public Box? Box { get; set; }

  public BorderBox? BorderBox { get; set; }

  public Delimiter? Delimiter { get; set; }

  public EquationArray? EquationArray { get; set; }

  public Fraction? Fraction { get; set; }

  public MathFunction? MathFunction { get; set; }

  public GroupChar? GroupChar { get; set; }

  public LimitLower? LimitLower { get; set; }

  public LimitUpper? LimitUpper { get; set; }

  public Matrix? Matrix { get; set; }

  public Nary? Nary { get; set; }

  public Phantom? Phantom { get; set; }

  public Radical? Radical { get; set; }

  public PreSubSuper? PreSubSuper { get; set; }

  public Subscript? Subscript { get; set; }

  public SubSuperscript? SubSuperscript { get; set; }

  public Superscript? Superscript { get; set; }

  public Run? Run { get; set; }

  public CustomXmlRun? CustomXmlRun { get; set; }

  public Collection<SimpleField>? SimpleFields { get; set; }

  public Wordprocessing.Hyperlink? Hyperlink { get; set; }

  public SdtRun? SdtRun { get; set; }

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

  public Paragraph? Paragraph { get; set; }

  public OfficeMath? OfficeMath { get; set; }

  public ControlProperties? ControlProperties { get; set; }
}