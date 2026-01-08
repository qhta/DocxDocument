namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a line chart, including index, order, text, shape properties, marker, picture options, data points, labels, trendlines, error bars, axis data, values, smoothing, and extensions.
/// </summary>
public interface LineChartSeries3
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
  ///   Picture options for the series.
  /// </summary>
  public PictureOptions? PictureOptions { get; set; }

  /// <summary>
  ///   Data points contained in the series.
  /// </summary>
  public DataPoints DataPoints { get; set; }

  /// <summary>
  ///   Data labels configuration for the series.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Trendlines associated with the series.
  /// </summary>
  public Trendlines Trendlines { get; set; }

  /// <summary>
  ///   Error bars for the series.
  /// </summary>
  public ErrorBars? ErrorBars { get; set; }

  /// <summary>
  ///   Category axis data for the series.
  /// </summary>
  public CategoryAxisData? CategoryAxisData { get; set; }

  /// <summary>
  ///   Values for the series.
  /// </summary>
  public Values? Values { get; set; }

  /// <summary>
  ///   Indicates whether the line is smoothed.
  /// </summary>
  public bool? Smooth { get; set; }

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  public LineSerExtensionList? LineSerExtensionList { get; set; }
}