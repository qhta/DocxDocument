namespace DocumentModel.Drawing;

/// <summary>
/// Line Charts.
/// </summary>
public interface ILineChart // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public DocumentModel.Drawing.IHighLowLines? HighLowLines { get ; set; }
  
  public DocumentModel.Drawing.IUpDownBars? UpDownBars { get ; set; }
  
  public System.Boolean? ShowMarker { get ; set; }
  
  public System.Boolean? Smooth { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.ILineChartExtensionList? LineChartExtensionList { get ; set; }
  
}
