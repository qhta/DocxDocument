namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public interface IChartSpaceExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IChartSpaceExtension>? ChartSpaceExtensions { get ; set; }
  
}
