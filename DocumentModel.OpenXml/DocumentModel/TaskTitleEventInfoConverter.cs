namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskTitleEventInfo Class.
/// </summary>
public static class TaskTitleEventInfoConverter
{
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }
  
  public static DocumentModel.TaskTitleEventInfo? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskTitleEventInfo();
      value.Title = GetTitle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskTitleEventInfo? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo, new()
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
