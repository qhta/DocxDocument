using DocumentModel.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Represents an external relationship.
/// </summary>
public static class ExternalRelationshipConverter
{
  public static ExternalRelationship? CreateModelElement(DocumentFormat.OpenXml.Packaging.ExternalRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new ExternalRelationship();
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(ExternalRelationship? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Packaging.ExternalRelationship, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}