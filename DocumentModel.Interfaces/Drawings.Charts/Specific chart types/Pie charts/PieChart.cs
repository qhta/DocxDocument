namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a pie chart, including color variation, series, labels, first slice angle, and extension list.
/// </summary>
public interface PieChart
{
  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Series displayed in the pie chart.
  /// </summary>
  public PieChartSeriesList PieChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Angle of the first slice in the chart.
  /// </summary>
  public UInt16? FirstSliceAngle { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public PieChartExtensionList? PieChartExtensionList { get; set; }
}