namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Doughnut Charts.
/// </summary>
public class DoughnutChart: ModelElement
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<PieChartSeries>? PieChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public UInt16? FirstSliceAngle { get; set; }

  public Byte? HoleSize { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}