namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
public interface BubbleChartSeries2
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
  /// InvertIfNegative.
  /// </summary>
  public Boolean? InvertIfNegative { get ; set; }
  
  public Collection<DataPoint2>? DataPoints { get ; set; }
  
  public DataLabels2? DataLabels { get ; set; }
  
  public Collection<Trendline>? Trendlines { get ; set; }
  
  public Collection<ErrorBars>? ErrorBarses { get ; set; }
  
  public XValues? XValues { get ; set; }
  
  public YValues? YValues { get ; set; }
  
  public BubbleSize? BubbleSize { get ; set; }
  
  public Boolean? Bubble3D { get ; set; }
  
  public BubbleSerExtensionList? BubbleSerExtensionList { get ; set; }
  
}
