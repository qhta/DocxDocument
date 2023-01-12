namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the NamedSheetViewsPart
/// </summary>
public static class NamedSheetViewsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.NamedSheetViewsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.NamedSheetViewsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.NamedSheetViewsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
