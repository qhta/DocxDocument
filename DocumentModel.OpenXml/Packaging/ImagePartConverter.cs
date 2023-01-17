namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ImagePart
/// </summary>
public static class ImagePartConverter
{
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ImagePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.ImagePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ImagePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ImagePart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ImagePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ImagePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
