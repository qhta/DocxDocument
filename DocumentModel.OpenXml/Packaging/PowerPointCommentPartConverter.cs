namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PowerPointCommentPart
/// </summary>
public static class PowerPointCommentPartConverter
{
  private static String? GetContentType(DXPack.PowerPointCommentPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.PowerPointCommentPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.PowerPointCommentPart? CreateModelElement(DXPack.PowerPointCommentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.PowerPointCommentPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.PowerPointCommentPart? value)
    where OpenXmlElementType: DXPack.PowerPointCommentPart, new()
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
