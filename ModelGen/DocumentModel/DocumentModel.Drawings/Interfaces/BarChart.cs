namespace DocumentModel.Drawings;

/// <summary>
/// Bar Charts.
/// </summary>
public interface BarChart
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public BarDirectionKind? BarDirection { get ; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public BarGroupingKind? BarGrouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<BarChartSeries2>? BarChartSerieses { get ; set; }
  
  public DataLabels2? DataLabels { get ; set; }
  
  public UInt16? GapWidth { get ; set; }
  
  public SByte? Overlap { get ; set; }
  
  public Collection<SeriesLines>? SeriesLineses { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public BarChartExtensionList? BarChartExtensionList { get ; set; }
  
}
