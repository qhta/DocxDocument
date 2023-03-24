namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Bar Charts.
/// </summary>
public class BarChart: ModelElement
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

  public Collection<BarChartSeries>? BarChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public UInt16? GapWidth { get; set; }

  public SByte? Overlap { get; set; }

  public Collection<SeriesLines>? SeriesLines { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public BarChartExtensionList? BarChartExtensionList { get; set; }
}