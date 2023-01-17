namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public static class ParagraphMarkRunPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Run Properties for the Paragraph Mark.
  /// </summary>
  private static DocumentModel.Wordprocessing.PreviousParagraphMarkRunProperties? GetPreviousParagraphMarkRunProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphMarkRunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PreviousParagraphMarkRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreviousParagraphMarkRunProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange openXmlElement, DocumentModel.Wordprocessing.PreviousParagraphMarkRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphMarkRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.PreviousParagraphMarkRunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphMarkRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousParagraphMarkRunProperties = GetPreviousParagraphMarkRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousParagraphMarkRunProperties(openXmlElement, value?.PreviousParagraphMarkRunProperties);
      return openXmlElement;
    }
    return default;
  }
}
