namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceChartExtensionList Class.
/// </summary>
public class SurfaceChartExtensionListImpl: ModelElementImpl, SurfaceChartExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SurfaceChartExtensionListImpl(): base() {}
  
  public SurfaceChartExtensionListImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<SurfaceChartExtension>? SurfaceChartExtensions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
