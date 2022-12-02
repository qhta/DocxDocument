namespace DocumentModel.Drawing;

/// <summary>
/// Bar Charts.
/// </summary>
public interface IBarChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public DocumentModel.Drawing.BarDirectionKind? BarDirection { get ; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public DocumentModel.Drawing.BarGroupingKind? BarGrouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IBarChartSeries>? BarChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.UInt16? GapWidth { get ; set; }
  
  public System.SByte? Overlap { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ISeriesLines>? SeriesLineses { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.IBarChartExtensionList? BarChartExtensionList { get ; set; }
  
}
