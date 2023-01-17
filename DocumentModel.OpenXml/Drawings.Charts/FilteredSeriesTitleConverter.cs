namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredSeriesTitle Class.
/// </summary>
public static class FilteredSeriesTitleConverter
{
  /// <summary>
  /// ChartText.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ChartText3? GetChartText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartText3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle openXmlElement, DocumentModel.Drawings.Charts.ChartText3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartText3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredSeriesTitle? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle, new()
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
