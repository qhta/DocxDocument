namespace DocumentModel.Drawing;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public interface IBar3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public System.UInt16? GapDepth { get ; set; }
  
  public DocumentModel.Drawing.ShapeKind? Shape { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.IBar3DChartExtensionList? Bar3DChartExtensionList { get ; set; }
  
}
