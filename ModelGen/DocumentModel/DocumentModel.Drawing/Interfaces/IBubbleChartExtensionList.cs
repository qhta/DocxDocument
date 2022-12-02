namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleChartExtensionList Class.
/// </summary>
public interface IBubbleChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IBubbleChartExtension>? BubbleChartExtensions { get ; set; }
  
}
