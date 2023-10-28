namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Line Charts.
/// </summary>
public partial class LineChart
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
  
  public DMDC.HighLowLines? HighLowLines { get; set; }
  
  public DMDC.UpDownBars? UpDownBars { get; set; }
  
  public DMDC.ShowMarker? ShowMarker { get; set; }
  
  public DMDC.Smooth? Smooth { get; set; }
  
  public DMDC.LineChartExtensionList? LineChartExtensionList { get; set; }
  
}
