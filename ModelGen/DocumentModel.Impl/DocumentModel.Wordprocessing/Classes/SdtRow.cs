namespace DocumentModel.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public class SdtRowImpl: DocumentModel.Wordprocessing.SdtElementImpl, SdtRow
{
  public new DocumentFormat.OpenXml.Wordprocessing.SdtRow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtRow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Row-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentRow? SdtContentRow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override SdtProperties? SdtProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override SdtEndCharProperties? SdtEndCharProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<BookmarkStart>? BookmarkStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupRangeType>? BookmarkEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupRangeType>? CommentRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupRangeType>? CommentRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MoveBookmarkType>? MoveFromRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupRangeType>? MoveFromRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MoveBookmarkType>? MoveToRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupRangeType>? MoveToRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TrackChangeType>? CustomXmlInsRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupType>? CustomXmlInsRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TrackChangeType>? CustomXmlDelRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupType>? CustomXmlDelRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TrackChangeType>? CustomXmlMoveFromRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupType>? CustomXmlMoveFromRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TrackChangeType>? CustomXmlMoveToRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupType>? CustomXmlMoveToRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TrackChangeType>? CustomXmlConflictInsertionRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupType>? CustomXmlConflictInsertionRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<TrackChangeType>? CustomXmlConflictDeletionRangeStarts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<MarkupType>? CustomXmlConflictDeletionRangeEnds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
