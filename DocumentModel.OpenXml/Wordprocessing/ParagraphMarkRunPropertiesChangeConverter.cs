namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public static class ParagraphMarkRunPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement, String? value)
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
  public static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  public static void SetDate(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public static DocumentModel.Wordprocessing.PreviousParagraphMarkRunProperties? GetPreviousParagraphMarkRunProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.PreviousParagraphMarkRunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.PreviousParagraphMarkRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPreviousParagraphMarkRunProperties(DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunPropertiesChange? openXmlElement, DocumentModel.Wordprocessing.PreviousParagraphMarkRunProperties? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
