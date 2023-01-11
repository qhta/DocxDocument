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
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.TaskUndo? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskUndo();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskUndo? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
