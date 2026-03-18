namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an area chart, including grouping, color variation, series, labels, drop lines, axis identifiers, and extension list.
/// </summary>
public class AreaChart : ModelElement<DXDC.AreaChart>
{
  /// <summary>
  ///   Specifies the grouping type for the area chart.
  /// </summary>
  public Grouping? Grouping { get; set; }

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Area chart series displayed in the chart.
  /// </summary>
  public AreaChartSeriesList? AreaChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Drop lines configuration for the chart.
  /// </summary>
  public DropLines? DropLines { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds? AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public AreaChartExtension? AreaChartExtension { get; set; }
}