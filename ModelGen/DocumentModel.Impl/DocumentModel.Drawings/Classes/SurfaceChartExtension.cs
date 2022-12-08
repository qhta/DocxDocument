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
    get;
    set;
  }
  
  public FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get;
    set;
  }
  
}
