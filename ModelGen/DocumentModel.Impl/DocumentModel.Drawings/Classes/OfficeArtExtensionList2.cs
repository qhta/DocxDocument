namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionList2Impl: ModelElementImpl, OfficeArtExtensionList2
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Extension>? Extensions
  {
    get;
    set;
  }
  
}
