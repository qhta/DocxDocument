namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IPlotSurface))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ISeries))]
public interface IPlotAreaRegion // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public IPlotSurface? PlotSurface { get ; set; }
  
}
