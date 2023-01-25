namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskTitleEventInfo Class.
/// </summary>
public static class TaskTitleEventInfoConverter
{
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetTitle(DXO2021DocTasks.TaskTitleEventInfo openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static bool CmpTitle(DXO2021DocTasks.TaskTitleEventInfo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Title?.Value == value;
  }
  
  private static void SetTitle(DXO2021DocTasks.TaskTitleEventInfo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  public static DM.TaskTitleEventInfo? CreateModelElement(DXO2021DocTasks.TaskTitleEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskTitleEventInfo();
      value.Title = GetTitle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.TaskTitleEventInfo? openXmlElement, DM.TaskTitleEventInfo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskTitleEventInfo? value)
    where OpenXmlElementType: DXO2021DocTasks.TaskTitleEventInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTitle(openXmlElement, value?.Title);
      return openXmlElement;
    }
    return default;
  }
}
