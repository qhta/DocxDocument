namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineChartExtensionList Class.
/// </summary>
public interface ILineChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ILineChartExtension>? LineChartExtensions { get ; set; }
  
}
