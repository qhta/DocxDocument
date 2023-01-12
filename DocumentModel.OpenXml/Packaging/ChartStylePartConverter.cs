namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartStylePart
/// </summary>
public static class ChartStylePartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.ChartsStyle.ChartStyle? GetChartStyle(DocumentFormat.OpenXml.Packaging.ChartStylePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetChartStyle(DocumentFormat.OpenXml.Packaging.ChartStylePart? openXmlElement, DocumentModel.Drawings.ChartsStyle.ChartStyle? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.ChartStylePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ChartStylePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
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
      return openXmlElement;
    }
    return default;
  }
}
