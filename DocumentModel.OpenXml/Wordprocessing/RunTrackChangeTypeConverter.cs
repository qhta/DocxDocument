namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public static class RunTrackChangeTypeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.RunTrackChangeType openXmlElement, String? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
