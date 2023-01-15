using DocumentModel.Drawings.Charts;
using BubbleChartExtension = DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the BubbleChartExtension Class.
/// </summary>
public static class BubbleChartExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(BubbleChartExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(BubbleChartExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static FilteredBubbleSeries? GetFilteredBubbleSeries(BubbleChartExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>();
    if (itemElement != null)
      return FilteredBubbleSeriesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFilteredBubbleSeries(BubbleChartExtension? openXmlElement, FilteredBubbleSeries? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredBubbleSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.BubbleChartExtension? CreateModelElement(BubbleChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBubbleSeries = GetFilteredBubbleSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleChartExtension? value)
    where OpenXmlElementType : BubbleChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredBubbleSeries(openXmlElement, value?.FilteredBubbleSeries);
      return openXmlElement;
    }
    return default;
  }
}