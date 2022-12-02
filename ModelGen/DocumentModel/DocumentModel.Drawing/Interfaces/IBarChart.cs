namespace DocumentModel.Drawing;

/// <summary>
/// Bar Charts.
/// </summary>
public interface IBarChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public BarDirectionKind? BarDirection { get ; set; }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public BarGroupingKind? BarGrouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IBarChartSeries>? BarChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public UInt16? GapWidth { get ; set; }
  
  public SByte? Overlap { get ; set; }
  
  public Collection<ISeriesLines>? SeriesLineses { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public IBarChartExtensionList? BarChartExtensionList { get ; set; }
  
}
