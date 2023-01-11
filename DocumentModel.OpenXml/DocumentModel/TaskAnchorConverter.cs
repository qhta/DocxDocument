namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public static class TaskAnchorConverter
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public static DocumentModel.CommentAnchor? GetCommentAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.CommentAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommentAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement, DocumentModel.CommentAnchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.CommentAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement, DocumentModel.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.TaskAnchor? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TaskAnchor? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
