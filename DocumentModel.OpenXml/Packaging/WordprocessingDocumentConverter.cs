namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public static class WordprocessingDocumentConverter
{
  /// <summary>
  /// Gets the type of the WordprocessingDocument.
  /// </summary>
  private static DocumentModel.WordprocessingDocumentType? GetDocumentType(DocumentFormat.OpenXml.Packaging.WordprocessingDocument openXmlElement)
  {
    if (openXmlElement?.DocumentType != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.WordprocessingDocumentType, DocumentModel.WordprocessingDocumentType>(openXmlElement.DocumentType);
    return null;
  }
  
  public static DocumentModel.Packaging.WordprocessingDocument? CreateModelElement(DocumentFormat.OpenXml.Packaging.WordprocessingDocument? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WordprocessingDocument();
      value.DocumentType = GetDocumentType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WordprocessingDocument? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WordprocessingDocument, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetDocumentType(openXmlElement, value?.DocumentType);
      return openXmlElement;
    }
    return default;
  }
}
