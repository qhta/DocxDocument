namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public class CommentsImpl: ModelElementImpl, Comments
{
  public DocumentFormat.OpenXml.Wordprocessing.Comments? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Comments?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Comment>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
