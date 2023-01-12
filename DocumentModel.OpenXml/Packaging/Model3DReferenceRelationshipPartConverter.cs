namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the Model3DReferenceRelationshipPart
/// </summary>
public static class Model3DReferenceRelationshipPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.Model3DReferenceRelationshipPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.Model3DReferenceRelationshipPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.Model3DReferenceRelationshipPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.Model3DReferenceRelationshipPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
