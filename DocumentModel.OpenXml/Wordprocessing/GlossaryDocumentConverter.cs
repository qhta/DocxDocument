namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public static class GlossaryDocumentConverter
{
  /// <summary>
  /// Document Background.
  /// </summary>
  public static DocumentModel.Wordprocessing.DocumentBackground? GetDocumentBackground(DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocumentBackgroundConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDocumentBackground(DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument? openXmlElement, DocumentModel.Wordprocessing.DocumentBackground? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.DocumentBackgroundConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  public static DocumentModel.Wordprocessing.DocParts? GetDocParts(DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocParts>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocPartsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDocParts(DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument? openXmlElement, DocumentModel.Wordprocessing.DocParts? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocParts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.DocPartsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocParts>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.GlossaryDocument? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GlossaryDocument();
      value.DocumentBackground = GetDocumentBackground(openXmlElement);
      value.DocParts = GetDocParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GlossaryDocument? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocumentBackground(openXmlElement, value?.DocumentBackground);
      SetDocParts(openXmlElement, value?.DocParts);
      return openXmlElement;
    }
    return default;
  }
}
