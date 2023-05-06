namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextMenus Class.
/// </summary>
public static class ContextMenusConverter
{
  private static Collection<DM.ContextMenu>? GetItems(DXO10CUI.ContextMenus openXmlElement)
  {
    var collection = new Collection<DM.ContextMenu>();
    foreach (var item in openXmlElement.Elements<DXO10CUI.ContextMenu>())
    {
      var newItem = DMX.ContextMenuConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO10CUI.ContextMenus openXmlElement, Collection<DM.ContextMenu>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO10CUI.ContextMenu>();
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
        if (!DMX.ContextMenuConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO10CUI.ContextMenus openXmlElement, Collection<DM.ContextMenu>? value)
  {
    openXmlElement.RemoveAllChildren<DXO10CUI.ContextMenu>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ContextMenuConverter.CreateOpenXmlElement<DXO10CUI.ContextMenu>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.ContextMenus? CreateModelElement(DXO10CUI.ContextMenus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ContextMenus();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.ContextMenus? openXmlElement, DM.ContextMenus? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ContextMenus value)
    where OpenXmlElementType: DXO10CUI.ContextMenus, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.ContextMenus openXmlElement, DM.ContextMenus value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
