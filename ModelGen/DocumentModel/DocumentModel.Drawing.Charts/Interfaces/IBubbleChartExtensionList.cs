namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleChartExtensionList Class.
/// </summary>
public interface IBubbleChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IBubbleChartExtension>? BubbleChartExtensions { get ; set; }
  
}
