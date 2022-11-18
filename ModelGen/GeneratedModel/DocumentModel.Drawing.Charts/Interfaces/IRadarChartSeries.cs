namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the RadarChartSeries Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICategoryAxisData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabels))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMarker))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IValues))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPictureOptions))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRadarSerExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISeriesText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IOrder))]
public interface IRadarChartSeries // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMarker? Marker { get ; set; }
  
}
