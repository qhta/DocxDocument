namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a radar chart, including style, color variation, series, labels, axis identifiers, and extension list.
/// </summary>
public interface RadarChart
{
  /// <summary>
  ///   Style of the radar chart.
  /// </summary>
  public RadarStyleKind? RadarStyle { get; set; }

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Series displayed in the radar chart.
  /// </summary>
  public RadarChartSeriesList RadarChartSeries { get; set; }

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
  public RadarChartExtensionList? RadarChartExtensionList { get; set; }
}