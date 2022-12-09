namespace DocumentModel.Drawings;

/// <summary>
/// Bar Chart Series.
/// </summary>
public interface BarChartSeries2
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
  /// InvertIfNegative.
  /// </summary>
  public Boolean? InvertIfNegative { get ; set; }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get ; set; }
  
  public Collection<DataPoint2>? DataPoints { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public Collection<Trendline>? Trendlines { get ; set; }
  
  public ErrorBars? ErrorBars { get ; set; }
  
  public CategoryAxisData? CategoryAxisData { get ; set; }
  
  public Values? Values { get ; set; }
  
  public ShapeKind1? Shape { get ; set; }
  
  public BarSerExtensionList? BarSerExtensionList { get ; set; }
  
}
