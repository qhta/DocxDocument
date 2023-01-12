namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public static class TaskProgressEventInfoConverter
{
  /// <summary>
  /// percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  public static Int32? GetPercentComplete(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo? openXmlElement)
  {
    return openXmlElement?.PercentComplete?.Value;
  }
  
  public static void SetPercentComplete(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PercentComplete = value;
  }
  
  public static DocumentModel.TaskProgressEventInfo? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskProgressEventInfo();
      value.PercentComplete = GetPercentComplete(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskProgressEventInfo? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo, new()
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
