namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Area Charts.
/// </summary>
public partial class AreaChart
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.GroupingKind? Grouping { get; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.AreaChartSeries>? AreaChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines { get; set; }
  
  public Collection<System.UInt32>? AxisIds { get; set; }
  
  public DocumentModel.Drawings.Charts.AreaChartExtensionList? AreaChartExtensionList { get; set; }
  
}
