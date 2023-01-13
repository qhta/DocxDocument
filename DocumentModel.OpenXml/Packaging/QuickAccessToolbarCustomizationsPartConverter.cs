namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the QuickAccessToolbarCustomizationsPart
/// </summary>
public static class QuickAccessToolbarCustomizationsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.QuickAccessToolbarCustomizationsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.QuickAccessToolbarCustomizationsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.QuickAccessToolbarCustomizationsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.QuickAccessToolbarCustomizationsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.QuickAccessToolbarCustomizationsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.QuickAccessToolbarCustomizationsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.QuickAccessToolbarCustomizationsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
