namespace DocumentModel.Math;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public interface IParagraph // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Office Math Paragraph Properties.
  /// </summary>
  public IParagraphProperties? ParagraphProperties { get ; set; }
  
  public Collection<IOfficeMath>? OfficeMaths { get ; set; }
  
  public Collection<IRun>? Runs { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IProofError>? ProofErrors { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IPermStart>? PermStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IPermEnd>? PermEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IBookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? CommentRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMoveBookmarkType>? MoveFromRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? MoveFromRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMoveBookmarkType>? MoveToRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupRangeType>? MoveToRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlInsRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlInsRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlDelRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlDelRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlMoveFromRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlMoveFromRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlMoveToRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlMoveToRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlConflictInsertionRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlConflictInsertionRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITrackChangeType>? CustomXmlConflictDeletionRangeStarts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CustomXmlConflictDeletionRangeEnds { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IInsertedRun>? InsertedRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IDeletedRun>? DeletedRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMoveFromRun>? MoveFromRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMoveToRun>? MoveToRuns { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IRunConflictInsertion>? RunConflictInsertions { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IRunConflictDeletion>? RunConflictDeletions { get ; set; }
  
}
