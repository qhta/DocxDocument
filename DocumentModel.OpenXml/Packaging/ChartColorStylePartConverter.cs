namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartColorStylePart
/// </summary>
public static class ChartColorStylePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Drawings.ChartsStyle.ColorStyle? GetColorStyle(DocumentFormat.OpenXml.Packaging.ChartColorStylePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle rootElement)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.ColorStyleConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetColorStyle(DocumentFormat.OpenXml.Packaging.ChartColorStylePart openXmlElement, DocumentModel.Drawings.ChartsStyle.ColorStyle? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Drawings.ChartsStyle.ColorStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle>(value);
       if (rootElement != null)
         openXmlElement.ColorStyle = rootElement;
    }
  }
  
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.ChartColorStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ChartColorStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.ChartColorStylePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ChartColorStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartColorStylePart();
      value.ColorStyle = GetColorStyle(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ChartColorStylePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ChartColorStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorStyle(openXmlElement, value?.ColorStyle);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
