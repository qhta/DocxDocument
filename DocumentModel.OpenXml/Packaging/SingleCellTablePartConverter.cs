namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SingleCellTablePart
/// </summary>
public static class SingleCellTablePartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.SingleCellTablePart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.SingleCellTablePart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.SingleCellTablePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.SingleCellTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.SingleCellTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.SingleCellTablePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.SingleCellTablePart, new()
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
