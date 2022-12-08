namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceSerExtensionList Class.
/// </summary>
public class SurfaceSerExtensionListImpl: ModelElementImpl, SurfaceSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<SurfaceSerExtension>? SurfaceSerExtensions
  {
    get;
    set;
  }
  
}
