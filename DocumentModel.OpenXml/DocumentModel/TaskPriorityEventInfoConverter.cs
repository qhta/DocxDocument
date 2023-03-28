namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskPriorityEventInfo Class converter from/to OpenXml.
///</summary>
public static class TaskPriorityEventInfoConverter
{
  /// <summary>
  /// value, this property is only available in Office 2021 and later.
  /// </summary>
  private static Int32? GetValue(DXO2021DocTasks.TaskPriorityEventInfo openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  private static bool CmpValue(DXO2021DocTasks.TaskPriorityEventInfo openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Value?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Value?.Value, value);
    return false;
  }
  
  private static void SetValue(DXO2021DocTasks.TaskPriorityEventInfo openXmlElement, Int32? value)
  {
    openXmlElement.Value = value;
  }
  
  public static DocumentModel.TaskPriorityEventInfo? CreateModelElement(DXO2021DocTasks.TaskPriorityEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskPriorityEventInfo();
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.TaskPriorityEventInfo? openXmlElement, DM.TaskPriorityEventInfo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpValue(openXmlElement, value.Value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskPriorityEventInfo value)
    where OpenXmlElementType: DXO2021DocTasks.TaskPriorityEventInfo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DocTasks.TaskPriorityEventInfo openXmlElement, DM.TaskPriorityEventInfo value)
  {
    SetValue(openXmlElement, value?.Value);
  }
}
