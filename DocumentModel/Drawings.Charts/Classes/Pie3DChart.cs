namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D Pie Charts.
/// </summary>
public class Pie3DChart
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<PieChartSeries>? PieChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Pie3DChartExtensionList? Pie3DChartExtensionList { get; set; }
}