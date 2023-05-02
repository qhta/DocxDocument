namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Pie Charts.
/// </summary>
public class PieChart: ModelElement
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }

  public Collection<PieChartSeries>? PieChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public UInt16? FirstSliceAngle { get; set; }

  public PieChartExtensionList? PieChartExtensionList { get; set; }
}