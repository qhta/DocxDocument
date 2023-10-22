namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Line Charts.
/// </summary>
public partial class LineChart
{
  
  /// <summary>
  ///   Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.GroupingKind? Grouping { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines { get; set; }
  
  public DocumentModel.Drawings.Charts.HighLowLines? HighLowLines { get; set; }
  
  public DocumentModel.Drawings.Charts.UpDownBars? UpDownBars { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowMarker? ShowMarker { get; set; }
  
  public DocumentModel.Drawings.Charts.Smooth? Smooth { get; set; }
  
  public DocumentModel.Drawings.Charts.LineChartExtensionList? LineChartExtensionList { get; set; }
  
}
