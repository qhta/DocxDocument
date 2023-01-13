namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Footnotes.
/// </summary>
public static class FootnotesConverter
{
  public static DocumentModel.Wordprocessing.Footnote? GetFootnote(DocumentFormat.OpenXml.Wordprocessing.Footnotes? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Footnote>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FootnoteConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFootnote(DocumentFormat.OpenXml.Wordprocessing.Footnotes? openXmlElement, DocumentModel.Wordprocessing.Footnote? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Footnote>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.FootnoteConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Footnote>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Footnotes? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Footnotes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Footnotes();
      value.Footnote = GetFootnote(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Footnotes? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Footnotes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFootnote(openXmlElement, value?.Footnote);
      return openXmlElement;
    }
    return default;
  }
}
