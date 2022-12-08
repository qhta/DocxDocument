namespace DocumentModel.Drawings;

/// <summary>
/// 3D Area Charts.
/// </summary>
public interface Area3DChart
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
  
  public UInt16? GapDepth { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public Area3DChartExtensionList? Area3DChartExtensionList { get ; set; }
  
}
