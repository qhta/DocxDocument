namespace DocumentModel.Wordprocessing;

/// <summary>
/// Move Source Run Content.
/// </summary>
public interface IMoveFromRun // : DocumentModel.Wordprocessing.IRunTrackChangeType
{
  public DocumentModel.Wordprocessing.ISdtRun? SdtRun { get ; set; }
  
  public DocumentModel.Wordprocessing.IProofError? ProofError { get ; set; }
  
  public DocumentModel.Wordprocessing.IPermStart? PermStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IPermEnd? PermEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IBookmarkStart? BookmarkStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? BookmarkEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? CommentRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? CommentRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveBookmarkType? MoveFromRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? MoveFromRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveBookmarkType? MoveToRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupRangeType? MoveToRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlInsRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlInsRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlDelRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlDelRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlMoveFromRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlMoveFromRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.ITrackChangeType? CustomXmlMoveToRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CustomXmlMoveToRangeEnd { get ; set; }
  
  public DocumentModel.Office2010.Word.ITrackChangeType? CustomXmlConflictInsertionRangeStart { get ; set; }
  
  public DocumentModel.Office2010.Word.IMarkupType? CustomXmlConflictInsertionRangeEnd { get ; set; }
  
  public DocumentModel.Office2010.Word.ITrackChangeType? CustomXmlConflictDeletionRangeStart { get ; set; }
  
  public DocumentModel.Office2010.Word.IMarkupType? CustomXmlConflictDeletionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.IInsertedRun? InsertedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.IDeletedRun? DeletedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveFromRun? MoveFromRun { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveToRun? MoveToRun { get ; set; }
  
  public DocumentModel.Office2010.Word.IRunConflictInsertion? RunConflictInsertion { get ; set; }
  
  public DocumentModel.Office2010.Word.IRunConflictDeletion? RunConflictDeletion { get ; set; }
  
  public DocumentModel.Math.IParagraph? Paragraph { get ; set; }
  
  public DocumentModel.Math.IOfficeMath? OfficeMath { get ; set; }
  
  public DocumentModel.Math.IAccent? Accent { get ; set; }
  
  public DocumentModel.Math.IBar? Bar { get ; set; }
  
  public DocumentModel.Math.IBox? Box { get ; set; }
  
  public DocumentModel.Math.IBorderBox? BorderBox { get ; set; }
  
  public DocumentModel.Math.IDelimiter? Delimiter { get ; set; }
  
  public DocumentModel.Math.IEquationArray? EquationArray { get ; set; }
  
  public DocumentModel.Math.IFraction? Fraction { get ; set; }
  
  public DocumentModel.Math.IMathFunction? MathFunction { get ; set; }
  
  public DocumentModel.Math.IGroupChar? GroupChar { get ; set; }
  
  public DocumentModel.Math.ILimitLower? LimitLower { get ; set; }
  
  public DocumentModel.Math.ILimitUpper? LimitUpper { get ; set; }
  
  public DocumentModel.Math.IMatrix? Matrix { get ; set; }
  
  public DocumentModel.Math.INary? Nary { get ; set; }
  
  public DocumentModel.Math.IPhantom? Phantom { get ; set; }
  
  public DocumentModel.Math.IRadical? Radical { get ; set; }
  
  public DocumentModel.Math.IPreSubSuper? PreSubSuper { get ; set; }
  
  public DocumentModel.Math.ISubscript? Subscript { get ; set; }
  
  public DocumentModel.Math.ISubSuperscript? SubSuperscript { get ; set; }
  
  public DocumentModel.Math.ISuperscript? Superscript { get ; set; }
  
  public DocumentModel.Math.IRun? Run { get ; set; }
  
  public DocumentModel.Wordprocessing.IBidirectionalOverride? BidirectionalOverride { get ; set; }
  
  public DocumentModel.Wordprocessing.IBidirectionalEmbedding? BidirectionalEmbedding { get ; set; }
  
}
