namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Bar Charts.
/// </summary>
public class BarChart
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
  public Boolean? VaryColors { get; set; }

  public Collection<BarChartSeries>? BarChartSerieses { get; set; }

  public DataLabels? DataLabels { get; set; }

  public UInt16? GapWidth { get; set; }

  public SByte? Overlap { get; set; }

  public Collection<SeriesLines>? SeriesLineses { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public BarChartExtensionList? BarChartExtensionList { get; set; }
}