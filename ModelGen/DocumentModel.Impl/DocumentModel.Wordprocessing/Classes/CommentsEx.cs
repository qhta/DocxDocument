namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsEx Class.
/// </summary>
public class CommentsExImpl: ModelElementImpl, CommentsEx
{
  public DocumentFormat.OpenXml.Office2013.Word.CommentsEx? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.CommentsEx?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentsExImpl(): base() {}
  
  public CommentsExImpl(DocumentFormat.OpenXml.Office2013.Word.CommentsEx openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<CommentEx>? CommentExs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
