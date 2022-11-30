namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Line Charts.
/// </summary>
public interface ILineChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public DocumentModel.Drawing.Charts.IHighLowLines? HighLowLines { get ; set; }
  
  public DocumentModel.Drawing.Charts.IUpDownBars? UpDownBars { get ; set; }
  
  public System.Boolean? ShowMarker { get ; set; }
  
  public System.Boolean? Smooth { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.ILineChartExtensionList? LineChartExtensionList { get ; set; }
  
}
