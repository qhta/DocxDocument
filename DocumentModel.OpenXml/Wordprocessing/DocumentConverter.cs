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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DocumentBackgroundConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDocumentBackground(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement, DocumentModel.Wordprocessing.DocumentBackground? value)
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
  /// Body.
  /// </summary>
  public static DocumentModel.Wordprocessing.Body? GetBody(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Body>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.BodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBody(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement, DocumentModel.Wordprocessing.Body? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Body>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.BodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Body>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Document? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Document? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Document, new()
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
