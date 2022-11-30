namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public interface IPie3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawing.Charts.IPie3DChartExtensionList? Pie3DChartExtensionList { get ; set; }
  
}
