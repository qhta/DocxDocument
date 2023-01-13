namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetSortMapPart
/// </summary>
public static class WorksheetSortMapPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.WorksheetSortMapPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WorksheetSortMapPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WorksheetSortMapPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
