namespace DocumentModel.Drawing;

/// <summary>
/// 3D Area Charts.
/// </summary>
public interface IArea3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public UInt16? GapDepth { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public IArea3DChartExtensionList? Area3DChartExtensionList { get ; set; }
  
}
