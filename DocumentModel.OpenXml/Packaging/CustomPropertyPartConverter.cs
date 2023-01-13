namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomPropertyPart
/// </summary>
public static class CustomPropertyPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CustomPropertyPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.CustomPropertyPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.CustomPropertyPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomPropertyPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomPropertyPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.CustomPropertyPart, new()
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
