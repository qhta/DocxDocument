namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the Tasks Class.
/// </summary>
public static class TasksConverter
{
  public static Collection<Task>? GetItems(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Task>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2021.DocumentTasks.Task>())
      {
        var newItem = TaskConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement, Collection<Task>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2021.DocumentTasks.Task>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = TaskConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.Task>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement, ExtensionList? value)
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

  public static Tasks? CreateModelElement(DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Tasks();
      value.Items = GetItems(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Tasks? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2021.DocumentTasks.Tasks, new()
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