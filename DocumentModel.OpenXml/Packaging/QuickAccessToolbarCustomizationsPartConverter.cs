namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the QuickAccessToolbarCustomizationsPart
/// </summary>
public static class QuickAccessToolbarCustomizationsPartConverter
{
  private static String? GetContentType(DXPack.QuickAccessToolbarCustomizationsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.QuickAccessToolbarCustomizationsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.QuickAccessToolbarCustomizationsPart? CreateModelElement(DXPack.QuickAccessToolbarCustomizationsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.QuickAccessToolbarCustomizationsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.QuickAccessToolbarCustomizationsPart? value)
    where OpenXmlElementType: DXPack.QuickAccessToolbarCustomizationsPart, new()
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
