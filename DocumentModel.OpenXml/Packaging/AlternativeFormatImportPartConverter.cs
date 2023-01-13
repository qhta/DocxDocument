namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the AlternativeFormatImportPart
/// </summary>
public static class AlternativeFormatImportPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.AlternativeFormatImportPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.AlternativeFormatImportPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.AlternativeFormatImportPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart, new()
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
