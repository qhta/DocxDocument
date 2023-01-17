namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlideCommentsPart
/// </summary>
public static class SlideCommentsPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.SlideCommentsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.SlideCommentsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.SlideCommentsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.SlideCommentsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.SlideCommentsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.SlideCommentsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.SlideCommentsPart, new()
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
