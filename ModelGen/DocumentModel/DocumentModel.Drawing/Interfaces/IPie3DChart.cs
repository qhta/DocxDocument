namespace DocumentModel.Drawing;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public interface IPie3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public IPie3DChartExtensionList? Pie3DChartExtensionList { get ; set; }
  
}
