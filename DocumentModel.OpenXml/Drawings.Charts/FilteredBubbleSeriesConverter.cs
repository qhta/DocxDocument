namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
public static class FilteredBubbleSeriesConverter
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  public static DocumentModel.Drawings.Charts.BubbleChartSeries3? GetBubbleChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BubbleChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBubbleChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries? openXmlElement, DocumentModel.Drawings.Charts.BubbleChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.BubbleChartSeries3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BubbleChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredBubbleSeries? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
