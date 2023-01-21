namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the XmlSignaturePart
/// </summary>
public static class XmlSignaturePartConverter
{
  private static String? GetContentType(DXPack.XmlSignaturePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.XmlSignaturePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.XmlSignaturePart? CreateModelElement(DXPack.XmlSignaturePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.XmlSignaturePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.XmlSignaturePart? value)
    where OpenXmlElementType: DXPack.XmlSignaturePart, new()
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
