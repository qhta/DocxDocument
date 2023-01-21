namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the Model3DReferenceRelationshipPart
/// </summary>
public static class Model3DReferenceRelationshipPartConverter
{
  private static String? GetContentType(DXPack.Model3DReferenceRelationshipPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.Model3DReferenceRelationshipPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.Model3DReferenceRelationshipPart? CreateModelElement(DXPack.Model3DReferenceRelationshipPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.Model3DReferenceRelationshipPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.Model3DReferenceRelationshipPart? value)
    where OpenXmlElementType: DXPack.Model3DReferenceRelationshipPart, new()
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
