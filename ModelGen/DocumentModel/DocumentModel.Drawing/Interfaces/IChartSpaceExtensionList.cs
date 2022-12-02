namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartSpaceExtensionList Class.
/// </summary>
public interface IChartSpaceExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IChartSpaceExtension>? ChartSpaceExtensions { get ; set; }
  
}
