using DocumentModel.Wordprocessing;
using Footnotes = DocumentFormat.OpenXml.Wordprocessing.Footnotes;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document Footnotes.
/// </summary>
public static class FootnotesConverter
{
  public static Footnote? GetFootnote(Footnotes? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Footnote>();
    if (itemElement != null)
      return FootnoteConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFootnote(Footnotes? openXmlElement, Footnote? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Footnote>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FootnoteConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Footnote>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Footnotes? CreateModelElement(Footnotes? openXmlElement)
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
    where OpenXmlElementType : Footnotes, new()
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