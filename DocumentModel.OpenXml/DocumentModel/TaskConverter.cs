namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Task Class.
/// </summary>
public static class TaskConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO2021DocTasks.Task openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2021DocTasks.Task openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2021DocTasks.Task openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  private static DM.TaskAnchor? GetTaskAnchor(DXO2021DocTasks.Task openXmlElement)
  {
    return DMX.TaskAnchorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskAnchor>());
  }
  
  private static bool CmpTaskAnchor(DXO2021DocTasks.Task openXmlElement, DM.TaskAnchor? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskAnchorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskAnchor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTaskAnchor(DXO2021DocTasks.Task openXmlElement, DM.TaskAnchor? value)
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
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  private static DM.TaskHistory? GetTaskHistory(DXO2021DocTasks.Task openXmlElement)
  {
    return DMX.TaskHistoryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskHistory>());
  }
  
  private static bool CmpTaskHistory(DXO2021DocTasks.Task openXmlElement, DM.TaskHistory? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskHistoryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.TaskHistory>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTaskHistory(DXO2021DocTasks.Task openXmlElement, DM.TaskHistory? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.TaskHistory>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskHistoryConverter.CreateOpenXmlElement<DXO2021DocTasks.TaskHistory>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DM.ExtensionList? GetExtensionList(DXO2021DocTasks.Task openXmlElement)
  {
    return DMX.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2021DocTasks.Task openXmlElement, DM.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMX.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2021DocTasks.Task openXmlElement, DM.ExtensionList? value)
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
  
  public static DM.Task? CreateModelElement(DXO2021DocTasks.Task? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Task();
      value.Id = GetId(openXmlElement);
      value.TaskAnchor = GetTaskAnchor(openXmlElement);
      value.TaskHistory = GetTaskHistory(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.Task? openXmlElement, DM.Task? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpTaskAnchor(openXmlElement, value.TaskAnchor, diffs, objName))
        ok = false;
      if (!CmpTaskHistory(openXmlElement, value.TaskHistory, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Task? value)
    where OpenXmlElementType: DXO2021DocTasks.Task, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetTaskAnchor(openXmlElement, value?.TaskAnchor);
      SetTaskHistory(openXmlElement, value?.TaskHistory);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
