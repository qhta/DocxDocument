namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the TaskHistory Class.
/// </summary>
public static class TaskHistoryConverter
{
  public static Collection<TaskHistoryEvent>? GetTaskHistoryEvents(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<TaskHistoryEvent>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>())
      {
        var newItem = TaskHistoryEventConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetTaskHistoryEvents(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? openXmlElement, Collection<TaskHistoryEvent>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = TaskHistoryEventConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static TaskHistory? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new TaskHistory();
      value.TaskHistoryEvents = GetTaskHistoryEvents(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(TaskHistory? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory, new()
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