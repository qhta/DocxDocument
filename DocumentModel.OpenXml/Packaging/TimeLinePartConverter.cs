namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the TimeLinePart
/// </summary>
public static class TimeLinePartConverter
{
  private static String? GetContentType(DXPack.TimeLinePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.TimeLinePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.TimeLinePart? CreateModelElement(DXPack.TimeLinePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.TimeLinePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.TimeLinePart? value)
    where OpenXmlElementType: DXPack.TimeLinePart, new()
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
