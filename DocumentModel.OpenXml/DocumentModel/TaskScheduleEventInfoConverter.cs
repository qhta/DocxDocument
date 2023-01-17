namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskScheduleEventInfo Class.
/// </summary>
public static class TaskScheduleEventInfoConverter
{
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetStartDate(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo openXmlElement)
  {
    return openXmlElement.StartDate?.Value;
  }
  
  private static void SetStartDate(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo openXmlElement, DateTime? value)
  {
    openXmlElement.StartDate = value;
  }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetDueDate(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo openXmlElement)
  {
    return openXmlElement.DueDate?.Value;
  }
  
  private static void SetDueDate(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo openXmlElement, DateTime? value)
  {
    openXmlElement.DueDate = value;
  }
  
  public static DocumentModel.TaskScheduleEventInfo? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskScheduleEventInfo? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo, new()
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
