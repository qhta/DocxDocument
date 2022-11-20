namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Chart Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IChartTitle))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ILegend))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IPlotArea))]
public class Chart: IChart
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public IChartTitle? ChartTitle
  {
    get;
    set;
  }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IPlotArea? PlotArea
  {
    get;
    set;
  }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ILegend? Legend
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
