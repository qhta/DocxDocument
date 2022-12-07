namespace DocumentModel.Drawings;

/// <summary>
/// Line Charts.
/// </summary>
public interface LineChart
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public GroupingKind? Grouping { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public DropLines? DropLines { get ; set; }
  
  public HighLowLines? HighLowLines { get ; set; }
  
  public UpDownBars? UpDownBars { get ; set; }
  
  public LineChartExtensionList? LineChartExtensionList { get ; set; }
  
}
