namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Radar Charts.
/// </summary>
public partial class RadarChart
{
  
  /// <summary>
  ///   RadarStyle.
  /// </summary>
  public DMDC.RadarStyleKind? RadarStyle { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.DataLabels? DataLabels { get; set; }
  
  public DMDC.RadarChartExtensionList? RadarChartExtensionList { get; set; }
  
}
