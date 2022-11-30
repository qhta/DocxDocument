namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the PieChartExtensionList Class.
/// </summary>
public interface IPieChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IPieChartExtension>? PieChartExtensions { get ; set; }
  
}
