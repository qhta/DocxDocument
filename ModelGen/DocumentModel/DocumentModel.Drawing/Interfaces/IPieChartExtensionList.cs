namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PieChartExtensionList Class.
/// </summary>
public interface IPieChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IPieChartExtension>? PieChartExtensions { get ; set; }
  
}
