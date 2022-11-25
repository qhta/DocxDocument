namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
public interface IFilteredSurfaceSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.ISurfaceChartSeries? SurfaceChartSeries { get ; set; }
  
}
