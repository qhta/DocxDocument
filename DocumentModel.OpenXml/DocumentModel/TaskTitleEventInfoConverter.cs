namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskTitleEventInfo Class converter from/to OpenXml.
///</summary>
public static class TaskTitleEventInfoConverter
{
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetTitle(DXO2021DocTasks.TaskTitleEventInfo openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXO2021DocTasks.TaskTitleEventInfo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXO2021DocTasks.TaskTitleEventInfo openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.TaskTitleEventInfo? CreateModelElement(DXO2021DocTasks.TaskTitleEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskTitleEventInfo();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskTitleEventInfo value)
    where OpenXmlElementType: DXO2021DocTasks.TaskTitleEventInfo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DocTasks.TaskTitleEventInfo openXmlElement, DM.TaskTitleEventInfo value)
  {
    SetTitle(openXmlElement, value?.Title);
  }
}
