namespace DocumentModel.Drawing;

/// <summary>
/// Area Charts.
/// </summary>
public interface IAreaChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public GroupingKind? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IAreaChartSeries>? AreaChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public IDropLines? DropLines { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public IAreaChartExtensionList? AreaChartExtensionList { get ; set; }
  
}
