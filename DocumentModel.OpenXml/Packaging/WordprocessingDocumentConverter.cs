namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public static class WordprocessingDocumentConverter
{
  /// <summary>
  /// Gets the type of the WordprocessingDocument.
  /// </summary>
  private static DM.WordprocessingDocumentType? GetDocumentType(DXPack.WordprocessingDocument openXmlElement)
  {
    if (openXmlElement?.DocumentType != null)
      return EnumValueConverter.GetValue<DX.WordprocessingDocumentType, DM.WordprocessingDocumentType>(openXmlElement.DocumentType);
    return null;
  }
  
  public static DMPack.WordprocessingDocument? CreateModelElement(DXPack.WordprocessingDocument? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WordprocessingDocument();
      value.DocumentType = GetDocumentType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordprocessingDocument? value)
    where OpenXmlElementType: DXPack.WordprocessingDocument, new()
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
