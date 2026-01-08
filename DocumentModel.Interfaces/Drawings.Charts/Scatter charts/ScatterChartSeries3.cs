namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartSeries Class.
/// </summary>
public interface ScatterChartSeries3
{
  /// <summary>
  ///   Index.
  /// </summary>
  public UInt32? Index { get; set; }
  /// <summary>
  ///   Order.
  /// </summary>
  public UInt32? Order { get; set; }
  /// <summary>
  ///   Series Text.
  /// </summary>
  public SeriesText? SeriesText { get; set; }
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }
  /// <summary>
  ///   Marker.
  /// </summary>
  public Marker? Marker { get; set; }
  public DataPoints DataPoints { get; set; }
  public DataLabels? DataLabels { get; set; }
  public Trendlines Trendlines { get; set; }
  public ErrorBars ErrorBars { get; set; }
  public XValues? XValues { get; set; }
  public YValues? YValues { get; set; }
  public bool? Smooth { get; set; }
  public ScatterSerExtensionList? ScatterSerExtensionList { get; set; }
}