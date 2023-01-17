namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public static class Line3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredLineSeriesExtensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredLineSeriesExtension(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? value)
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
