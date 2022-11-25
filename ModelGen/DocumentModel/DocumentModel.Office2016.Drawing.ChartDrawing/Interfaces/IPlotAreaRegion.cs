namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public interface IPlotAreaRegion // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IPlotSurface? PlotSurface { get ; set; }
  
}
