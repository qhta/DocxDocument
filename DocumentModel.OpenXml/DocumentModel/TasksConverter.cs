namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public static class TasksConverter
{
  private static Collection<DM.Task> GetItems(DXO2021DocTasks.Tasks openXmlElement)
  {
    var collection = new Collection<DM.Task>();
    foreach (var item in openXmlElement.Elements<DXO2021DocTasks.Task>())
    {
      var newItem = DMX.TaskConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXO2021DocTasks.Tasks openXmlElement, Collection<DM.Task>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2021DocTasks.Task>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TaskConverter.CreateOpenXmlElement<DXO2021DocTasks.Task>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DM.ExtensionList? GetExtensionList(DXO2021DocTasks.Tasks openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>();
    if (itemElement != null)
      return DMX.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2021DocTasks.Tasks openXmlElement, DM.ExtensionList? value)
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
  
  public static DM.Tasks? CreateModelElement(DXO2021DocTasks.Tasks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Tasks();
      value.Items = GetItems(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Tasks? value)
    where OpenXmlElementType: DXO2021DocTasks.Tasks, new()
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
