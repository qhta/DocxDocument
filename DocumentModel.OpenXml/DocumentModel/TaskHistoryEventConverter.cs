namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public static class TaskHistoryEventConverter
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetTime(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement.Time?.Value;
  }
  
  private static void SetTime(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DateTime? value)
  {
    openXmlElement.Time = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2021DocTasks.TaskHistoryEvent openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  private static DM.OpenXmlTaskUserElement? GetAttributionTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.AttributionTaskUser>();
    if (itemElement != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAttributionTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.AttributionTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DXO2021DocTasks.AttributionTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  private static DM.TaskAnchor? GetTaskAnchor(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskAnchor>();
    if (itemElement != null)
      return DMX.TaskAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskAnchor(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskAnchorConverter.CreateOpenXmlElement<DXO2021DocTasks.TaskAnchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.OpenXmlTaskUserElement? GetAssignTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.AssignTaskUser>();
    if (itemElement != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAssignTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.AssignTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DXO2021DocTasks.AssignTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.OpenXmlTaskUserElement? GetUnassignTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.UnassignTaskUser>();
    if (itemElement != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUnassignTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.UnassignTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DXO2021DocTasks.UnassignTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskCreateEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskCreateEventInfo>();
    return itemElement != null;
  }
  
  private static void SetTaskCreateEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskCreateEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2021DocTasks.TaskCreateEventInfo();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.TaskTitleEventInfo? GetTaskTitleEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskTitleEventInfo>();
    if (itemElement != null)
      return DMX.TaskTitleEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskTitleEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskTitleEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskTitleEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskTitleEventInfoConverter.CreateOpenXmlElement<DXO2021DocTasks.TaskTitleEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.TaskScheduleEventInfo? GetTaskScheduleEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskScheduleEventInfo>();
    if (itemElement != null)
      return DMX.TaskScheduleEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskScheduleEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskScheduleEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskScheduleEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskScheduleEventInfoConverter.CreateOpenXmlElement<DXO2021DocTasks.TaskScheduleEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.TaskProgressEventInfo? GetTaskProgressEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskProgressEventInfo>();
    if (itemElement != null)
      return DMX.TaskProgressEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskProgressEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskProgressEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskProgressEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskProgressEventInfoConverter.CreateOpenXmlElement<DXO2021DocTasks.TaskProgressEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.TaskPriorityEventInfo? GetTaskPriorityEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskPriorityEventInfo>();
    if (itemElement != null)
      return DMX.TaskPriorityEventInfoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskPriorityEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskPriorityEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskPriorityEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskPriorityEventInfoConverter.CreateOpenXmlElement<DXO2021DocTasks.TaskPriorityEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskDeleteEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskDeleteEventInfo>();
    return itemElement != null;
  }
  
  private static void SetTaskDeleteEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskDeleteEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2021DocTasks.TaskDeleteEventInfo();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskUndeleteEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUndeleteEventInfo>();
    return itemElement != null;
  }
  
  private static void SetTaskUndeleteEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUndeleteEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2021DocTasks.TaskUndeleteEventInfo();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskUnassignAll(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUnassignAll>();
    return itemElement != null;
  }
  
  private static void SetTaskUnassignAll(DXO2021DocTasks.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUnassignAll>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2021DocTasks.TaskUnassignAll();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.TaskUndo? GetTaskUndo(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskUndo>();
    if (itemElement != null)
      return DMX.TaskUndoConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTaskUndo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskUndo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUndo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskUndoConverter.CreateOpenXmlElement<DXO2021DocTasks.TaskUndo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ExtensionList? GetExtensionList(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>();
    if (itemElement != null)
      return DMX.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ExtensionListConverter.CreateOpenXmlElement<DXO2021DocTasks.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.TaskHistoryEvent? CreateModelElement(DXO2021DocTasks.TaskHistoryEvent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskHistoryEvent();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskHistoryEvent? value)
    where OpenXmlElementType: DXO2021DocTasks.TaskHistoryEvent, new()
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
