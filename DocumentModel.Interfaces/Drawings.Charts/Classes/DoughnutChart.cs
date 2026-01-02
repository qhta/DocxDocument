namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Doughnut Charts.
/// </summary>
public class DoughnutChart: ModelElement
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public Collection<PieChartSeries>? PieChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public UInt16? FirstSliceAngle { get; set; }
  public Byte? HoleSize { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}