namespace DocumentModel.Wordprocessing;

/// <summary>
/// Cell-Level Structured Document Tag Content.
/// </summary>
public class SdtContentCellImpl: ModelElementImpl, SdtContentCell
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtContentCell? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentCell?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtContentCellImpl(): base() {}
  
  public SdtContentCellImpl(DocumentFormat.OpenXml.Wordprocessing.SdtContentCell openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<TableCell>? TableCells
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public CustomXmlCell? CustomXmlCell
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public SdtCell? SdtCell
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ProofError? ProofError
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PermStart? PermStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PermEnd? PermEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public BookmarkStart? BookmarkStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupRangeType? BookmarkEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupRangeType? CommentRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupRangeType? CommentRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MoveBookmarkType? MoveFromRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupRangeType? MoveFromRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MoveBookmarkType? MoveToRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupRangeType? MoveToRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TrackChangeType? CustomXmlInsRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupType? CustomXmlInsRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TrackChangeType? CustomXmlDelRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupType? CustomXmlDelRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TrackChangeType? CustomXmlMoveFromRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupType? CustomXmlMoveFromRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TrackChangeType? CustomXmlMoveToRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupType? CustomXmlMoveToRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TrackChangeType? CustomXmlConflictInsertionRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupType? CustomXmlConflictInsertionRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TrackChangeType? CustomXmlConflictDeletionRangeStart
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MarkupType? CustomXmlConflictDeletionRangeEnd
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public InsertedRun? InsertedRun
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DeletedRun? DeletedRun
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MoveFromRun? MoveFromRun
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public MoveToRun? MoveToRun
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public RunConflictInsertion? RunConflictInsertion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public RunConflictDeletion? RunConflictDeletion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
