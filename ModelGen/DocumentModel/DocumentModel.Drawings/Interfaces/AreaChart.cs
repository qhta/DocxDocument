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
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<AreaChartSeries2>? AreaChartSerieses { get ; set; }
  
  public DataLabels2? DataLabels { get ; set; }
  
  public DropLines? DropLines { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public AreaChartExtensionList? AreaChartExtensionList { get ; set; }
  
}
