namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public static class RunTrackChangeTypeConverter
{
  /// <summary>
  /// author
  /// </summary>
  public static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  public static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? openXmlElement, String? value)
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
  public static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  public static void SetDate(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.RunTrackChangeType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunTrackChangeType();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RunTrackChangeType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
