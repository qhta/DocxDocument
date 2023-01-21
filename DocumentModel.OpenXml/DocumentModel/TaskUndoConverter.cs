namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskUndo Class.
/// </summary>
public static class TaskUndoConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO2021DocTasks.TaskUndo openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2021DocTasks.TaskUndo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DM.TaskUndo? CreateModelElement(DXO2021DocTasks.TaskUndo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskUndo();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskUndo? value)
    where OpenXmlElementType: DXO2021DocTasks.TaskUndo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
