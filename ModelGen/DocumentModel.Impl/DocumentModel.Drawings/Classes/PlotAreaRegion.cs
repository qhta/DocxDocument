namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public class PlotAreaRegionImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion>, PlotAreaRegion
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface
  {
    get;
    set;
  }
  
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
