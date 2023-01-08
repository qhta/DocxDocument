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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
