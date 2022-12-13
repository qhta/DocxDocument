namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Area Charts.
/// </summary>
public interface AreaChart
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.GroupingKind? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.AreaChartSeries>? AreaChartSerieses { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawings.Charts.DropLines? DropLines { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public DocumentModel.Drawings.Charts.AreaChartExtensionList? AreaChartExtensionList { get ; set; }
  
}
