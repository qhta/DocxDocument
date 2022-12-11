namespace DocumentModel.Math;

/// <summary>
/// Lower limit (n-ary) .
/// </summary>
public interface SubArgument
{
  public ArgumentProperties? ArgumentProperties { get ; set; }
  
  public Accent? Accent { get ; set; }
  
  public Bar? Bar { get ; set; }
  
  public Box? Box { get ; set; }
  
  public BorderBox? BorderBox { get ; set; }
  
  public Delimiter? Delimiter { get ; set; }
  
  public EquationArray? EquationArray { get ; set; }
  
  public Fraction? Fraction { get ; set; }
  
  public MathFunction? MathFunction { get ; set; }
  
  public GroupChar? GroupChar { get ; set; }
  
  public LimitLower? LimitLower { get ; set; }
  
  public LimitUpper? LimitUpper { get ; set; }
  
  public Matrix? Matrix { get ; set; }
  
  public Nary? Nary { get ; set; }
  
  public Phantom? Phantom { get ; set; }
  
  public Radical? Radical { get ; set; }
  
  public PreSubSuper? PreSubSuper { get ; set; }
  
  public Subscript? Subscript { get ; set; }
  
  public SubSuperscript? SubSuperscript { get ; set; }
  
  public Superscript? Superscript { get ; set; }
  
  public Run? Run { get ; set; }
  
  public DocumentModel.Wordprocessing.CustomXmlRun? CustomXmlRun { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.SimpleField>? SimpleFields { get ; set; }
  
  public DocumentModel.Wordprocessing.Hyperlink? Hyperlink { get ; set; }
  
  public DocumentModel.Wordprocessing.SdtRun? SdtRun { get ; set; }
  
  public DocumentModel.Wordprocessing.ProofError? ProofError { get ; set; }
  
  public DocumentModel.Wordprocessing.PermStart? PermStart { get ; set; }
  
  public DocumentModel.Wordprocessing.PermEnd? PermEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.BookmarkStart? BookmarkStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? BookmarkEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveFromRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveFromRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveToRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveToRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlInsRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlInsRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlDelRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlDelRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveFromRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveFromRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveToRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveToRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlConflictInsertionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlConflictInsertionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlConflictDeletionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlConflictDeletionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.InsertedRun? InsertedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.DeletedRun? DeletedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveFromRun? MoveFromRun { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveToRun? MoveToRun { get ; set; }
  
  public DocumentModel.Wordprocessing.RunConflictInsertion? RunConflictInsertion { get ; set; }
  
  public DocumentModel.Wordprocessing.RunConflictDeletion? RunConflictDeletion { get ; set; }
  
  public Paragraph? Paragraph { get ; set; }
  
  public OfficeMath? OfficeMath { get ; set; }
  
  public ControlProperties? ControlProperties { get ; set; }
  
}
