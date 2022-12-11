namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionListImpl: ModelElementImpl, OfficeArtExtensionList
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OfficeArtExtensionListImpl(): base() {}
  
  public OfficeArtExtensionListImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Extension>? Extensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
