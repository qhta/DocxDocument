namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a 3D bar chart, including direction, grouping, color variation, series, labels, gap settings, shape, axis identifiers, and extension list.
/// </summary>
public interface Bar3DChart: ChartType
{
  /// <summary>
  ///   Direction of the bars in the chart.
  /// </summary>
  public BarDirectionKind? BarDirection { get; set; }

  /// <summary>
  ///   Grouping type for the bars in the chart.
  /// </summary>
  public BarGroupingKind? BarGrouping { get; set; }

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Collection of bar chart series displayed in the chart.
  /// </summary>
  public BarChartSeriesList? BarChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Width of the gap between bars.
  /// </summary>
  public UInt16? GapWidth { get; set; }

  /// <summary>
  ///   Depth of the gap between bars in 3D.
  /// </summary>
  public UInt16? GapDepth { get; set; }

  /// <summary>
  ///   Shape type for the bars in the chart.
  /// </summary>
  public ShapeKind? Shape { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds? AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public Bar3DChartExtensionList? Bar3DChartExtensionList { get; set; }
}