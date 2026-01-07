namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarChartSeries Class.
/// </summary>
public interface BarChartSeries3
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
  ///   InvertIfNegative.
  /// </summary>
  public bool? InvertIfNegative { get; set; }
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }
  public DataPoints? DataPoints { get; set; }
  public DataLabels? DataLabels { get; set; }
  public Trendlines? Trendlines { get; set; }
  public ErrorBar? ErrorBars { get; set; }
  public CategoryAxisData? CategoryAxisData { get; set; }
  public Values? Values { get; set; }
  public ShapeKind? Shape { get; set; }
  public BarSerExtensionList? BarSerExtensionList { get; set; }
}