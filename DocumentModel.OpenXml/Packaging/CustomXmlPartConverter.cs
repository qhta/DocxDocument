using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the CustomXmlPart
/// </summary>
public static class CustomXmlPartConverter
{
  public static String? GetRelationshipType(CustomXmlPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.CustomXmlPart? CreateModelElement(CustomXmlPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomXmlPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomXmlPart? value)
    where OpenXmlElementType : CustomXmlPart, new()
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