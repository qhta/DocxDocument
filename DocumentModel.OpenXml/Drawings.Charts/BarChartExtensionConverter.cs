using DocumentModel.Drawings.Charts;
using BarChartExtension = DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the BarChartExtension Class.
/// </summary>
public static class BarChartExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(BarChartExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(BarChartExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static FilteredBarSeries? GetFilteredBarSeries(BarChartExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
    if (itemElement != null)
      return FilteredBarSeriesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFilteredBarSeries(BarChartExtension? openXmlElement, FilteredBarSeries? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredBarSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.BarChartExtension? CreateModelElement(BarChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BarChartExtension? value)
    where OpenXmlElementType : BarChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredBarSeries(openXmlElement, value?.FilteredBarSeries);
      return openXmlElement;
    }
    return default;
  }
}