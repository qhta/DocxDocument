namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Endnotes.
/// </summary>
public static class EndnotesConverter
{
  public static DocumentModel.Wordprocessing.Endnote? GetEndnote(DocumentFormat.OpenXml.Wordprocessing.Endnotes? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Endnote>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.EndnoteConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEndnote(DocumentFormat.OpenXml.Wordprocessing.Endnotes? openXmlElement, DocumentModel.Wordprocessing.Endnote? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Endnote>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.EndnoteConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Endnote>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Endnotes? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Endnotes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Endnotes();
      value.Endnote = GetEndnote(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Endnotes? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Endnotes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
