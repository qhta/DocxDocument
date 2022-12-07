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
  
  public DataLabels1? DataLabels { get ; set; }
  
  public BarChartExtensionList? BarChartExtensionList { get ; set; }
  
}
