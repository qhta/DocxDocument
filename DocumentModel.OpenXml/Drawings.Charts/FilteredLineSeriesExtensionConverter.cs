namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public static class FilteredLineSeriesExtensionConverter
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  public static DocumentModel.Drawings.Charts.LineChartSeries3? GetLineChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LineChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension? openXmlElement, DocumentModel.Drawings.Charts.LineChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.LineChartSeries3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredLineSeriesExtension();
      value.LineChartSeries = GetLineChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineChartSeries(openXmlElement, value?.LineChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
