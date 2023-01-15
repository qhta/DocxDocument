namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the TaskAnchor Class.
/// </summary>
public static class TaskAnchorConverter
{
  /// <summary>
  ///   CommentAnchor.
  /// </summary>
  public static CommentAnchor? GetCommentAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>();
    if (itemElement != null)
      return CommentAnchorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCommentAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement, CommentAnchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CommentAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement, ExtensionList? value)
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

  public static TaskAnchor? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new TaskAnchor();
      value.CommentAnchor = GetCommentAnchor(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(TaskAnchor? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor, new()
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