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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPercentComplete(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
