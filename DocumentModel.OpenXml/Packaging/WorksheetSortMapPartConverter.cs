namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetSortMapPart
/// </summary>
public static class WorksheetSortMapPartConverter
{
  private static String? GetContentType(DXPack.WorksheetSortMapPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.WorksheetSortMapPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.WorksheetSortMapPart? CreateModelElement(DXPack.WorksheetSortMapPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WorksheetSortMapPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WorksheetSortMapPart? value)
    where OpenXmlElementType: DXPack.WorksheetSortMapPart, new()
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
