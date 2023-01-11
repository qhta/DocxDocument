namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ParagraphPropertiesChange Class.
/// </summary>
public static class ParagraphPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Author = new StringValue { Value = value };
      else
        openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  public static void SetDate(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Paragraph Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.ParagraphPropertiesExtended? GetParagraphPropertiesExtended(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesExtended>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ParagraphPropertiesExtendedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParagraphPropertiesExtended(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange? openXmlElement, DocumentModel.Wordprocessing.ParagraphPropertiesExtended? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
