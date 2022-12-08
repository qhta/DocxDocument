namespace DocumentModel.Math;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public class ParagraphImpl: ModelElementImpl, Paragraph
{
  public DocumentFormat.OpenXml.Math.Paragraph? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Paragraph?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Office Math Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties
  {
    get;
    set;
  }
  
  public Collection<OfficeMath>? OfficeMaths
  {
    get;
    set;
  }
  
  public Collection<Run>? Runs
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.ProofError>? ProofErrors
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.PermStart>? PermStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.PermEnd>? PermEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.BookmarkStart>? BookmarkStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? BookmarkEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? CommentRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? CommentRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MoveBookmarkType>? MoveFromRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? MoveFromRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MoveBookmarkType>? MoveToRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupRangeType>? MoveToRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlInsRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlInsRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlDelRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlDelRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlMoveFromRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlMoveFromRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlMoveToRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlMoveToRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlConflictInsertionRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlConflictInsertionRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.TrackChangeType>? CustomXmlConflictDeletionRangeStarts
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CustomXmlConflictDeletionRangeEnds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.InsertedRun>? InsertedRuns
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.DeletedRun>? DeletedRuns
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MoveFromRun>? MoveFromRuns
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.MoveToRun>? MoveToRuns
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.RunConflictInsertion>? RunConflictInsertions
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Wordprocessing.RunConflictDeletion>? RunConflictDeletions
  {
    get;
    set;
  }
  
}
