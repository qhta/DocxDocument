namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public static class Line3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredLineSeriesExtensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFilteredLineSeriesExtension(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension? openXmlElement, DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredLineSeriesExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Line3DChartExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Line3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredLineSeriesExtension = GetFilteredLineSeriesExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Line3DChartExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
