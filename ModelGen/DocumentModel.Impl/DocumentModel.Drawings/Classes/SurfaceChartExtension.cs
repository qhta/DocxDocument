namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public class SurfaceChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension>, SurfaceChartExtension
{
  public FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get;
    set;
  }
  
}
