namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskPriorityEventInfo Class.
/// </summary>
public static class TaskPriorityEventInfoConverter
{
  /// <summary>
  /// value, this property is only available in Office 2021 and later.
  /// </summary>
  public static Int32? GetValue(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo? openXmlElement)
  {
    return openXmlElement?.Value?.Value;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Value = value;
  }
  
  public static DocumentModel.TaskPriorityEventInfo? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskPriorityEventInfo();
      value.Value = GetValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskPriorityEventInfo? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo, new()
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
