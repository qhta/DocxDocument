using DocumentModel.Drawings.Charts;
using LineChartExtension = DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the LineChartExtension Class.
/// </summary>
public static class LineChartExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(LineChartExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(LineChartExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(LineChartExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      return FilteredLineSeriesExtensionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFilteredLineSeriesExtension(LineChartExtension? openXmlElement, FilteredLineSeriesExtension? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredLineSeriesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.LineChartExtension? CreateModelElement(LineChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredLineSeriesExtension = GetFilteredLineSeriesExtension(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LineChartExtension? value)
    where OpenXmlElementType : LineChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredLineSeriesExtension(openXmlElement, value?.FilteredLineSeriesExtension);
      return openXmlElement;
    }
    return default;
  }
}