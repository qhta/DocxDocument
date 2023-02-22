namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RunTrackChangeType Class.
/// </summary>
public static class RunTrackChangeTypeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.RunTrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.RunTrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.RunTrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.RunTrackChangeType openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.RunTrackChangeType openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.RunTrackChangeType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.RunTrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.RunTrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.RunTrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.RunTrackChangeType? CreateModelElement(DXW.RunTrackChangeType? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.RunTrackChangeType? openXmlElement, DMW.RunTrackChangeType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunTrackChangeType value)
    where OpenXmlElementType: DXW.RunTrackChangeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.RunTrackChangeType openXmlElement, DMW.RunTrackChangeType value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.Id);
  }
}
