namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a 3D pie chart, including color variation, series, labels, and extension list.
/// </summary>
public interface Pie3DChart
{
  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Series displayed in the 3D pie chart.
  /// </summary>
  public PieChartSeriesList PieChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public Pie3DChartExtensionList? Pie3DChartExtensionList { get; set; }
}