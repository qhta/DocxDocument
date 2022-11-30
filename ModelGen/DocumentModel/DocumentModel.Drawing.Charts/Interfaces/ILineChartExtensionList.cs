namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the LineChartExtensionList Class.
/// </summary>
public interface ILineChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.ILineChartExtension>? LineChartExtensions { get ; set; }
  
}
