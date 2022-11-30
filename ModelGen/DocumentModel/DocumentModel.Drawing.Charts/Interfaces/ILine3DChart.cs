namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
public interface ILine3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public DocumentModel.Drawing.Charts.GroupingKind? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ILineChartSeries>? LineChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDropLines? DropLines { get ; set; }
  
  public System.UInt16? GapDepth { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.ILine3DChartExtensionList? Line3DChartExtensionList { get ; set; }
  
}
