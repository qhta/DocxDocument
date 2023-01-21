namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThumbnailPart
/// </summary>
public static class ThumbnailPartConverter
{
  private static String? GetRelationshipType(DXPack.ThumbnailPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.ThumbnailPart? CreateModelElement(DXPack.ThumbnailPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ThumbnailPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ThumbnailPart? value)
    where OpenXmlElementType: DXPack.ThumbnailPart, new()
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
