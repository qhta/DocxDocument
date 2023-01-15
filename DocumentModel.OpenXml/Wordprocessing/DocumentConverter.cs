using DocumentModel.Wordprocessing;
using Document = DocumentFormat.OpenXml.Wordprocessing.Document;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document.
/// </summary>
public static class DocumentConverter
{
  /// <summary>
  ///   conformance
  /// </summary>
  public static DocumentConformance? GetConformance(Document? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentConformance, DocumentConformance>(openXmlElement?.Conformance?.Value);
  }

  public static void SetConformance(Document? openXmlElement, DocumentConformance? value)
  {
    if (openXmlElement != null)
      openXmlElement.Conformance = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocumentConformance, DocumentConformance>(value);
  }

  /// <summary>
  ///   Document Background.
  /// </summary>
  public static DocumentBackground? GetDocumentBackground(Document? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
    if (itemElement != null)
      return DocumentBackgroundConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocumentBackground(Document? openXmlElement, DocumentBackground? value)
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
  ///   Body.
  /// </summary>
  public static Body? GetBody(Document? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Body>();
    if (itemElement != null)
      return BodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBody(Document? openXmlElement, Body? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Body>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Body>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Document? CreateModelElement(Document? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Document();
      value.Conformance = GetConformance(openXmlElement);
      value.DocumentBackground = GetDocumentBackground(openXmlElement);
      value.Body = GetBody(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Document? value)
    where OpenXmlElementType : Document, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConformance(openXmlElement, value?.Conformance);
      SetDocumentBackground(openXmlElement, value?.DocumentBackground);
      SetBody(openXmlElement, value?.Body);
      return openXmlElement;
    }
    return default;
  }
}