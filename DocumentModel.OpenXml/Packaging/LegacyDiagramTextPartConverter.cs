namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
public static class LegacyDiagramTextPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.LegacyDiagramTextPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.LegacyDiagramTextPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.LegacyDiagramTextPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart, new()
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
