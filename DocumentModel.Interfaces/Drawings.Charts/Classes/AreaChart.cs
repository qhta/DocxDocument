namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Area Charts.
/// </summary>
public class AreaChart: ModelElement
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
  public DataLabels? DataLabels { get; set; }
  public DropLines? DropLines { get; set; }
  public Collection<UInt32>? AxisIds { get; set; }
  public AreaChartExtensionList? AreaChartExtensionList { get; set; }
}