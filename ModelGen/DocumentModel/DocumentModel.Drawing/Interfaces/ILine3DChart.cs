namespace DocumentModel.Drawing;

/// <summary>
/// 3D Line Charts.
/// </summary>
public interface ILine3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public DocumentModel.Drawing.GroupingKind? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ILineChartSeries>? LineChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawing.IDropLines? DropLines { get ; set; }
  
  public System.UInt16? GapDepth { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.ILine3DChartExtensionList? Line3DChartExtensionList { get ; set; }
  
}
