namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RadarChartSeries Class.
/// </summary>
public interface RadarChartSeries1
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
  public SeriesText? SeriesText { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get ; set; }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public Marker1? Marker { get ; set; }
  
  public Collection<DataPoint2>? DataPoints { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public CategoryAxisData? CategoryAxisData { get ; set; }
  
  public Values? Values { get ; set; }
  
  public RadarSerExtensionList? RadarSerExtensionList { get ; set; }
  
}
