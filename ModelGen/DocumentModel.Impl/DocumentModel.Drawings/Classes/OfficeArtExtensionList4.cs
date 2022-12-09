namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionList4Impl: ModelElementImpl, OfficeArtExtensionList4
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.OfficeArtExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.OfficeArtExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Extension>? Extensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
