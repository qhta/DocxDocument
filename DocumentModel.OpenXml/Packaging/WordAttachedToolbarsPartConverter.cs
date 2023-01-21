namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordAttachedToolbarsPart
/// </summary>
public static class WordAttachedToolbarsPartConverter
{
  private static String? GetContentType(DXPack.WordAttachedToolbarsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.WordAttachedToolbarsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.WordAttachedToolbarsPart? CreateModelElement(DXPack.WordAttachedToolbarsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WordAttachedToolbarsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordAttachedToolbarsPart? value)
    where OpenXmlElementType: DXPack.WordAttachedToolbarsPart, new()
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
