namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public class SurfaceChartExtensionImpl: ModelElementImpl, SurfaceChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SurfaceChartExtensionImpl(): base() {}
  
  public SurfaceChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings13.Charts.FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
