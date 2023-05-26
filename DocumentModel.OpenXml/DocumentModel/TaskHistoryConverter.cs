namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public static class TaskHistoryConverter
{
  private static Collection<DM.TaskHistoryEvent>? GetTaskHistoryEvents(DXO21DT.TaskHistory openXmlElement)
  {
    var collection = new Collection<DM.TaskHistoryEvent>();
    foreach (var item in openXmlElement.Elements<DXO21DT.TaskHistoryEvent>())
    {
      var newItem = DMX.TaskHistoryEventConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTaskHistoryEvents(DXO21DT.TaskHistory openXmlElement, Collection<DM.TaskHistoryEvent>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO21DT.TaskHistoryEvent>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMX.TaskHistoryEventConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTaskHistoryEvents(DXO21DT.TaskHistory openXmlElement, Collection<DM.TaskHistoryEvent>? value)
  {
    openXmlElement.RemoveAllChildren<DXO21DT.TaskHistoryEvent>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TaskHistoryEventConverter.CreateOpenXmlElement<DXO21DT.TaskHistoryEvent>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.TaskHistory? CreateModelElement(DXO21DT.TaskHistory? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskHistory();
      value.TaskHistoryEvents = GetTaskHistoryEvents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.TaskHistory? openXmlElement, DM.TaskHistory? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTaskHistoryEvents(openXmlElement, value.TaskHistoryEvents, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskHistory value)
    where OpenXmlElementType: DXO21DT.TaskHistory, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.TaskHistory openXmlElement, DM.TaskHistory value)
  {
    SetTaskHistoryEvents(openXmlElement, value?.TaskHistoryEvents);
  }
}
