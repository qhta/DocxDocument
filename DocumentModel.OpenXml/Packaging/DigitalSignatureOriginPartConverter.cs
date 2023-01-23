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
  
  private static bool CmpContentType(DXPack.DigitalSignatureOriginPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.DigitalSignatureOriginPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DigitalSignatureOriginPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
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
  
  private static bool CmpXmlSignatureParts(DXPack.DigitalSignatureOriginPart openXmlElement, Collection<DMPack.XmlSignaturePart>? value, DiffList? diffs, string? objName)
  {
    return true;
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
  
  public static bool CompareModelElement(DXPack.DigitalSignatureOriginPart? openXmlElement, DMPack.DigitalSignatureOriginPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpXmlSignatureParts(openXmlElement, value.XmlSignatureParts, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
