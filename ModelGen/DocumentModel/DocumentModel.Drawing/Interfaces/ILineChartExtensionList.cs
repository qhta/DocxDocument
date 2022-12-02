namespace DocumentModel.Drawing;

/// <summary>
/// Defines the LineChartExtensionList Class.
/// </summary>
public interface ILineChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ILineChartExtension>? LineChartExtensions { get ; set; }
  
}
