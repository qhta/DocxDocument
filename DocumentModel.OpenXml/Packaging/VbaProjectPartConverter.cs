namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VbaProjectPart
/// </summary>
public static class VbaProjectPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.VbaProjectPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.VbaProjectPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.VbaProjectPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.VbaProjectPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.VbaProjectPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.VbaProjectPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.VbaProjectPart, new()
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
