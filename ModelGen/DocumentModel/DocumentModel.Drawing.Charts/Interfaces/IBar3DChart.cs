namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public interface IBar3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public System.UInt16? GapDepth { get ; set; }
  
  public DocumentModel.Drawing.Charts.ShapeKind? Shape { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.IBar3DChartExtensionList? Bar3DChartExtensionList { get ; set; }
  
}
