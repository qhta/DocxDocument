namespace DocumentModel.Drawing;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public interface IPie3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.IDataLabels? DataLabels { get ; set; }
  
  public DocumentModel.Drawing.IPie3DChartExtensionList? Pie3DChartExtensionList { get ; set; }
  
}
