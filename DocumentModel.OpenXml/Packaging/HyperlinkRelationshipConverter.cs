namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents a hyperlink relationship.
/// </summary>
public static class HyperlinkRelationshipConverter
{
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  private static String? GetRelationshipType(DXPack.HyperlinkRelationship openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.HyperlinkRelationship? CreateModelElement(DXPack.HyperlinkRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.HyperlinkRelationship();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.HyperlinkRelationship? value)
    where OpenXmlElementType: DXPack.HyperlinkRelationship, new()
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
