namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ISurfaceChartSeries))]
public interface IFilteredSurfaceSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.ISurfaceChartSeries? SurfaceChartSeries { get ; set; }
  
}
