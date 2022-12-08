namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaChartSeries Class.
/// </summary>
public interface AreaChartSeries1
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
  
  public Collection<DataPoint2>? DataPoints { get ; set; }
  
  public DataLabels2? DataLabels { get ; set; }
  
  public Collection<Trendline>? Trendlines { get ; set; }
  
  public Collection<ErrorBars>? ErrorBarses { get ; set; }
  
  public CategoryAxisData? CategoryAxisData { get ; set; }
  
  public Values? Values { get ; set; }
  
  public AreaSerExtensionList? AreaSerExtensionList { get ; set; }
  
}
