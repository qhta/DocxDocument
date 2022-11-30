namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BarChartExtensionList Class.
/// </summary>
public interface IBarChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IBarChartExtension>? BarChartExtensions { get ; set; }
  
}
