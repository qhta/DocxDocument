namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskPriorityEventInfo Class.
/// </summary>
public static class TaskPriorityEventInfoConverter
{
  /// <summary>
  /// value, this property is only available in Office 2021 and later.
  /// </summary>
  private static Int32? GetValue(DXO2021DocTasks.TaskPriorityEventInfo openXmlElement)
  {
    return openXmlElement.Value?.Value;
  }
  
  private static void SetValue(DXO2021DocTasks.TaskPriorityEventInfo openXmlElement, Int32? value)
  {
    openXmlElement.Value = value;
  }
  
  public static DM.TaskPriorityEventInfo? CreateModelElement(DXO2021DocTasks.TaskPriorityEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskPriorityEventInfo();
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskPriorityEventInfo? value)
    where OpenXmlElementType: DXO2021DocTasks.TaskPriorityEventInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetValue(openXmlElement, value?.Value);
      return openXmlElement;
    }
    return default;
  }
}
