namespace DocumentModel.Drawing;

/// <summary>
/// Pie Charts.
/// </summary>
public interface IPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public System.UInt16? FirstSliceAngle { get ; set; }
  
  public DocumentModel.Drawing.IPieChartExtensionList? PieChartExtensionList { get ; set; }
  
}
