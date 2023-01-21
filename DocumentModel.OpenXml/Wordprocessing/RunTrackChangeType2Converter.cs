namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public static class RunTrackChangeType2Converter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXO2010W.RunTrackChangeType openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DXO2010W.RunTrackChangeType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXO2010W.RunTrackChangeType openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DXO2010W.RunTrackChangeType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXO2010W.RunTrackChangeType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2010W.RunTrackChangeType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.RunTrackChangeType2? CreateModelElement(DXO2010W.RunTrackChangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunTrackChangeType2();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RunTrackChangeType2? value)
    where OpenXmlElementType: DXO2010W.RunTrackChangeType, new()
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
