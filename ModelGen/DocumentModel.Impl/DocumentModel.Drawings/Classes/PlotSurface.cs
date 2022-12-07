namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotSurface Class.
/// </summary>
public class PlotSurfaceImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface>, PlotSurface
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
