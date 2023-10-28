namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Scatter Charts.
/// </summary>
public partial class ScatterChart
{
  
  /// <summary>
  ///   ScatterStyle.
  /// </summary>
  public DMDC.ScatterStyleKind? ScatterStyle { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.ScatterChartExtensionList? ScatterChartExtensionList { get; set; }
  
}
