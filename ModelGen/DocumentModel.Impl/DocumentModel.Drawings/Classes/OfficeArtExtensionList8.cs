namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeArtExtensionList Class.
/// </summary>
public class OfficeArtExtensionList8Impl: ModelElementImpl, OfficeArtExtensionList8
{
  public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.OfficeArtExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Extension>? Extensions
  {
    get;
    set;
  }
  
}
