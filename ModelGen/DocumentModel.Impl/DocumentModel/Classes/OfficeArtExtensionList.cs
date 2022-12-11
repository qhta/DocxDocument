namespace DocumentModel;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionListImpl: ModelElementImpl, OfficeArtExtensionList
{
  public DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OfficeArtExtensionListImpl(): base() {}
  
  public OfficeArtExtensionListImpl(DocumentFormat.OpenXml.Office2013.Theme.OfficeArtExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Extension>? Extensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
