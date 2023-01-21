namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SingleCellTablePart
/// </summary>
public static class SingleCellTablePartConverter
{
  private static String? GetContentType(DXPack.SingleCellTablePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.SingleCellTablePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.SingleCellTablePart? CreateModelElement(DXPack.SingleCellTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.SingleCellTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.SingleCellTablePart? value)
    where OpenXmlElementType: DXPack.SingleCellTablePart, new()
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
