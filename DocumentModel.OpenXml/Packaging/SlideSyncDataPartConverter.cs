namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
public static class SlideSyncDataPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.SlideSyncDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.SlideSyncDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.SlideSyncDataPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.SlideSyncDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.SlideSyncDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.SlideSyncDataPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.SlideSyncDataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
