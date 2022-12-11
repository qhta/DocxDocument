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
  
  public SurfaceSerExtensionListImpl(): base() {}
  
  public SurfaceSerExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<SurfaceSerExtension>? SurfaceSerExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
