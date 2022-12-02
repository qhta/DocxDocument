namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
public interface IFilteredSurfaceSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  public ISurfaceChartSeries? SurfaceChartSeries { get ; set; }
  
}
