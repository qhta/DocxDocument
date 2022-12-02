namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineChartSeries Class.
/// </summary>
public interface ILineChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Order.
  /// </summary>
  public UInt32? Order { get ; set; }
  
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
  public IMarker? Marker { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  public Collection<IDataPoint>? DataPoints { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public Collection<ITrendline>? Trendlines { get ; set; }
  
  public IErrorBars? ErrorBars { get ; set; }
  
  public ICategoryAxisData? CategoryAxisData { get ; set; }
  
  public IValues? Values { get ; set; }
  
  public Boolean? Smooth { get ; set; }
  
  public ILineSerExtensionList? LineSerExtensionList { get ; set; }
  
}
