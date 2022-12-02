namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RadarChartSeries Class.
/// </summary>
public interface IRadarChartSeries // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// PictureOptions.
  /// </summary>
  public IPictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public IMarker? Marker { get ; set; }
  
  public Collection<IDataPoint>? DataPoints { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public ICategoryAxisData? CategoryAxisData { get ; set; }
  
  public IValues? Values { get ; set; }
  
  public IRadarSerExtensionList? RadarSerExtensionList { get ; set; }
  
}
