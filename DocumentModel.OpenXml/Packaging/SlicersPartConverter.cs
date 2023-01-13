namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlicersPart
/// </summary>
public static class SlicersPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.SlicersPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.SlicersPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.SlicersPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.SlicersPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.SlicersPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.SlicersPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.SlicersPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
