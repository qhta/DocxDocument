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
