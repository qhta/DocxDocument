namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
public interface IFilteredBubbleSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IBubbleChartSeries? BubbleChartSeries { get ; set; }
  
}
