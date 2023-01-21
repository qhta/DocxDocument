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
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.CommentAnchor>();
    if (itemElement != null)
      return DMX.CommentAnchorConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>();
    if (itemElement != null)
      return DMX.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
