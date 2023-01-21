namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VbaProjectPart
/// </summary>
public static class VbaProjectPartConverter
{
  private static String? GetContentType(DXPack.VbaProjectPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.VbaProjectPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.VbaProjectPart? CreateModelElement(DXPack.VbaProjectPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.VbaProjectPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.VbaProjectPart? value)
    where OpenXmlElementType: DXPack.VbaProjectPart, new()
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
