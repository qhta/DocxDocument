using DocumentModel.Drawings.Charts;
using Pie3DChartExtension = DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the Pie3DChartExtension Class.
/// </summary>
public static class Pie3DChartExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(Pie3DChartExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(Pie3DChartExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static FilteredPieSeries? GetFilteredPieSeries(Pie3DChartExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>();
    if (itemElement != null)
      return FilteredPieSeriesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFilteredPieSeries(Pie3DChartExtension? openXmlElement, FilteredPieSeries? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredPieSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.Pie3DChartExtension? CreateModelElement(Pie3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Pie3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredPieSeries = GetFilteredPieSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Pie3DChartExtension? value)
    where OpenXmlElementType : Pie3DChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredPieSeries(openXmlElement, value?.FilteredPieSeries);
      return openXmlElement;
    }
    return default;
  }
}