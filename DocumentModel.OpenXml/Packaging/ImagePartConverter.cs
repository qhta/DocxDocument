namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ImagePart
/// </summary>
public static class ImagePartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ImagePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
