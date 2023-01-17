namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
public static class DocPartConverter
{
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.DocPartProperties? GetDocPartProperties(DocumentFormat.OpenXml.Wordprocessing.DocPart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocPartPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocPartProperties(DocumentFormat.OpenXml.Wordprocessing.DocPart openXmlElement, DocumentModel.Wordprocessing.DocPartProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DocPartPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  private static DocumentModel.Wordprocessing.DocPartBody? GetDocPartBody(DocumentFormat.OpenXml.Wordprocessing.DocPart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartBody>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocPartBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocPartBody(DocumentFormat.OpenXml.Wordprocessing.DocPart openXmlElement, DocumentModel.Wordprocessing.DocPartBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DocPartBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.DocPart? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocPart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocPart, new()
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
