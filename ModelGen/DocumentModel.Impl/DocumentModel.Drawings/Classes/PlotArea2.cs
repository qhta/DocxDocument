namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public class PlotArea2Impl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea>, PlotArea2
{
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  public PlotAreaRegion? PlotAreaRegion
  {
    get;
    set;
  }
  
  public ShapeProperties2? ShapeProperties
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
