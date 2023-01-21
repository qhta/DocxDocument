namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PivotTablePart
/// </summary>
public static class PivotTablePartConverter
{
  private static String? GetContentType(DXPack.PivotTablePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.PivotTablePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.PivotTablePart? CreateModelElement(DXPack.PivotTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.PivotTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.PivotTablePart? value)
    where OpenXmlElementType: DXPack.PivotTablePart, new()
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
