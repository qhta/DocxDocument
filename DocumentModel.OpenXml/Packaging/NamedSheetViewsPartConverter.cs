namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the NamedSheetViewsPart
/// </summary>
public static class NamedSheetViewsPartConverter
{
  private static String? GetContentType(DXPack.NamedSheetViewsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.NamedSheetViewsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.NamedSheetViewsPart? CreateModelElement(DXPack.NamedSheetViewsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.NamedSheetViewsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.NamedSheetViewsPart? value)
    where OpenXmlElementType: DXPack.NamedSheetViewsPart, new()
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
