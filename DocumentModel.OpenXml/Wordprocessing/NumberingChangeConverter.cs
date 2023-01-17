namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Paragraph Numbering Properties.
/// </summary>
public static class NumberingChangeConverter
{
  /// <summary>
  /// original
  /// </summary>
  private static String? GetOriginal(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement)
  {
    return openXmlElement?.Original?.Value;
  }
  
  private static void SetOriginal(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Original = new StringValue { Value = value };
    else
      openXmlElement.Original = null;
  }
  
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.NumberingChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.NumberingChange? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingChange();
      value.Original = GetOriginal(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.NumberingChange? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.NumberingChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOriginal(openXmlElement, value?.Original);
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
