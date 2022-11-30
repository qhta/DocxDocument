namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public interface IBubbleChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredBubbleSeries? FilteredBubbleSeries { get ; set; }
  
}
