namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskUndo Class.
/// </summary>
public static class TaskUndoConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
