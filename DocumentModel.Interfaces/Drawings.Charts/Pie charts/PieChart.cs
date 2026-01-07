namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Pie Charts.
/// </summary>
public interface PieChart
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public PieChartSeries PieChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public UInt16? FirstSliceAngle { get; set; }
  public PieChartExtensionList? PieChartExtensionList { get; set; }
}