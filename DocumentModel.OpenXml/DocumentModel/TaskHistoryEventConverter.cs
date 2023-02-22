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
    return openXmlElement?.Time?.Value;
  }
  
  private static bool CmpTime(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Time?.Value == value) return true;
    diffs?.Add(objName, "Time", openXmlElement?.Time?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2021DocTasks.TaskHistoryEvent openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2021DocTasks.TaskHistoryEvent openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  private static DM.OpenXmlTaskUserElement? GetAttributionTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.AttributionTaskUser>();
    if (element != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAttributionTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value, DiffList? diffs, string? objName)
  {
    return DMX.OpenXmlTaskUserElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.AttributionTaskUser>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskAnchor>();
    if (element != null)
      return DMX.TaskAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskAnchor(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskAnchor? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.TaskAnchor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.AssignTaskUser>();
    if (element != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAssignTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value, DiffList? diffs, string? objName)
  {
    return DMX.OpenXmlTaskUserElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.AssignTaskUser>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.UnassignTaskUser>();
    if (element != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnassignTaskUser(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value, DiffList? diffs, string? objName)
  {
    return DMX.OpenXmlTaskUserElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.UnassignTaskUser>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXO2021DocTasks.TaskCreateEventInfo>() != null;
  }
  
  private static bool CmpTaskCreateEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskCreateEventInfo>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2021DocTasks.TaskCreateEventInfo", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskTitleEventInfo>();
    if (element != null)
      return DMX.TaskTitleEventInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskTitleEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskTitleEventInfo? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskTitleEventInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.TaskTitleEventInfo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskScheduleEventInfo>();
    if (element != null)
      return DMX.TaskScheduleEventInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskScheduleEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskScheduleEventInfo? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskScheduleEventInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.TaskScheduleEventInfo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskProgressEventInfo>();
    if (element != null)
      return DMX.TaskProgressEventInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskProgressEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskProgressEventInfo? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskProgressEventInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.TaskProgressEventInfo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskPriorityEventInfo>();
    if (element != null)
      return DMX.TaskPriorityEventInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskPriorityEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskPriorityEventInfo? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskPriorityEventInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.TaskPriorityEventInfo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXO2021DocTasks.TaskDeleteEventInfo>() != null;
  }
  
  private static bool CmpTaskDeleteEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskDeleteEventInfo>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2021DocTasks.TaskDeleteEventInfo", val, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUndeleteEventInfo>() != null;
  }
  
  private static bool CmpTaskUndeleteEventInfo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUndeleteEventInfo>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2021DocTasks.TaskUndeleteEventInfo", val, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUnassignAll>() != null;
  }
  
  private static bool CmpTaskUnassignAll(DXO2021DocTasks.TaskHistoryEvent openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUnassignAll>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2021DocTasks.TaskUnassignAll", val, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskUndo>();
    if (element != null)
      return DMX.TaskUndoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskUndo(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskUndo? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskUndoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.TaskUndo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>();
    if (element != null)
      return DMX.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMX.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.TaskHistoryEvent? CreateModelElement(DXO2021DocTasks.TaskHistoryEvent? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2021DocTasks.TaskHistoryEvent? openXmlElement, DM.TaskHistoryEvent? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTime(openXmlElement, value.Time, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpAttributionTaskUser(openXmlElement, value.AttributionTaskUser, diffs, objName))
        ok = false;
      if (!CmpTaskAnchor(openXmlElement, value.TaskAnchor, diffs, objName))
        ok = false;
      if (!CmpAssignTaskUser(openXmlElement, value.AssignTaskUser, diffs, objName))
        ok = false;
      if (!CmpUnassignTaskUser(openXmlElement, value.UnassignTaskUser, diffs, objName))
        ok = false;
      if (!CmpTaskCreateEventInfo(openXmlElement, value.TaskCreateEventInfo, diffs, objName))
        ok = false;
      if (!CmpTaskTitleEventInfo(openXmlElement, value.TaskTitleEventInfo, diffs, objName))
        ok = false;
      if (!CmpTaskScheduleEventInfo(openXmlElement, value.TaskScheduleEventInfo, diffs, objName))
        ok = false;
      if (!CmpTaskProgressEventInfo(openXmlElement, value.TaskProgressEventInfo, diffs, objName))
        ok = false;
      if (!CmpTaskPriorityEventInfo(openXmlElement, value.TaskPriorityEventInfo, diffs, objName))
        ok = false;
      if (!CmpTaskDeleteEventInfo(openXmlElement, value.TaskDeleteEventInfo, diffs, objName))
        ok = false;
      if (!CmpTaskUndeleteEventInfo(openXmlElement, value.TaskUndeleteEventInfo, diffs, objName))
        ok = false;
      if (!CmpTaskUnassignAll(openXmlElement, value.TaskUnassignAll, diffs, objName))
        ok = false;
      if (!CmpTaskUndo(openXmlElement, value.TaskUndo, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskHistoryEvent value)
    where OpenXmlElementType: DXO2021DocTasks.TaskHistoryEvent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DocTasks.TaskHistoryEvent openXmlElement, DM.TaskHistoryEvent value)
  {
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
  }
}
