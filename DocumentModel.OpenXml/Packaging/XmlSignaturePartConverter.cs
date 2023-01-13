namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the XmlSignaturePart
/// </summary>
public static class XmlSignaturePartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.XmlSignaturePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.XmlSignaturePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.XmlSignaturePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.XmlSignaturePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.XmlSignaturePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.XmlSignaturePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.XmlSignaturePart, new()
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
