namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a bar chart, including direction, grouping, color variation, series, labels, gap settings, overlap, series lines, axis identifiers, and extension list.
/// </summary>
public class BarChart : ModelElement<DXDC.BarChart>, IChart
{
  /// <summary>
  ///   Direction of the bars in the chart.
  /// </summary>
  public BarDirection? BarDirection { get; set; }

  /// <summary>
  ///   Grouping type for the bars in the chart.
  /// </summary>
  public BarGrouping? BarGrouping { get; set; }

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
  ///   Overlap value for the bars in the chart.
  /// </summary>
  public SByte? Overlap { get; set; }

  /// <summary>
  ///   Series lines configuration for the chart.
  /// </summary>
  public SeriesLinesList? SeriesLines { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds? AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public BarChartExtensionList? BarChartExtensionList { get; set; }
}