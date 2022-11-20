namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IXValues))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IInvertIfNegative))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubble3D))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubbleSerExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IErrorBars))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IYValues))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBubbleSize))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureOptions))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITrendline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOrder))]
public class BubbleChartSeries: IBubbleChartSeries
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  public IOrder? Order
  {
    get;
    set;
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public ISeriesText? SeriesText
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions
  {
    get;
    set;
  }
  
  /// <summary>
  /// InvertIfNegative.
  /// </summary>
  public IInvertIfNegative? InvertIfNegative
  {
    get;
    set;
  }
  
}
