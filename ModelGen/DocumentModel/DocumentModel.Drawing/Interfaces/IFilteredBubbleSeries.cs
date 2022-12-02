namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
public interface IFilteredBubbleSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  public IBubbleChartSeries? BubbleChartSeries { get ; set; }
  
}
