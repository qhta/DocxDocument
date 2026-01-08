namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a 3D Area Chart, including grouping, color variation, series, labels, drop lines, gap depth, axis identifiers, and extension list.
/// </summary>
public interface Area3DChart
{
  /// <summary>
  ///   Specifies the grouping type for the 3D area chart.
  /// </summary>
  public GroupingKind? Grouping { get; set; }

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Collection of area chart series displayed in the chart.
  /// </summary>
  public AreaChartSeries AreaChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Drop lines configuration for the chart.
  /// </summary>
  public DropLines? DropLines { get; set; }

  /// <summary>
  ///   Gap depth value for the 3D area chart.
  /// </summary>
  public UInt16? GapDepth { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public Area3DChartExtensionList? Area3DChartExtensionList { get; set; }
}