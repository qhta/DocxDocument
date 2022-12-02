namespace DocumentModel.Drawing;

/// <summary>
/// Line Charts.
/// </summary>
public interface ILineChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public GroupingKind? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<ILineChartSeries>? LineChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public IDropLines? DropLines { get ; set; }
  
  public IHighLowLines? HighLowLines { get ; set; }
  
  public IUpDownBars? UpDownBars { get ; set; }
  
  public Boolean? ShowMarker { get ; set; }
  
  public Boolean? Smooth { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public ILineChartExtensionList? LineChartExtensionList { get ; set; }
  
}
