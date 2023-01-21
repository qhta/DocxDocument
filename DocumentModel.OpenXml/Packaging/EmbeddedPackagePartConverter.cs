namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedPackagePart
/// </summary>
public static class EmbeddedPackagePartConverter
{
  private static String? GetRelationshipType(DXPack.EmbeddedPackagePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.EmbeddedPackagePart? CreateModelElement(DXPack.EmbeddedPackagePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.EmbeddedPackagePart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.EmbeddedPackagePart? value)
    where OpenXmlElementType: DXPack.EmbeddedPackagePart, new()
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
