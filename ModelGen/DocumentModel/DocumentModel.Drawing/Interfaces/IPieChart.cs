namespace DocumentModel.Drawing;

/// <summary>
/// Pie Charts.
/// </summary>
public interface IPieChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public UInt16? FirstSliceAngle { get ; set; }
  
  public IPieChartExtensionList? PieChartExtensionList { get ; set; }
  
}
