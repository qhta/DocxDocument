namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the FontPart
/// </summary>
public static class FontPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.FontPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.FontPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.FontPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.FontPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.FontPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.FontPart, new()
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
