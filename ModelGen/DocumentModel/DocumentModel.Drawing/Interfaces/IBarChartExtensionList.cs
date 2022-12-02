namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BarChartExtensionList Class.
/// </summary>
public interface IBarChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IBarChartExtension>? BarChartExtensions { get ; set; }
  
}
