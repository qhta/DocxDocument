namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public static class TaskAnchorConverter
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  private static DM.CommentAnchor? GetCommentAnchor(DXO2021DocTasks.TaskAnchor openXmlElement)
  {
    return DMX.CommentAnchorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.CommentAnchor>());
  }
  
  private static bool CmpCommentAnchor(DXO2021DocTasks.TaskAnchor openXmlElement, DM.CommentAnchor? value, DiffList? diffs, string? objName)
  {
    return DMX.CommentAnchorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.CommentAnchor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCommentAnchor(DXO2021DocTasks.TaskAnchor openXmlElement, DM.CommentAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DocTasks.CommentAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CommentAnchorConverter.CreateOpenXmlElement<DXO2021DocTasks.CommentAnchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DM.ExtensionList? GetExtensionList(DXO2021DocTasks.TaskAnchor openXmlElement)
  {
    return DMX.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2021DocTasks.TaskAnchor openXmlElement, DM.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMX.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2021DocTasks.TaskAnchor openXmlElement, DM.ExtensionList? value)
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
  
  public static DM.TaskAnchor? CreateModelElement(DXO2021DocTasks.TaskAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TaskAnchor();
      value.CommentAnchor = GetCommentAnchor(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DocTasks.TaskAnchor? openXmlElement, DM.TaskAnchor? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCommentAnchor(openXmlElement, value.CommentAnchor, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TaskAnchor? value)
    where OpenXmlElementType: DXO2021DocTasks.TaskAnchor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCommentAnchor(openXmlElement, value?.CommentAnchor);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
