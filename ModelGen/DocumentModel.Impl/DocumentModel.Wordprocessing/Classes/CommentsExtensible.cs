namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentsExtensible Class.
/// </summary>
public class CommentsExtensibleImpl: ModelElementImpl, CommentsExtensible
{
  public DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentsExtensible?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<CommentExtensible>? CommentExtensibles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
