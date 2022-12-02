namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
public interface IFilteredSurfaceSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  public DocumentModel.Drawing.ISurfaceChartSeries? SurfaceChartSeries { get ; set; }
  
}
