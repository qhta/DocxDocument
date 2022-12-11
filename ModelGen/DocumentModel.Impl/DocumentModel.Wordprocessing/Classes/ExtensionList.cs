namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public class ExtensionListImpl: ModelElementImpl, ExtensionList
{
  public DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtensionListImpl(): base() {}
  
  public ExtensionListImpl(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Extension>? Extensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
