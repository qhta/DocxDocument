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
  
  public Collection<CommentId>? CommentIds
  {
    get;
    set;
  }
  
}
