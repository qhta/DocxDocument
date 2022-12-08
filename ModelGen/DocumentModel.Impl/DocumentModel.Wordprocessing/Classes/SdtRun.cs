namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRun Class.
/// </summary>
public class SdtRunImpl: DocumentModel.Wordprocessing.SdtElementImpl, SdtRun
{
  public new DocumentFormat.OpenXml.Wordprocessing.SdtRun? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtRun?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Inline-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentRun? SdtContentRun
  {
    get;
    set;
  }
  
  public override SdtProperties? SdtProperties
  {
    get;
    set;
  }
  
  public override SdtEndCharProperties? SdtEndCharProperties
  {
    get;
    set;
  }
  
  public Collection<BookmarkStart>? BookmarkStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? BookmarkEnds
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? CommentRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? CommentRangeEnds
  {
    get;
    set;
  }
  
  public Collection<MoveBookmarkType>? MoveFromRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? MoveFromRangeEnds
  {
    get;
    set;
  }
  
  public Collection<MoveBookmarkType>? MoveToRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupRangeType>? MoveToRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlInsRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlInsRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlDelRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlDelRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlMoveFromRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlMoveFromRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlMoveToRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlMoveToRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlConflictInsertionRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlConflictInsertionRangeEnds
  {
    get;
    set;
  }
  
  public Collection<TrackChangeType>? CustomXmlConflictDeletionRangeStarts
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CustomXmlConflictDeletionRangeEnds
  {
    get;
    set;
  }
  
}
