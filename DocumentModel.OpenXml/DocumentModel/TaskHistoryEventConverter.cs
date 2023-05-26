namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public static class TaskHistoryEventConverter
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  private static DateTime? GetTime(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement?.Time?.Value;
  }
  
  private static bool CmpTime(DXO21DT.TaskHistoryEvent openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Time?.Value == value) return true;
    diffs?.Add(objName, "Time", openXmlElement?.Time?.Value, value);
    return false;
  }
  
  private static void SetTime(DXO21DT.TaskHistoryEvent openXmlElement, DateTime? value)
  {
    openXmlElement.Time = value;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO21DT.TaskHistoryEvent openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO21DT.TaskHistoryEvent openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  private static DM.OpenXmlTaskUserElement? GetAttributionTaskUser(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.AttributionTaskUser>();
    if (element != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAttributionTaskUser(DXO21DT.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.OpenXmlTaskUserElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.AttributionTaskUser>(), value, diffs, objName, propName);
  }
  
  private static void SetAttributionTaskUser(DXO21DT.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.AttributionTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DXO21DT.AttributionTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  private static DM.TaskAnchor? GetTaskAnchor(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.TaskAnchor>();
    if (element != null)
      return DMX.TaskAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskAnchor(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskAnchor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.TaskAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.TaskAnchor>(), value, diffs, objName, propName);
  }
  
  private static void SetTaskAnchor(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskAnchorConverter.CreateOpenXmlElement<DXO21DT.TaskAnchor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.OpenXmlTaskUserElement? GetAssignTaskUser(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.AssignTaskUser>();
    if (element != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAssignTaskUser(DXO21DT.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.OpenXmlTaskUserElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.AssignTaskUser>(), value, diffs, objName, propName);
  }
  
  private static void SetAssignTaskUser(DXO21DT.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.AssignTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DXO21DT.AssignTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.OpenXmlTaskUserElement? GetUnassignTaskUser(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.UnassignTaskUser>();
    if (element != null)
      return DMX.OpenXmlTaskUserElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnassignTaskUser(DXO21DT.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.OpenXmlTaskUserElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.UnassignTaskUser>(), value, diffs, objName, propName);
  }
  
  private static void SetUnassignTaskUser(DXO21DT.TaskHistoryEvent openXmlElement, DM.OpenXmlTaskUserElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.UnassignTaskUser>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OpenXmlTaskUserElementConverter.CreateOpenXmlElement<DXO21DT.UnassignTaskUser>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskCreateEventInfo(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO21DT.TaskCreateEventInfo>() != null;
  }
  
  private static bool CmpTaskCreateEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO21DT.TaskCreateEventInfo>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO21DT.TaskCreateEventInfo", val, value);
    return false;
  }
  
  private static void SetTaskCreateEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskCreateEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO21DT.TaskCreateEventInfo();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.TaskTitleEventInfo? GetTaskTitleEventInfo(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.TaskTitleEventInfo>();
    if (element != null)
      return DMX.TaskTitleEventInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskTitleEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskTitleEventInfo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.TaskTitleEventInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.TaskTitleEventInfo>(), value, diffs, objName, propName);
  }
  
  private static void SetTaskTitleEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskTitleEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskTitleEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskTitleEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskTitleEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.TaskScheduleEventInfo? GetTaskScheduleEventInfo(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.TaskScheduleEventInfo>();
    if (element != null)
      return DMX.TaskScheduleEventInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskScheduleEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskScheduleEventInfo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.TaskScheduleEventInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.TaskScheduleEventInfo>(), value, diffs, objName, propName);
  }
  
  private static void SetTaskScheduleEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskScheduleEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskScheduleEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskScheduleEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskScheduleEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.TaskProgressEventInfo? GetTaskProgressEventInfo(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.TaskProgressEventInfo>();
    if (element != null)
      return DMX.TaskProgressEventInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskProgressEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskProgressEventInfo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.TaskProgressEventInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.TaskProgressEventInfo>(), value, diffs, objName, propName);
  }
  
  private static void SetTaskProgressEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskProgressEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskProgressEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskProgressEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskProgressEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.TaskPriorityEventInfo? GetTaskPriorityEventInfo(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.TaskPriorityEventInfo>();
    if (element != null)
      return DMX.TaskPriorityEventInfoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskPriorityEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskPriorityEventInfo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.TaskPriorityEventInfoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.TaskPriorityEventInfo>(), value, diffs, objName, propName);
  }
  
  private static void SetTaskPriorityEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskPriorityEventInfo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskPriorityEventInfo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskPriorityEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskPriorityEventInfo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskDeleteEventInfo(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO21DT.TaskDeleteEventInfo>() != null;
  }
  
  private static bool CmpTaskDeleteEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO21DT.TaskDeleteEventInfo>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO21DT.TaskDeleteEventInfo", val, value);
    return false;
  }
  
  private static void SetTaskDeleteEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskDeleteEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO21DT.TaskDeleteEventInfo();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskUndeleteEventInfo(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO21DT.TaskUndeleteEventInfo>() != null;
  }
  
  private static bool CmpTaskUndeleteEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO21DT.TaskUndeleteEventInfo>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO21DT.TaskUndeleteEventInfo", val, value);
    return false;
  }
  
  private static void SetTaskUndeleteEventInfo(DXO21DT.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskUndeleteEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO21DT.TaskUndeleteEventInfo();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetTaskUnassignAll(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO21DT.TaskUnassignAll>() != null;
  }
  
  private static bool CmpTaskUnassignAll(DXO21DT.TaskHistoryEvent openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO21DT.TaskUnassignAll>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO21DT.TaskUnassignAll", val, value);
    return false;
  }
  
  private static void SetTaskUnassignAll(DXO21DT.TaskHistoryEvent openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskUnassignAll>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO21DT.TaskUnassignAll();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.TaskUndo? GetTaskUndo(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.TaskUndo>();
    if (element != null)
      return DMX.TaskUndoConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskUndo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskUndo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.TaskUndoConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.TaskUndo>(), value, diffs, objName, propName);
  }
  
  private static void SetTaskUndo(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskUndo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskUndo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskUndoConverter.CreateOpenXmlElement<DXO21DT.TaskUndo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.ExtensionList? GetExtensionList(DXO21DT.TaskHistoryEvent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.ExtensionList>();
    if (element != null)
      return DMX.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO21DT.TaskHistoryEvent openXmlElement, DM.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXO21DT.TaskHistoryEvent openXmlElement, DM.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ExtensionListConverter.CreateOpenXmlElement<DXO21DT.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.TaskHistoryEvent? CreateModelElement(DXO21DT.TaskHistoryEvent? openXmlElement)
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
  
  public static bool CompareModelElement(DXO21DT.TaskHistoryEvent? openXmlElement, DM.TaskHistoryEvent? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTime(openXmlElement, value.Time, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpAttributionTaskUser(openXmlElement, value.AttributionTaskUser, diffs, objName, propName))
        ok = false;
      if (!CmpTaskAnchor(openXmlElement, value.TaskAnchor, diffs, objName, propName))
        ok = false;
      if (!CmpAssignTaskUser(openXmlElement, value.AssignTaskUser, diffs, objName, propName))
        ok = false;
      if (!CmpUnassignTaskUser(openXmlElement, value.UnassignTaskUser, diffs, objName, propName))
        ok = false;
      if (!CmpTaskCreateEventInfo(openXmlElement, value.TaskCreateEventInfo, diffs, objName, propName))
        ok = false;
      if (!CmpTaskTitleEventInfo(openXmlElement, value.TaskTitleEventInfo, diffs, objName, propName))
        ok = false;
      if (!CmpTaskScheduleEventInfo(openXmlElement, value.TaskScheduleEventInfo, diffs, objName, propName))
        ok = false;
      if (!CmpTaskProgressEventInfo(openXmlElement, value.TaskProgressEventInfo, diffs, objName, propName))
        ok = false;
      if (!CmpTaskPriorityEventInfo(openXmlElement, value.TaskPriorityEventInfo, diffs, objName, propName))
        ok = false;
      if (!CmpTaskDeleteEventInfo(openXmlElement, value.TaskDeleteEventInfo, diffs, objName, propName))
        ok = false;
      if (!CmpTaskUndeleteEventInfo(openXmlElement, value.TaskUndeleteEventInfo, diffs, objName, propName))
        ok = false;
      if (!CmpTaskUnassignAll(openXmlElement, value.TaskUnassignAll, diffs, objName, propName))
        ok = false;
      if (!CmpTaskUndo(openXmlElement, value.TaskUndo, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskHistoryEvent value)
    where OpenXmlElementType: DXO21DT.TaskHistoryEvent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.TaskHistoryEvent openXmlElement, DM.TaskHistoryEvent value)
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
