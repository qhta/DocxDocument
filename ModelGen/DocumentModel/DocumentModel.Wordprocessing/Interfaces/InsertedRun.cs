namespace DocumentModel.Wordprocessing;

/// <summary>
/// Inserted Run Content.
/// </summary>
public interface InsertedRun
{
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
  
  public DocumentModel.Wordprocessing.TrackChangeType2? CustomXmlConflictInsertionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType2? CustomXmlConflictInsertionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType2? CustomXmlConflictDeletionRangeStart { get ; set; }
  
  public DocumentModel.Wordprocessing.MarkupType2? CustomXmlConflictDeletionRangeEnd { get ; set; }
  
  public DocumentModel.Wordprocessing.InsertedRun? ChildInsertedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.DeletedRun? DeletedRun { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveFromRun? MoveFromRun { get ; set; }
  
  public DocumentModel.Wordprocessing.MoveToRun? MoveToRun { get ; set; }
  
  public DocumentModel.Wordprocessing.RunConflictInsertion? RunConflictInsertion { get ; set; }
  
  public DocumentModel.Wordprocessing.RunConflictDeletion? RunConflictDeletion { get ; set; }
  
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
  
  public DocumentModel.Math.Run? Run { get ; set; }
  
  public DocumentModel.Wordprocessing.BidirectionalOverride? BidirectionalOverride { get ; set; }
  
  public DocumentModel.Wordprocessing.BidirectionalEmbedding? BidirectionalEmbedding { get ; set; }
  
}
