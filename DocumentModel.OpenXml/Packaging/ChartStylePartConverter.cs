namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public static class ChartStylePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.ChartStyle? GetChartStyle(DocumentFormat.OpenXml.Packaging.ChartStylePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle rootElement)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.ChartStyleConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetChartStyle(DocumentFormat.OpenXml.Packaging.ChartStylePart openXmlElement, DocumentModel.Drawings.ChartsStyle.ChartStyle? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Drawings.ChartsStyle.ChartStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle>(value);
       if (rootElement != null)
         openXmlElement.ChartStyle = rootElement;
    }
  }
  
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.ChartStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ChartStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.ChartStylePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ChartStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartStylePart();
      value.ChartStyle = GetChartStyle(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ChartStylePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ChartStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartStyle(openXmlElement, value?.ChartStyle);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
