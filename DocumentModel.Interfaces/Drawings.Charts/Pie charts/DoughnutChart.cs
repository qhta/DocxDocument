namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a doughnut chart, including color variation, series, labels, first slice angle, hole size, and extension list.
/// </summary>
public interface DoughnutChart
{
  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Series displayed in the doughnut chart.
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
  ///   Size of the hole in the center of the doughnut chart.
  /// </summary>
  public Byte? HoleSize { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}