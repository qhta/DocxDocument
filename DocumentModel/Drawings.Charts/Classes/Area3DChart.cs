namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   3D Area Charts.
/// </summary>
public class Area3DChart: ModelElement
{
  /// <summary>
  ///   Grouping.
  /// </summary>
  public GroupingKind? Grouping { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<AreaChartSeries>? AreaChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public DropLines? DropLines { get; set; }

  public UInt16? GapDepth { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public Area3DChartExtensionList? Area3DChartExtensionList { get; set; }
}