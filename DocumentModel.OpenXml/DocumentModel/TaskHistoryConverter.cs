namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public static class TaskHistoryConverter
{
  private static Collection<DM.TaskHistoryEvent> GetTaskHistoryEvents(DXO2021DocTasks.TaskHistory openXmlElement)
  {
    var collection = new Collection<DM.TaskHistoryEvent>();
    foreach (var item in openXmlElement.Elements<DXO2021DocTasks.TaskHistoryEvent>())
    {
      var newItem = DMX.TaskHistoryEventConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpTaskHistoryEvents(DXO2021DocTasks.TaskHistory openXmlElement, Collection<DM.TaskHistoryEvent>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetTaskHistoryEvents(DXO2021DocTasks.TaskHistory openXmlElement, Collection<DM.TaskHistoryEvent>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021DocTasks.TaskHistoryEvent>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TaskHistoryEventConverter.CreateOpenXmlElement<DXO2021DocTasks.TaskHistoryEvent>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.TaskHistory? CreateModelElement(DXO2021DocTasks.TaskHistory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskHistory();
      value.TaskHistoryEvents = GetTaskHistoryEvents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.TaskHistory? openXmlElement, DM.TaskHistory? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTaskHistoryEvents(openXmlElement, value.TaskHistoryEvents, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskHistory? value)
    where OpenXmlElementType: DXO2021DocTasks.TaskHistory, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTaskHistoryEvents(openXmlElement, value?.TaskHistoryEvents);
      return openXmlElement;
    }
    return default;
  }
}
