using DocumentFormat.OpenXml.Office2021.DocumentTasks;

namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the TaskHistoryEvent Class.
/// </summary>
public static class TaskHistoryEventConverter
{
  /// <summary>
  ///   time, this property is only available in Office 2021 and later.
  /// </summary>
  public static DateTime? GetTime(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    return openXmlElement?.Time?.Value;
  }

  public static void SetTime(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, DateTime? value)
  {
    if (openXmlElement != null)
      openXmlElement.Time = value;
  }

  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   AttributionTaskUser.
  /// </summary>
  public static OpenXmlTaskUserElement? GetAttributionTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AttributionTaskUser>();
    if (itemElement != null)
      return OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAttributionTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, OpenXmlTaskUserElement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AttributionTaskUser>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OpenXmlTaskUserElementConverter.CreateOpenXmlElement<AttributionTaskUser>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TaskAnchor.
  /// </summary>
  public static TaskAnchor? GetTaskAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
    if (itemElement != null)
      return TaskAnchorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, TaskAnchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OpenXmlTaskUserElement? GetAssignTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AssignTaskUser>();
    if (itemElement != null)
      return OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAssignTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, OpenXmlTaskUserElement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AssignTaskUser>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OpenXmlTaskUserElementConverter.CreateOpenXmlElement<AssignTaskUser>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OpenXmlTaskUserElement? GetUnassignTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<UnassignTaskUser>();
    if (itemElement != null)
      return OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUnassignTaskUser(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, OpenXmlTaskUserElement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UnassignTaskUser>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OpenXmlTaskUserElementConverter.CreateOpenXmlElement<UnassignTaskUser>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTaskCreateEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TaskCreateEventInfo>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTaskCreateEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TaskCreateEventInfo>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TaskCreateEventInfo();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TaskTitleEventInfo? GetTaskTitleEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>();
    if (itemElement != null)
      return TaskTitleEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskTitleEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, TaskTitleEventInfo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskTitleEventInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TaskScheduleEventInfo? GetTaskScheduleEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>();
    if (itemElement != null)
      return TaskScheduleEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskScheduleEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, TaskScheduleEventInfo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskScheduleEventInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TaskProgressEventInfo? GetTaskProgressEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>();
    if (itemElement != null)
      return TaskProgressEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskProgressEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, TaskProgressEventInfo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskProgressEventInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TaskPriorityEventInfo? GetTaskPriorityEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>();
    if (itemElement != null)
      return TaskPriorityEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskPriorityEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, TaskPriorityEventInfo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskPriorityEventInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTaskDeleteEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TaskDeleteEventInfo>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTaskDeleteEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TaskDeleteEventInfo>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TaskDeleteEventInfo();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTaskUndeleteEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TaskUndeleteEventInfo>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTaskUndeleteEventInfo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TaskUndeleteEventInfo>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TaskUndeleteEventInfo();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTaskUnassignAll(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TaskUnassignAll>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTaskUnassignAll(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TaskUnassignAll>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TaskUnassignAll();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TaskUndo? GetTaskUndo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>();
    if (itemElement != null)
      return TaskUndoConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTaskUndo(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, TaskUndo? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskUndoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement, ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TaskHistoryEvent? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new TaskHistoryEvent();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(TaskHistoryEvent? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent, new()
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