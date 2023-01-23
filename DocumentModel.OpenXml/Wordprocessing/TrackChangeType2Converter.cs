namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TrackChangeType Class.
/// </summary>
public static class TrackChangeType2Converter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXO2010W.TrackChangeType openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXO2010W.TrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Author?.Value == value;
  }
  
  private static void SetAuthor(DXO2010W.TrackChangeType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXO2010W.TrackChangeType openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static bool CmpDate(DXO2010W.TrackChangeType openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Date?.Value == value;
  }
  
  private static void SetDate(DXO2010W.TrackChangeType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXO2010W.TrackChangeType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010W.TrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2010W.TrackChangeType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.TrackChangeType2? CreateModelElement(DXO2010W.TrackChangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TrackChangeType2();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.TrackChangeType? openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TrackChangeType2? value)
    where OpenXmlElementType: DXO2010W.TrackChangeType, new()
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
