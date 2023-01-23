namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public static class TaskScheduleEventInfoConverter
{
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetStartDate(DXO2021DocTasks.TaskScheduleEventInfo openXmlElement)
  {
    return openXmlElement.StartDate?.Value;
  }
  
  private static bool CmpStartDate(DXO2021DocTasks.TaskScheduleEventInfo openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.StartDate?.Value == value;
  }
  
  private static void SetStartDate(DXO2021DocTasks.TaskScheduleEventInfo openXmlElement, DateTime? value)
  {
    openXmlElement.StartDate = value;
  }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetDueDate(DXO2021DocTasks.TaskScheduleEventInfo openXmlElement)
  {
    return openXmlElement.DueDate?.Value;
  }
  
  private static bool CmpDueDate(DXO2021DocTasks.TaskScheduleEventInfo openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DueDate?.Value == value;
  }
  
  private static void SetDueDate(DXO2021DocTasks.TaskScheduleEventInfo openXmlElement, DateTime? value)
  {
    openXmlElement.DueDate = value;
  }
  
  public static DM.TaskScheduleEventInfo? CreateModelElement(DXO2021DocTasks.TaskScheduleEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskScheduleEventInfo();
      value.StartDate = GetStartDate(openXmlElement);
      value.DueDate = GetDueDate(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.TaskScheduleEventInfo? openXmlElement, DM.TaskScheduleEventInfo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStartDate(openXmlElement, value.StartDate, diffs, objName))
        ok = false;
      if (!CmpDueDate(openXmlElement, value.DueDate, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskScheduleEventInfo? value)
    where OpenXmlElementType: DXO2021DocTasks.TaskScheduleEventInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStartDate(openXmlElement, value?.StartDate);
      SetDueDate(openXmlElement, value?.DueDate);
      return openXmlElement;
    }
    return default;
  }
}
