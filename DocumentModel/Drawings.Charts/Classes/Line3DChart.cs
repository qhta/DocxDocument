namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   3D Line Charts.
/// </summary>
public class Line3DChart: ModelElement
{
  /// <summary>
  ///   Grouping.
  /// </summary>
  public GroupingKind? Grouping { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<LineChartSeries>? LineChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public DropLines? DropLines { get; set; }

  public UInt16? GapDepth { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public Line3DChartExtensionList? Line3DChartExtensionList { get; set; }
}