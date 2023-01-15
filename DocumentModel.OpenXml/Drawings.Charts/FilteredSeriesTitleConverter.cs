using DocumentModel.Drawings.Charts;
using ChartText = DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText;
using FilteredSeriesTitle = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredSeriesTitle Class.
/// </summary>
public static class FilteredSeriesTitleConverter
{
  /// <summary>
  ///   ChartText.
  /// </summary>
  public static ChartText3? GetChartText(FilteredSeriesTitle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ChartText>();
    if (itemElement != null)
      return ChartText3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartText(FilteredSeriesTitle? openXmlElement, ChartText3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartText3Converter.CreateOpenXmlElement<ChartText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredSeriesTitle? CreateModelElement(FilteredSeriesTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredSeriesTitle();
      value.ChartText = GetChartText(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredSeriesTitle? value)
    where OpenXmlElementType : FilteredSeriesTitle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartText(openXmlElement, value?.ChartText);
      return openXmlElement;
    }
    return default;
  }
}