namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public class BubbleChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension>, BubbleChartExtension
{
  public FilteredBubbleSeries? FilteredBubbleSeries
  {
    get;
    set;
  }
  
}
