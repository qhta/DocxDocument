namespace DocumentModel.Drawings;

/// <summary>
/// Area Charts.
/// </summary>
public interface AreaChart
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public GroupingKind? Grouping { get ; set; }
  
  public DataLabels1? DataLabels { get ; set; }
  
  public DropLines? DropLines { get ; set; }
  
  public AreaChartExtensionList? AreaChartExtensionList { get ; set; }
  
}
