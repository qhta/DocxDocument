namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
public interface IFilteredBubbleSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  public DocumentModel.Drawing.IBubbleChartSeries? BubbleChartSeries { get ; set; }
  
}
