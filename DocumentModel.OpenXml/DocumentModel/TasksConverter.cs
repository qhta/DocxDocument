namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Tasks Class converter from/to OpenXml.
///</summary>
public static class TasksConverter
{
  private static Collection<DM.Task>? GetItems(DXO2021DocTasks.Tasks openXmlElement)
  {
    var collection = new Collection<DM.Task>();
    foreach (var item in openXmlElement.Elements<DXO2021DocTasks.Task>())
    {
      var newItem = DMX.TaskConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO2021DocTasks.Tasks openXmlElement, Collection<DM.Task>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2021DocTasks.Task>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMX.TaskConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXO2021DocTasks.ExtensionList>();
    if (element != null)
      return DMX.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2021DocTasks.Tasks openXmlElement, DM.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMX.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DocTasks.ExtensionList>(), value, diffs, objName);
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
  
  public static DocumentModel.Tasks? CreateModelElement(DXO2021DocTasks.Tasks? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2021DocTasks.Tasks? openXmlElement, DM.Tasks? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Tasks value)
    where OpenXmlElementType: DXO2021DocTasks.Tasks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DocTasks.Tasks openXmlElement, DM.Tasks value)
  {
    SetItems(openXmlElement, value?.Items);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
