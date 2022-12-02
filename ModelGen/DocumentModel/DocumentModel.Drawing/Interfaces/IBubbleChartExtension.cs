namespace DocumentModel.Drawing;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public interface IBubbleChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredBubbleSeries? FilteredBubbleSeries { get ; set; }
  
}
