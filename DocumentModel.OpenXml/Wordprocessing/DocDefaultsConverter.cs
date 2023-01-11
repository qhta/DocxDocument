namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
public static class DocDefaultsConverter
{
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunPropertiesDefault? GetRunPropertiesDefault(DocumentFormat.OpenXml.Wordprocessing.DocDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunPropertiesDefault(DocumentFormat.OpenXml.Wordprocessing.DocDefaults? openXmlElement, DocumentModel.Wordprocessing.RunPropertiesDefault? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.ParagraphPropertiesDefault? GetParagraphPropertiesDefault(DocumentFormat.OpenXml.Wordprocessing.DocDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphPropertiesDefault(DocumentFormat.OpenXml.Wordprocessing.DocDefaults? openXmlElement, DocumentModel.Wordprocessing.ParagraphPropertiesDefault? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DocDefaults? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocDefaults();
      value.RunPropertiesDefault = GetRunPropertiesDefault(openXmlElement);
      value.ParagraphPropertiesDefault = GetParagraphPropertiesDefault(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocDefaults? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.DocDefaults, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
