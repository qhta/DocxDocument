namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
public static class LegacyDiagramTextPartConverter
{
  private static String? GetContentType(DXPack.LegacyDiagramTextPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.LegacyDiagramTextPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.LegacyDiagramTextPart? CreateModelElement(DXPack.LegacyDiagramTextPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.LegacyDiagramTextPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.LegacyDiagramTextPart? value)
    where OpenXmlElementType: DXPack.LegacyDiagramTextPart, new()
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
