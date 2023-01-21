namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DigitalSignatureOriginPart
/// </summary>
public static class DigitalSignatureOriginPartConverter
{
  private static String? GetContentType(DXPack.DigitalSignatureOriginPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.DigitalSignatureOriginPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the XmlSignatureParts of the DigitalSignatureOriginPart
  /// </summary>
  private static Collection<DMPack.XmlSignaturePart> GetXmlSignatureParts(DXPack.DigitalSignatureOriginPart openXmlElement)
  {
    var collection = new Collection<DMPack.XmlSignaturePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.XmlSignaturePart>())
    {
      var newItem = DMXPack.XmlSignaturePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  public static DMPack.DigitalSignatureOriginPart? CreateModelElement(DXPack.DigitalSignatureOriginPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DigitalSignatureOriginPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.XmlSignatureParts = GetXmlSignatureParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DigitalSignatureOriginPart? value)
    where OpenXmlElementType: DXPack.DigitalSignatureOriginPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetXmlSignatureParts(openXmlElement, value?.XmlSignatureParts);
      return openXmlElement;
    }
    return default;
  }
}
