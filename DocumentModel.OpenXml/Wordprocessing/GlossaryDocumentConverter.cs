using DocumentModel.Wordprocessing;
using GlossaryDocument = DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Glossary Document Root Element.
/// </summary>
public static class GlossaryDocumentConverter
{
  /// <summary>
  ///   Document Background.
  /// </summary>
  public static DocumentBackground? GetDocumentBackground(GlossaryDocument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
    if (itemElement != null)
      return DocumentBackgroundConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocumentBackground(GlossaryDocument? openXmlElement, DocumentBackground? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentBackgroundConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List of Glossary Document Entries.
  /// </summary>
  public static DocParts? GetDocParts(GlossaryDocument? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocParts>();
    if (itemElement != null)
      return DocPartsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocParts(GlossaryDocument? openXmlElement, DocParts? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocParts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocParts>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.GlossaryDocument? CreateModelElement(GlossaryDocument? openXmlElement)
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
    where OpenXmlElementType : GlossaryDocument, new()
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