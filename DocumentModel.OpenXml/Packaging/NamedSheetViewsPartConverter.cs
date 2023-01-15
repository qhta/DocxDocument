using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the NamedSheetViewsPart
/// </summary>
public static class NamedSheetViewsPartConverter
{
  public static String? GetContentType(NamedSheetViewsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(NamedSheetViewsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.NamedSheetViewsPart? CreateModelElement(NamedSheetViewsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.NamedSheetViewsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.NamedSheetViewsPart? value)
    where OpenXmlElementType : NamedSheetViewsPart, new()
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