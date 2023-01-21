namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the QueryTablePart
/// </summary>
public static class QueryTablePartConverter
{
  private static String? GetContentType(DXPack.QueryTablePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.QueryTablePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.QueryTablePart? CreateModelElement(DXPack.QueryTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.QueryTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.QueryTablePart? value)
    where OpenXmlElementType: DXPack.QueryTablePart, new()
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
