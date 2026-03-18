namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a scatter chart, including index, order, text, shape properties, marker, data points, labels, Trendline, error bars, X and Y values, smoothing, and extensions.
/// </summary>
public class ScatterChartSeries : CollectionItem
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  public UInt32? Order { get; set; }

  /// <summary>
  ///   Text or name of the series.
  /// </summary>
  public SeriesText? SeriesText { get; set; }

  /// <summary>
  ///   Shape properties for the chart series.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Marker configuration for the series.
  /// </summary>
  public Marker? Marker { get; set; }

  /// <summary>
  ///   Data points contained in the series.
  /// </summary>
  public DataPoints? DataPoints { get; set; }

  /// <summary>
  ///   Data labels configuration for the series.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Trendline associated with the series.
  /// </summary>
  public Trendline? Trendline { get; set; }

  /// <summary>
  ///   Error bars for the series.
  /// </summary>
  public ErrorBars? ErrorBars { get; set; }

  /// <summary>
  ///   X values for the series.
  /// </summary>
  public XValues? XValues { get; set; }

  /// <summary>
  ///   Y values for the series.
  /// </summary>
  public YValues? YValues { get; set; }

  /// <summary>
  ///   Indicates whether the line is smoothed.
  /// </summary>
  public bool? Smooth { get; set; }

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  public ScatterSerExtensionList? ScatterSerExtensionList { get; set; }
}