namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleChartExtensionList Class.
/// </summary>
public interface IBubbleChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IBubbleChartExtension>? BubbleChartExtensions { get ; set; }
  
}
