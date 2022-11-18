namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IXValues))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISmooth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IErrorBars))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMarker))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IYValues))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IScatterSerExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITrendline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOrder))]
public interface IScatterChartSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  /// Marker.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMarker? Marker { get ; set; }
  
}
