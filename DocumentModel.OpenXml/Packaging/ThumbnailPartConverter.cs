namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThumbnailPart
/// </summary>
public static class ThumbnailPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ThumbnailPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.ThumbnailPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ThumbnailPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ThumbnailPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ThumbnailPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ThumbnailPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
