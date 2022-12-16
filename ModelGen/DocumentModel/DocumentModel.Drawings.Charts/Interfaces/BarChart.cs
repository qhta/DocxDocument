namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Bar Charts.
/// </summary>
public interface BarChart
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarDirectionKind? BarDirection { get ; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarGroupingKind? BarGrouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.BarChartSeries>? BarChartSerieses { get ; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get ; set; }
  
  public UInt16? GapWidth { get ; set; }
  
  public SByte? Overlap { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.SeriesLines>? SeriesLineses { get ; set; }
  
  public Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawings.Charts.BarChartExtensionList? BarChartExtensionList { get ; set; }
  
}
