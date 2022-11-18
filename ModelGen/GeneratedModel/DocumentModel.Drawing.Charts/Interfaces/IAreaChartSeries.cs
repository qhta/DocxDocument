namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Area Chart Series.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAreaSerExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICategoryAxisData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IErrorBars))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IValues))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureOptions))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITrendline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOrder))]
public interface IAreaChartSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index { get ; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public IOrder? Order { get ; set; }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public ISeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
}
