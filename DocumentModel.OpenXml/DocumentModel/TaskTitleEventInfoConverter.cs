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
