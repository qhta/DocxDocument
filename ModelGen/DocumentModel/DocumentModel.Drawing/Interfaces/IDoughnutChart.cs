namespace DocumentModel.Drawing;

/// <summary>
/// Doughnut Charts.
/// </summary>
public interface IDoughnutChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public IDataLabels? DataLabels { get ; set; }
  
  public UInt16? FirstSliceAngle { get ; set; }
  
  public Byte? HoleSize { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
