namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Task Class.
/// </summary>
public static class TaskConverter
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public static DocumentModel.TaskAnchor? GetTaskAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskAnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTaskAnchor(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement, DocumentModel.TaskAnchor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.TaskAnchorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public static DocumentModel.TaskHistory? GetTaskHistory(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TaskHistoryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTaskHistory(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement, DocumentModel.TaskHistory? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.TaskHistoryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement, DocumentModel.ExtensionList? value)
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
  
  public static DocumentModel.Task? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Task? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.Task, new()
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
