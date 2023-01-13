namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public static class TasksConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Task>? GetItems(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Task>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.DocumentTasks.Task>())
      {
        var newItem = DocumentModel.OpenXml.TaskConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Task>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.DocumentTasks.Task>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.TaskConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.Task>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement, DocumentModel.ExtensionList? value)
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
  
  public static DocumentModel.Tasks? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Tasks();
      value.Items = GetItems(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Tasks? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
