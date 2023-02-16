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
  
  private static bool CmpAuthor(DXO2010W.RunTrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Author?.Value == value) return true;
    diffs?.Add(objName, "Author", openXmlElement?.Author?.Value, value);
    return false;
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
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXO2010W.RunTrackChangeType openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
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
  
  private static bool CmpId(DXO2010W.RunTrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2010W.RunTrackChangeType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.RunTrackChangeType2? CreateModelElement(DXO2010W.RunTrackChangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunTrackChangeType2();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.RunTrackChangeType? openXmlElement, DMW.RunTrackChangeType2? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
