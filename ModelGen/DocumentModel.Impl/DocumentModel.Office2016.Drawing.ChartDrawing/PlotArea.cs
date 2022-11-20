namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IAxis))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IPlotAreaRegion))]
public class PlotArea: IPlotArea
{
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  public IPlotAreaRegion? PlotAreaRegion
  {
    get;
    set;
  }
  
}
