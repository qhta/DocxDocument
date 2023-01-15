using DocumentModel.Drawings.Charts;
using BubbleChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries;
using FilteredBubbleSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredBubbleSeries Class.
/// </summary>
public static class FilteredBubbleSeriesConverter
{
  /// <summary>
  ///   BubbleChartSeries.
  /// </summary>
  public static BubbleChartSeries3? GetBubbleChartSeries(FilteredBubbleSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BubbleChartSeries>();
    if (itemElement != null)
      return BubbleChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBubbleChartSeries(FilteredBubbleSeries? openXmlElement, BubbleChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BubbleChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BubbleChartSeries3Converter.CreateOpenXmlElement<BubbleChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredBubbleSeries? CreateModelElement(FilteredBubbleSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredBubbleSeries();
      value.BubbleChartSeries = GetBubbleChartSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredBubbleSeries? value)
    where OpenXmlElementType : FilteredBubbleSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBubbleChartSeries(openXmlElement, value?.BubbleChartSeries);
      return openXmlElement;
    }
    return default;
  }
}