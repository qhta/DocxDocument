using DocumentModel.Wordprocessing;
using Endnotes = DocumentFormat.OpenXml.Wordprocessing.Endnotes;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document Endnotes.
/// </summary>
public static class EndnotesConverter
{
  public static Endnote? GetEndnote(Endnotes? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Endnote>();
    if (itemElement != null)
      return EndnoteConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndnote(Endnotes? openXmlElement, Endnote? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Endnote>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndnoteConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Endnote>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Endnotes? CreateModelElement(Endnotes? openXmlElement)
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
    where OpenXmlElementType : Endnotes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEndnote(openXmlElement, value?.Endnote);
      return openXmlElement;
    }
    return default;
  }
}