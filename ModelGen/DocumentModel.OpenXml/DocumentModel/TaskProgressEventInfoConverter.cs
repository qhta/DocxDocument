namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public static class TaskProgressEventInfoConverter
{
  /// <summary>
  /// percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  private static Int32? GetPercentComplete(DXO2021DocTasks.TaskProgressEventInfo openXmlElement)
  {
    return openXmlElement?.PercentComplete?.Value;
  }
  
  private static bool CmpPercentComplete(DXO2021DocTasks.TaskProgressEventInfo openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PercentComplete?.Value == value) return true;
    diffs?.Add(objName, "PercentComplete", openXmlElement?.PercentComplete?.Value, value);
    return false;
  }
  
  private static void SetPercentComplete(DXO2021DocTasks.TaskProgressEventInfo openXmlElement, Int32? value)
  {
    openXmlElement.PercentComplete = value;
  }
  
  public static DocumentModel.TaskProgressEventInfo? CreateModelElement(DXO2021DocTasks.TaskProgressEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskProgressEventInfo();
      value.PercentComplete = GetPercentComplete(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.TaskProgressEventInfo? openXmlElement, DM.TaskProgressEventInfo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPercentComplete(openXmlElement, value.PercentComplete, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskProgressEventInfo value)
    where OpenXmlElementType: DXO2021DocTasks.TaskProgressEventInfo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DocTasks.TaskProgressEventInfo openXmlElement, DM.TaskProgressEventInfo value)
  {
    SetPercentComplete(openXmlElement, value?.PercentComplete);
  }
}
