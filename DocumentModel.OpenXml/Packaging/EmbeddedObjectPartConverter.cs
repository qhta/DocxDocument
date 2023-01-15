using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the EmbeddedObjectPart
/// </summary>
public static class EmbeddedObjectPartConverter
{
  public static String? GetRelationshipType(EmbeddedObjectPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.EmbeddedObjectPart? CreateModelElement(EmbeddedObjectPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.EmbeddedObjectPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.EmbeddedObjectPart? value)
    where OpenXmlElementType : EmbeddedObjectPart, new()
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