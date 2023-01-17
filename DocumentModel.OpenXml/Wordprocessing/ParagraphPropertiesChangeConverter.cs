namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ParagraphPropertiesChange Class.
/// </summary>
public static class ParagraphPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Paragraph Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.ParagraphPropertiesExtended? GetParagraphPropertiesExtended(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesExtended>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesExtendedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraphPropertiesExtended(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange openXmlElement, DocumentModel.Wordprocessing.ParagraphPropertiesExtended? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesExtended>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesExtendedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesExtended>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.ParagraphPropertiesChange? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.ParagraphPropertiesExtended = GetParagraphPropertiesExtended(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphPropertiesChange? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetParagraphPropertiesExtended(openXmlElement, value?.ParagraphPropertiesExtended);
      return openXmlElement;
    }
    return default;
  }
}
