namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Radar Charts.
/// </summary>
public partial class RadarChart
{
  
  /// <summary>
  ///   RadarStyle.
  /// </summary>
  public DocumentModel.Drawings.Charts.RadarStyleKind? RadarStyle { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.RadarChartExtensionList? RadarChartExtensionList { get; set; }
  
}
