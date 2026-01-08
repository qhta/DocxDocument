namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Area Charts.
/// </summary>
public interface AreaChart
{
  /// <summary>
  ///   Grouping.
  /// </summary>
  public GroupingKind? Grouping { get; set; }
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public AreaChartSeries AreaChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public DropLines? DropLines { get; set; }
  public AxisIds AxisIds { get; set; }
  public AreaChartExtensionList? AreaChartExtensionList { get; set; }
}