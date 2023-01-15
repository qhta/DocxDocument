using DocumentModel.Wordprocessing;
using DocPart = DocumentFormat.OpenXml.Wordprocessing.DocPart;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Glossary Document Entry.
/// </summary>
public static class DocPartConverter
{
  /// <summary>
  ///   Glossary Document Entry Properties.
  /// </summary>
  public static DocPartProperties? GetDocPartProperties(DocPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartProperties>();
    if (itemElement != null)
      return DocPartPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocPartProperties(DocPart? openXmlElement, DocPartProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Contents of Glossary Document Entry.
  /// </summary>
  public static DocPartBody? GetDocPartBody(DocPart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartBody>();
    if (itemElement != null)
      return DocPartBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocPartBody(DocPart? openXmlElement, DocPartBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.DocPart? CreateModelElement(DocPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocPart();
      value.DocPartProperties = GetDocPartProperties(openXmlElement);
      value.DocPartBody = GetDocPartBody(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocPart? value)
    where OpenXmlElementType : DocPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocPartProperties(openXmlElement, value?.DocPartProperties);
      SetDocPartBody(openXmlElement, value?.DocPartBody);
      return openXmlElement;
    }
    return default;
  }
}