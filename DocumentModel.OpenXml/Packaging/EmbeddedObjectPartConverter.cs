namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedObjectPart
/// </summary>
public static class EmbeddedObjectPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.EmbeddedObjectPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.EmbeddedObjectPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.EmbeddedObjectPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
