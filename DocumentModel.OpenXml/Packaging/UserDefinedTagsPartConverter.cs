namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the UserDefinedTagsPart
/// </summary>
public static class UserDefinedTagsPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.UserDefinedTagsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.UserDefinedTagsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.UserDefinedTagsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.UserDefinedTagsPart, new()
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
