namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomXmlPart
/// </summary>
public static class CustomXmlPartConverter
{
  private static String? GetRelationshipType(DXPack.CustomXmlPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.CustomXmlPart? CreateModelElement(DXPack.CustomXmlPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.CustomXmlPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomXmlPart? value)
    where OpenXmlElementType: DXPack.CustomXmlPart, new()
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
