namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public interface IScatterChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public DocumentModel.Drawing.Charts.ScatterStyleKind? ScatterStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IScatterChartSeries>? ScatterChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.Charts.IScatterChartExtensionList? ScatterChartExtensionList { get ; set; }
  
}
