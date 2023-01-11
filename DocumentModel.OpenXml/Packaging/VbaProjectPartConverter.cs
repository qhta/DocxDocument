namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VbaProjectPart
/// </summary>
public static class VbaProjectPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.VbaProjectPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.VbaProjectPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
