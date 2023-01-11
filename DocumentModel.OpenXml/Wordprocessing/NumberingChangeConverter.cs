namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Paragraph Numbering Properties.
/// </summary>
public static class NumberingChangeConverter
{
  /// <summary>
  /// original
  /// </summary>
  public static String? GetOriginal(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement)
  {
    return openXmlElement?.Original?.Value;
  }
  
  public static void SetOriginal(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Original = new StringValue { Value = value };
      else
        openXmlElement.Original = null;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement, String? value)
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
  public static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  public static void SetDate(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.NumberingChange? openXmlElement, String? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
