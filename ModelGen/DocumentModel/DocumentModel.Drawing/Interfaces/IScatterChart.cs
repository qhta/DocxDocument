namespace DocumentModel.Drawing;

/// <summary>
/// Scatter Charts.
/// </summary>
public interface IScatterChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public DocumentModel.Drawing.ScatterStyleKind? ScatterStyle { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IScatterChartSeries>? ScatterChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.UInt32>? AxisIds { get ; set; }
  
  public DocumentModel.Drawing.IScatterChartExtensionList? ScatterChartExtensionList { get ; set; }
  
}
