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
    return openXmlElement.PercentComplete?.Value;
  }
  
  private static void SetPercentComplete(DXO2021DocTasks.TaskProgressEventInfo openXmlElement, Int32? value)
  {
    openXmlElement.PercentComplete = value;
  }
  
  public static DM.TaskProgressEventInfo? CreateModelElement(DXO2021DocTasks.TaskProgressEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskProgressEventInfo();
      value.PercentComplete = GetPercentComplete(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskProgressEventInfo? value)
    where OpenXmlElementType: DXO2021DocTasks.TaskProgressEventInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPercentComplete(openXmlElement, value?.PercentComplete);
      return openXmlElement;
    }
    return default;
  }
}
