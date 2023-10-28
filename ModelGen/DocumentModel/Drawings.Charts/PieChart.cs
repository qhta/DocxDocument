namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pie Charts.
/// </summary>
public partial class PieChart
{
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public UInt16? FirstSliceAngle { get; set; }
  
  public DMDC.PieChartExtensionList? PieChartExtensionList { get; set; }
  
}
