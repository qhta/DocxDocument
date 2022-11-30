namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CustomXmlBlock Class.
/// </summary>
public interface ICustomXmlBlock // : DocumentModel.Wordprocessing.ICustomXmlElement
{
  public DocumentModel.Wordprocessing.ICustomXmlProperties? CustomXmlProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.ICustomXmlBlock? CustomXmlBlock { get ; set; }
  
  public DocumentModel.Wordprocessing.ISdtBlock? SdtBlock { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IParagraph>? Paragraphs { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ITable>? Tables { get ; set; }
  
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
  
}
