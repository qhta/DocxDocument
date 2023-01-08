namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
public static class DocumentConverter
{
  /// <summary>
  /// conformance
  /// </summary>
  public static DocumentModel.Wordprocessing.DocumentConformance? GetConformance(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentConformance, DocumentModel.Wordprocessing.DocumentConformance>(openXmlElement?.Conformance?.Value);
  }
  
  public static void SetConformance(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement, DocumentModel.Wordprocessing.DocumentConformance? value)
  {
    if (openXmlElement != null)
      openXmlElement.Conformance = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocumentConformance, DocumentModel.Wordprocessing.DocumentConformance>(value);
  }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  public static DocumentModel.Wordprocessing.DocumentBackground? GetDocumentBackground(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocumentBackground(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement, DocumentModel.Wordprocessing.DocumentBackground? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Body.
  /// </summary>
  public static DocumentModel.Wordprocessing.Body? GetBody(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBody(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement, DocumentModel.Wordprocessing.Body? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
