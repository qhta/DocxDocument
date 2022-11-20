namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Plot data and formatting.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IArea3DChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAreaChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBar3DChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBarChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubbleChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICategoryAxis))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDateAxis))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDoughnutChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataTable))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILayout))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILine3DChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILineChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOfPieChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPie3DChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPieChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRadarChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IScatterChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesAxis))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStockChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISurface3DChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISurfaceChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IValueAxis))]
public class PlotArea: IPlotArea
{
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawing.Charts.ILayout? Layout
  {
    get;
    set;
  }
  
}
