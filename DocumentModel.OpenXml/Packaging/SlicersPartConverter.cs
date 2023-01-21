namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlicersPart
/// </summary>
public static class SlicersPartConverter
{
  private static String? GetContentType(DXPack.SlicersPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.SlicersPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.SlicersPart? CreateModelElement(DXPack.SlicersPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.SlicersPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.SlicersPart? value)
    where OpenXmlElementType: DXPack.SlicersPart, new()
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
