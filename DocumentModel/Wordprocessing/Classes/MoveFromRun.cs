using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Move Source Run Content.
/// </summary>
public class MoveFromRun
{
  public SdtRun? SdtRun { get; set; }

  public ProofError? ProofError { get; set; }

  public PermStart? PermStart { get; set; }

  public PermEnd? PermEnd { get; set; }

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

  public InsertedRun? InsertedRun { get; set; }

  public DeletedRun? DeletedRun { get; set; }

  public MoveFromRun? ChildMoveFromRun { get; set; }

  public MoveToRun? MoveToRun { get; set; }

  public RunConflictInsertion? RunConflictInsertion { get; set; }

  public RunConflictDeletion? RunConflictDeletion { get; set; }

  public Math.Paragraph? Paragraph { get; set; }

  public OfficeMath? OfficeMath { get; set; }

  public Accent? Accent { get; set; }

  public Bar? Bar { get; set; }

  public Math.Box? Box { get; set; }

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

  public Math.Run? Run { get; set; }

  public BidirectionalOverride? BidirectionalOverride { get; set; }

  public BidirectionalEmbedding? BidirectionalEmbedding { get; set; }
}