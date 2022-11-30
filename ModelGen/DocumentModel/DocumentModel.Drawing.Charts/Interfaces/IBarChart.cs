namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Bar Charts.
/// </summary>
public interface IBarChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public DocumentModel.Drawing.Charts.BarDirectionKind? BarDirection { get ; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public DocumentModel.Drawing.Charts.BarGroupingKind? BarGrouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IBarChartSeries>? BarChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.UInt16? GapWidth { get ; set; }
  
  public System.SByte? Overlap { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ISeriesLines>? SeriesLineses { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBarChartExtensionList? BarChartExtensionList { get ; set; }
  
}
