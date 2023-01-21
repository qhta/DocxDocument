namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
public static class SlideSyncDataPartConverter
{
  private static String? GetContentType(DXPack.SlideSyncDataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.SlideSyncDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.SlideSyncDataPart? CreateModelElement(DXPack.SlideSyncDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.SlideSyncDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.SlideSyncDataPart? value)
    where OpenXmlElementType: DXPack.SlideSyncDataPart, new()
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
