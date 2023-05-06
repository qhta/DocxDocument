namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Task Class.
/// </summary>
public static class TaskConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  private static String? GetId(DXO21DT.Task openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO21DT.Task openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO21DT.Task openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  private static DM.TaskAnchor? GetTaskAnchor(DXO21DT.Task openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.TaskAnchor>();
    if (element != null)
      return DMX.TaskAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskAnchor(DXO21DT.Task openXmlElement, DM.TaskAnchor? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.TaskAnchor>(), value, diffs, objName);
  }
  
  private static void SetTaskAnchor(DXO21DT.Task openXmlElement, DM.TaskAnchor? value)
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
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  private static DM.TaskHistory? GetTaskHistory(DXO21DT.Task openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.TaskHistory>();
    if (element != null)
      return DMX.TaskHistoryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTaskHistory(DXO21DT.Task openXmlElement, DM.TaskHistory? value, DiffList? diffs, string? objName)
  {
    return DMX.TaskHistoryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.TaskHistory>(), value, diffs, objName);
  }
  
  private static void SetTaskHistory(DXO21DT.Task openXmlElement, DM.TaskHistory? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.TaskHistory>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TaskHistoryConverter.CreateOpenXmlElement<DXO21DT.TaskHistory>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DM.ExtensionList? GetExtensionList(DXO21DT.Task openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.ExtensionList>();
    if (element != null)
      return DMX.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO21DT.Task openXmlElement, DM.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMX.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO21DT.Task openXmlElement, DM.ExtensionList? value)
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
  
  public static DocumentModel.Task? CreateModelElement(DXO21DT.Task? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Task();
      value.Id = GetId(openXmlElement);
      value.TaskAnchor = GetTaskAnchor(openXmlElement);
      value.TaskHistory = GetTaskHistory(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.Task? openXmlElement, DM.Task? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Task value)
    where OpenXmlElementType: DXO21DT.Task, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.Task openXmlElement, DM.Task value)
  {
    SetId(openXmlElement, value?.Id);
    SetTaskAnchor(openXmlElement, value?.TaskAnchor);
    SetTaskHistory(openXmlElement, value?.TaskHistory);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
