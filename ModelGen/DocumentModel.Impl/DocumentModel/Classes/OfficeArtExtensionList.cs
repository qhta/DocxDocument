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
  
  public Collection<DocumentModel.Drawings.Extension>? Extensions
  {
    get;
    set;
  }
  
}
