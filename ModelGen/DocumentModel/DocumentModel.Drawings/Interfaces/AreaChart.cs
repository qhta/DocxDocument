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
  
  public Collection<AreaChartSeries>? AreaChartSerieses { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public DropLines? DropLines { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public AreaChartExtensionList? AreaChartExtensionList { get ; set; }
  
}
