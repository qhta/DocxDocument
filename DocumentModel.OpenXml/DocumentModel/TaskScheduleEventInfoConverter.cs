namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public static class TaskScheduleEventInfoConverter
{
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetStartDate(DXO21DT.TaskScheduleEventInfo openXmlElement)
  {
    return openXmlElement?.StartDate?.Value;
  }
  
  private static bool CmpStartDate(DXO21DT.TaskScheduleEventInfo openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.StartDate?.Value == value) return true;
    diffs?.Add(objName, "StartDate", openXmlElement?.StartDate?.Value, value);
    return false;
  }
  
  private static void SetStartDate(DXO21DT.TaskScheduleEventInfo openXmlElement, DateTime? value)
  {
    openXmlElement.StartDate = value;
  }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetDueDate(DXO21DT.TaskScheduleEventInfo openXmlElement)
  {
    return openXmlElement?.DueDate?.Value;
  }
  
  private static bool CmpDueDate(DXO21DT.TaskScheduleEventInfo openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DueDate?.Value == value) return true;
    diffs?.Add(objName, "DueDate", openXmlElement?.DueDate?.Value, value);
    return false;
  }
  
  private static void SetDueDate(DXO21DT.TaskScheduleEventInfo openXmlElement, DateTime? value)
  {
    openXmlElement.DueDate = value;
  }
  
  public static DocumentModel.TaskScheduleEventInfo? CreateModelElement(DXO21DT.TaskScheduleEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskScheduleEventInfo();
      value.StartDate = GetStartDate(openXmlElement);
      value.DueDate = GetDueDate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.TaskScheduleEventInfo? openXmlElement, DM.TaskScheduleEventInfo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStartDate(openXmlElement, value.StartDate, diffs, objName, propName))
        ok = false;
      if (!CmpDueDate(openXmlElement, value.DueDate, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskScheduleEventInfo value)
    where OpenXmlElementType: DXO21DT.TaskScheduleEventInfo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.TaskScheduleEventInfo openXmlElement, DM.TaskScheduleEventInfo value)
  {
    SetStartDate(openXmlElement, value?.StartDate);
    SetDueDate(openXmlElement, value?.DueDate);
  }
}
