namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Bar Charts.
/// </summary>
public partial class BarChart
{
  
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarDirectionKind? BarDirection { get; set; }
  
  
  /// <summary>
  ///   Bar Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarGroupingKind? BarGrouping { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.GapWidth? GapWidth { get; set; }
  
  public SByte? Overlap { get; set; }
  
  public DocumentModel.Drawings.Charts.BarChartExtensionList? BarChartExtensionList { get; set; }
  
}
