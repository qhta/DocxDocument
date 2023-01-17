namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the QueryTablePart
/// </summary>
public static class QueryTablePartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.QueryTablePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.QueryTablePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.QueryTablePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.QueryTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.QueryTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.QueryTablePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.QueryTablePart, new()
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
