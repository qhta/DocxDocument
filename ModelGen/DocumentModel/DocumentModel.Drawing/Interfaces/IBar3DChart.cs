namespace DocumentModel.Drawing;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public interface IBar3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public UInt16? GapDepth { get ; set; }
  
  public ShapeKind? Shape { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public IBar3DChartExtensionList? Bar3DChartExtensionList { get ; set; }
  
}
