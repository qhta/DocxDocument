namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public static class WordprocessingDocumentConverter
{
  /// <summary>
  /// Gets the type of the WordprocessingDocument.
  /// </summary>
  public static DocumentModel.WordprocessingDocumentType? GetDocumentType(DocumentFormat.OpenXml.Packaging.WordprocessingDocument? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: 1");
  }
  
  public static void SetDocumentType(DocumentFormat.OpenXml.Packaging.WordprocessingDocument? openXmlElement, DocumentModel.WordprocessingDocumentType? value)
  {
    throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: 1");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
