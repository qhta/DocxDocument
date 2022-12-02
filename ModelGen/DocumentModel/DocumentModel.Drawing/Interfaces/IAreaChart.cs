namespace DocumentModel.Drawing;

/// <summary>
/// Area Charts.
/// </summary>
public interface IAreaChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public DocumentModel.Drawing.GroupingKind? Grouping { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IAreaChartSeries>? AreaChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawing.IDropLines? DropLines { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.IAreaChartExtensionList? AreaChartExtensionList { get ; set; }
  
}
