namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CustomXmlRuby Class.
/// </summary>
public interface CustomXmlRuby
{
  public CustomXmlProperties? CustomXmlProperties { get ; set; }
  
  public CustomXmlRuby? ChildCustomXmlRuby { get ; set; }
  
  public SimpleFieldRuby? SimpleFieldRuby { get ; set; }
  
  public HyperlinkRuby? HyperlinkRuby { get ; set; }
  
  public Run? Run { get ; set; }
  
  public SdtRunRuby? SdtRunRuby { get ; set; }
  
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
  
  public DocumentModel.Math.Paragraph? Paragraph { get ; set; }
  
  public DocumentModel.Math.OfficeMath? OfficeMath { get ; set; }
  
  public DocumentModel.Math.Accent? Accent { get ; set; }
  
  public DocumentModel.Math.Bar? Bar { get ; set; }
  
  public DocumentModel.Math.Box? Box { get ; set; }
  
  public DocumentModel.Math.BorderBox? BorderBox { get ; set; }
  
  public DocumentModel.Math.Delimiter? Delimiter { get ; set; }
  
  public DocumentModel.Math.EquationArray? EquationArray { get ; set; }
  
  public DocumentModel.Math.Fraction? Fraction { get ; set; }
  
  public DocumentModel.Math.MathFunction? MathFunction { get ; set; }
  
  public DocumentModel.Math.GroupChar? GroupChar { get ; set; }
  
  public DocumentModel.Math.LimitLower? LimitLower { get ; set; }
  
  public DocumentModel.Math.LimitUpper? LimitUpper { get ; set; }
  
  public DocumentModel.Math.Matrix? Matrix { get ; set; }
  
  public DocumentModel.Math.Nary? Nary { get ; set; }
  
  public DocumentModel.Math.Phantom? Phantom { get ; set; }
  
  public DocumentModel.Math.Radical? Radical { get ; set; }
  
  public DocumentModel.Math.PreSubSuper? PreSubSuper { get ; set; }
  
  public DocumentModel.Math.Subscript? Subscript { get ; set; }
  
  public DocumentModel.Math.SubSuperscript? SubSuperscript { get ; set; }
  
  public DocumentModel.Math.Superscript? Superscript { get ; set; }
  
}
