namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsIds Class.
/// </summary>
public class CommentsIdsImpl: ModelElementImpl, CommentsIds
{
  public DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentsIdsImpl(): base() {}
  
  public CommentsIdsImpl(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentsIds openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<CommentId>? CommentIds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
