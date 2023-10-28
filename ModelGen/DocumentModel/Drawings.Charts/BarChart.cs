namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Bar Charts.
/// </summary>
public partial class BarChart
{
  
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  public DMDC.BarDirectionKind? BarDirection { get; set; }
  
  
  /// <summary>
  ///   Bar Grouping.
  /// </summary>
  public DMDC.BarGroupingKind? BarGrouping { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.GapWidth? GapWidth { get; set; }
  
  public SByte? Overlap { get; set; }
  
  public DMDC.BarChartExtensionList? BarChartExtensionList { get; set; }
  
}
