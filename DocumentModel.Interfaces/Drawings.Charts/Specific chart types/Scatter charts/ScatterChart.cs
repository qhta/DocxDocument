namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a scatter chart, including style, color variation, series, labels, axis identifiers, and extension list.
/// </summary>
public interface ScatterChart: ChartType
{
  /// <summary>
  ///   Style of the scatter chart.
  /// </summary>
  public ScatterStyleKind? ScatterStyle { get; set; }

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Series displayed in the scatter chart.
  /// </summary>
  public ScatterChartSeriesList ScatterChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  public AxisIds AxisIds { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public ScatterChartExtensionList? ScatterChartExtensionList { get; set; }
}