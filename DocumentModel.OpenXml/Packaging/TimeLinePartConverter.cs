namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the TimeLinePart
/// </summary>
public static class TimeLinePartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.TimeLinePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.TimeLinePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.TimeLinePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.TimeLinePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.TimeLinePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.TimeLinePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.TimeLinePart, new()
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
