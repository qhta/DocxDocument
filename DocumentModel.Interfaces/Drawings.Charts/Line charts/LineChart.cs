namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a line chart, including grouping, color variation, series, labels, drop lines, high-low lines, up-down bars, marker and smoothing options, axis identifiers, and extension list.
/// </summary>
public interface LineChart
{
  /// <summary>
  ///   Specifies the grouping type for the line chart.
  /// </summary>
  public GroupingKind? Grouping { get; set; }

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Series displayed in the line chart.
  /// </summary>
  public LineChartSeriesList LineChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Drop lines configuration for the chart.
  /// </summary>
  public DropLines? DropLines { get; set; }

  /// <summary>
  ///   High-low lines configuration for the chart.
  /// </summary>
  public HighLowLines? HighLowLines { get; set; }

  /// <summary>
  ///   Up-down bars configuration for the chart.
  /// </summary>
  public UpDownBars? UpDownBars { get; set; }

  /// <summary>
  ///   Indicates whether markers are shown for data points.
  /// </summary>
  public bool? ShowMarker { get; set; }

  /// <summary>
  ///   Indicates whether the lines are smoothed.
  /// </summary>
  public bool? Smooth { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public LineChartExtensionList? LineChartExtensionList { get; set; }
}