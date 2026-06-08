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
  public bool? VaryColors { get; set; }

  public Collection<AreaChartSeries>? AreaChartSeries { get; set; }

  public IDataLabels? IDataLabels { get; set; }

  public IDropLines? IDropLines { get; set; }

  public UInt16? GapDepth { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public Area3DChartExtensionList? Area3DChartExtensionList { get; set; }
}
