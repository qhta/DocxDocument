namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pie Charts.
/// </summary>
public interface IPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.UInt16? FirstSliceAngle { get ; set; }
  
  public DocumentModel.Drawing.Charts.IPieChartExtensionList? PieChartExtensionList { get ; set; }
  
}
