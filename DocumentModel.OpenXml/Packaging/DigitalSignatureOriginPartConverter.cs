using DocumentFormat.OpenXml.Packaging;
using XmlSignaturePart = DocumentModel.Packaging.XmlSignaturePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the DigitalSignatureOriginPart
/// </summary>
public static class DigitalSignatureOriginPartConverter
{
  public static String? GetContentType(DigitalSignatureOriginPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(DigitalSignatureOriginPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets the XmlSignatureParts of the DigitalSignatureOriginPart
  /// </summary>
  public static Collection<XmlSignaturePart>? GetXmlSignatureParts(DigitalSignatureOriginPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<XmlSignaturePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.XmlSignaturePart>())
      {
        var newItem = XmlSignaturePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static DocumentModel.Packaging.DigitalSignatureOriginPart? CreateModelElement(DigitalSignatureOriginPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DigitalSignatureOriginPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.XmlSignatureParts = GetXmlSignatureParts(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DigitalSignatureOriginPart? value)
    where OpenXmlElementType : DigitalSignatureOriginPart, new()
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