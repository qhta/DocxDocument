namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public interface IChartSpaceExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IChartSpaceExtension>? ChartSpaceExtensions { get ; set; }
  
}
