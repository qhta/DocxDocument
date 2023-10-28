namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Area Charts.
/// </summary>
public partial class AreaChart
{
  
  /// <summary>
  ///   Grouping.
  /// </summary>
  public DMDC.GroupingKind? Grouping { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.DropLines? DropLines { get; set; }
  
  public DMDC.AreaChartExtensionList? AreaChartExtensionList { get; set; }
  
}
