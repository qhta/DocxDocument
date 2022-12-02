namespace DocumentModel.Drawing;

/// <summary>
/// 3D Line Charts.
/// </summary>
public interface ILine3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public UInt16? GapDepth { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public ILine3DChartExtensionList? Line3DChartExtensionList { get ; set; }
  
}
