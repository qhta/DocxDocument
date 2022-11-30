namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Doughnut Charts.
/// </summary>
public interface IDoughnutChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public System.Boolean? VaryColors { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IPieChartSeries>? PieChartSerieses { get ; set; }
  
  public DocumentModel.Drawing.Charts.IDataLabels? DataLabels { get ; set; }
  
  public System.UInt16? FirstSliceAngle { get ; set; }
  
  public System.Byte? HoleSize { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
