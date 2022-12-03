namespace DocumentModel.Drawings;

/// <summary>
/// Line Charts.
/// </summary>
public interface LineChart // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public GroupingKind? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<LineChartSeries>? LineChartSerieses { get ; set; }
  
  public DataLabels? DataLabels { get ; set; }
  
  public DropLines? DropLines { get ; set; }
  
  public HighLowLines? HighLowLines { get ; set; }
  
  public UpDownBars? UpDownBars { get ; set; }
  
  public Boolean? ShowMarker { get ; set; }
  
  public Boolean? Smooth { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public LineChartExtensionList? LineChartExtensionList { get ; set; }
  
}
