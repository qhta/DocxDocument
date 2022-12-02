namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BarChartExtensionList Class.
/// </summary>
public interface IBarChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IBarChartExtension>? BarChartExtensions { get ; set; }
  
}
