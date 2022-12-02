namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PieChartExtensionList Class.
/// </summary>
public interface IPieChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IPieChartExtension>? PieChartExtensions { get ; set; }
  
}
