namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public static class FilteredPieSeriesConverter
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PieChartSeries3? GetPieChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PieChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPieChartSeries(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries? openXmlElement, DocumentModel.Drawings.Charts.PieChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PieChartSeries3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredPieSeries? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredPieSeries();
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredPieSeries? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
