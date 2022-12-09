namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
