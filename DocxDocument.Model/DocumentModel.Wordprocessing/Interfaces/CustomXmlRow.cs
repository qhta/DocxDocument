namespace DocumentModel.Wordprocessing;

/// <summary>
/// Row-Level Custom XML Element.
/// </summary>
public partial interface CustomXmlRow
{
  public DocumentModel.Wordprocessing.CustomXmlProperties? CustomXmlProperties { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.TableRow>? TableRows { get; set; }
  
  public DocumentModel.Wordprocessing.CustomXmlRow? ChildCustomXmlRow { get; set; }
  
  public DocumentModel.Wordprocessing.SdtRow? SdtRow { get; set; }
  
  public DocumentModel.Wordprocessing.ProofError? ProofError { get; set; }
  
  public DocumentModel.Wordprocessing.PermStart? PermStart { get; set; }
  
  public DocumentModel.Wordprocessing.PermEnd? PermEnd { get; set; }
  
  public DocumentModel.Wordprocessing.BookmarkStart? BookmarkStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? BookmarkEnd { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveFromRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveFromRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.MoveBookmarkType? MoveToRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? MoveToRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlInsRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlInsRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlDelRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlDelRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveFromRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveFromRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType? CustomXmlMoveToRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CustomXmlMoveToRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType2? CustomXmlConflictInsertionRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType2? CustomXmlConflictInsertionRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.TrackChangeType2? CustomXmlConflictDeletionRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType2? CustomXmlConflictDeletionRangeEnd { get; set; }
  
  public DocumentModel.Wordprocessing.InsertedRun? InsertedRun { get; set; }
  
  public DocumentModel.Wordprocessing.DeletedRun? DeletedRun { get; set; }
  
  public DocumentModel.Wordprocessing.MoveFromRun? MoveFromRun { get; set; }
  
  public DocumentModel.Wordprocessing.MoveToRun? MoveToRun { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.ContentPart>? ContentParts { get; set; }
  
  public DocumentModel.Wordprocessing.RunConflictInsertion? RunConflictInsertion { get; set; }
  
  public DocumentModel.Wordprocessing.RunConflictDeletion? RunConflictDeletion { get; set; }
  
}
