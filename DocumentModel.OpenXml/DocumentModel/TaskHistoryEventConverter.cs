namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public static class TaskHistoryEventConverter
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetTime(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement.Time?.Value;
  }
  
  private static void SetTime(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DateTime? value)
  {
    openXmlElement.Time = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  private static DocumentModel.OpenXmlTaskUserElement? GetAttributionTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.AttributionTaskUser>();
    if (itemElement != null)
      return DocumentModel.OpenXml.OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAttributionTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.AttributionTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.AttributionTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  private static DocumentModel.TaskAnchor? GetTaskAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.TaskAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.TaskAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.OpenXmlTaskUserElement? GetAssignTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.AssignTaskUser>();
    if (itemElement != null)
      return DocumentModel.OpenXml.OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAssignTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.AssignTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.AssignTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.OpenXmlTaskUserElement? GetUnassignTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.UnassignTaskUser>();
    if (itemElement != null)
      return DocumentModel.OpenXml.OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnassignTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.UnassignTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.UnassignTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskCreateEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo>();
    return itemElement != null;
  }
  
  private static void SetTaskCreateEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.TaskTitleEventInfo? GetTaskTitleEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskTitleEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskTitleEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.TaskTitleEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.TaskTitleEventInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.TaskScheduleEventInfo? GetTaskScheduleEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskScheduleEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskScheduleEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.TaskScheduleEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.TaskScheduleEventInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.TaskProgressEventInfo? GetTaskProgressEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskProgressEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskProgressEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.TaskProgressEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.TaskProgressEventInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.TaskPriorityEventInfo? GetTaskPriorityEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskPriorityEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskPriorityEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.TaskPriorityEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.TaskPriorityEventInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskDeleteEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo>();
    return itemElement != null;
  }
  
  private static void SetTaskDeleteEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskUndeleteEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo>();
    return itemElement != null;
  }
  
  private static void SetTaskUndeleteEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskUnassignAll(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll>();
    return itemElement != null;
  }
  
  private static void SetTaskUnassignAll(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.TaskUndo? GetTaskUndo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskUndoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskUndo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.TaskUndo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.TaskUndoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement, DocumentModel.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.TaskHistoryEvent? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskHistoryEvent();
      value.Time = GetTime(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.AttributionTaskUser = GetAttributionTaskUser(openXmlElement);
      value.TaskAnchor = GetTaskAnchor(openXmlElement);
      value.AssignTaskUser = GetAssignTaskUser(openXmlElement);
      value.UnassignTaskUser = GetUnassignTaskUser(openXmlElement);
      value.TaskCreateEventInfo = GetTaskCreateEventInfo(openXmlElement);
      value.TaskTitleEventInfo = GetTaskTitleEventInfo(openXmlElement);
      value.TaskScheduleEventInfo = GetTaskScheduleEventInfo(openXmlElement);
      value.TaskProgressEventInfo = GetTaskProgressEventInfo(openXmlElement);
      value.TaskPriorityEventInfo = GetTaskPriorityEventInfo(openXmlElement);
      value.TaskDeleteEventInfo = GetTaskDeleteEventInfo(openXmlElement);
      value.TaskUndeleteEventInfo = GetTaskUndeleteEventInfo(openXmlElement);
      value.TaskUnassignAll = GetTaskUnassignAll(openXmlElement);
      value.TaskUndo = GetTaskUndo(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskHistoryEvent? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTime(openXmlElement, value?.Time);
      SetId(openXmlElement, value?.Id);
      SetAttributionTaskUser(openXmlElement, value?.AttributionTaskUser);
      SetTaskAnchor(openXmlElement, value?.TaskAnchor);
      SetAssignTaskUser(openXmlElement, value?.AssignTaskUser);
      SetUnassignTaskUser(openXmlElement, value?.UnassignTaskUser);
      SetTaskCreateEventInfo(openXmlElement, value?.TaskCreateEventInfo);
      SetTaskTitleEventInfo(openXmlElement, value?.TaskTitleEventInfo);
      SetTaskScheduleEventInfo(openXmlElement, value?.TaskScheduleEventInfo);
      SetTaskProgressEventInfo(openXmlElement, value?.TaskProgressEventInfo);
      SetTaskPriorityEventInfo(openXmlElement, value?.TaskPriorityEventInfo);
      SetTaskDeleteEventInfo(openXmlElement, value?.TaskDeleteEventInfo);
      SetTaskUndeleteEventInfo(openXmlElement, value?.TaskUndeleteEventInfo);
      SetTaskUnassignAll(openXmlElement, value?.TaskUnassignAll);
      SetTaskUndo(openXmlElement, value?.TaskUndo);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
