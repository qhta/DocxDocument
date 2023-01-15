namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Pie Charts.
/// </summary>
public class PieChart
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<PieChartSeries>? PieChartSerieses { get; set; }

  public DataLabels? DataLabels { get; set; }

  public UInt16? FirstSliceAngle { get; set; }

  public PieChartExtensionList? PieChartExtensionList { get; set; }
}