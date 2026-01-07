namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Bar Charts.
/// </summary>
public interface BarChart
{
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  public BarDirectionKind? BarDirection { get; set; }
  /// <summary>
  ///   Bar Grouping.
  /// </summary>
  public BarGroupingKind? BarGrouping { get; set; }
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }
  public BarChartSeriesList? BarChartSeries { get; set; }
  public DataLabels? DataLabels { get; set; }
  public UInt16? GapWidth { get; set; }
  public SByte? Overlap { get; set; }
  public SeriesLines? SeriesLines { get; set; }
  public AxisIds? AxisIds { get; set; }
  public BarChartExtensionList? BarChartExtensionList { get; set; }
}