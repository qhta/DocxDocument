namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   3D Pie Charts.
/// </summary>
public class Pie3DChart: ModelElement
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<PieChartSeries>? PieChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public Pie3DChartExtensionList? Pie3DChartExtensionList { get; set; }
}