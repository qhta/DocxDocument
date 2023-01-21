namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the AlternativeFormatImportPart
/// </summary>
public static class AlternativeFormatImportPartConverter
{
  private static String? GetRelationshipType(DXPack.AlternativeFormatImportPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.AlternativeFormatImportPart? CreateModelElement(DXPack.AlternativeFormatImportPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.AlternativeFormatImportPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.AlternativeFormatImportPart? value)
    where OpenXmlElementType: DXPack.AlternativeFormatImportPart, new()
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
