namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the UserDefinedTagsPart
/// </summary>
public static class UserDefinedTagsPartConverter
{
  private static String? GetContentType(DXPack.UserDefinedTagsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.UserDefinedTagsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.UserDefinedTagsPart? CreateModelElement(DXPack.UserDefinedTagsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.UserDefinedTagsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.UserDefinedTagsPart? value)
    where OpenXmlElementType: DXPack.UserDefinedTagsPart, new()
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
