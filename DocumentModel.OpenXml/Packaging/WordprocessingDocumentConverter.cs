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
  
  private static bool CmpDocumentType(DXPack.WordprocessingDocument openXmlElement, DM.WordprocessingDocumentType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DocumentType != null)
      return EnumValueConverter.CmpValue<DX.WordprocessingDocumentType, DM.WordprocessingDocumentType>(openXmlElement.DocumentType, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
    return openXmlElement == null && value == null;
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
  
  public static bool CompareModelElement(DXPack.WordprocessingDocument? openXmlElement, DMPack.WordprocessingDocument? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocumentType(openXmlElement, value.DocumentType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
