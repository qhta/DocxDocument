namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public static class TaskAnchorConverter
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  private static DM.CommentAnchor? GetCommentAnchor(DXO21DT.TaskAnchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.CommentAnchor>();
    if (element != null)
      return DMX.CommentAnchorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommentAnchor(DXO21DT.TaskAnchor openXmlElement, DM.CommentAnchor? value, DiffList? diffs, string? objName)
  {
    return DMX.CommentAnchorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.CommentAnchor>(), value, diffs, objName);
  }
  
  private static void SetCommentAnchor(DXO21DT.TaskAnchor openXmlElement, DM.CommentAnchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DT.CommentAnchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CommentAnchorConverter.CreateOpenXmlElement<DXO21DT.CommentAnchor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DM.ExtensionList? GetExtensionList(DXO21DT.TaskAnchor openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DT.ExtensionList>();
    if (element != null)
      return DMX.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO21DT.TaskAnchor openXmlElement, DM.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMX.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DT.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO21DT.TaskAnchor openXmlElement, DM.ExtensionList? value)
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
  
  public static DocumentModel.TaskAnchor? CreateModelElement(DXO21DT.TaskAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TaskAnchor();
      value.CommentAnchor = GetCommentAnchor(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DT.TaskAnchor? openXmlElement, DM.TaskAnchor? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.TaskAnchor value)
    where OpenXmlElementType: DXO21DT.TaskAnchor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DT.TaskAnchor openXmlElement, DM.TaskAnchor value)
  {
    SetCommentAnchor(openXmlElement, value?.CommentAnchor);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
