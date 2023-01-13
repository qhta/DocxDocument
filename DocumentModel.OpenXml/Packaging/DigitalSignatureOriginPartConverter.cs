namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DigitalSignatureOriginPart
/// </summary>
public static class DigitalSignatureOriginPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the XmlSignatureParts of the DigitalSignatureOriginPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.XmlSignaturePart>? GetXmlSignatureParts(DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.XmlSignaturePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.XmlSignaturePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.XmlSignaturePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static DocumentModel.Packaging.DigitalSignatureOriginPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DigitalSignatureOriginPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
