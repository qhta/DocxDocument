namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public static class TaskHistoryConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.TaskHistoryEvent>? GetTaskHistoryEvents(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.TaskHistoryEvent>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>())
      {
        var newItem = DocumentModel.OpenXml.TaskHistoryEventConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTaskHistoryEvents(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.TaskHistoryEvent>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.TaskHistoryEventConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.TaskHistory? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskHistory();
      value.TaskHistoryEvents = GetTaskHistoryEvents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskHistory? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
