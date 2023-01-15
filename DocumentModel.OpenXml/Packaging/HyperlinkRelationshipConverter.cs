using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Represents a hyperlink relationship.
/// </summary>
public static class HyperlinkRelationshipConverter
{
  /// <summary>
  ///   Gets the relationship type.
  /// </summary>
  public static String? GetRelationshipType(HyperlinkRelationship? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.HyperlinkRelationship? CreateModelElement(HyperlinkRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.HyperlinkRelationship();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.HyperlinkRelationship? value)
    where OpenXmlElementType : HyperlinkRelationship, new()
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