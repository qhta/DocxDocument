namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Pie Charts.
/// </summary>
public class PieChart: ModelElement
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<PieChartSeries>? PieChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public UInt16? FirstSliceAngle { get; set; }

  public PieChartExtensionList? PieChartExtensionList { get; set; }
}