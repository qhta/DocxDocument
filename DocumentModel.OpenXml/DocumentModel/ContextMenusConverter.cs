namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextMenus Class converter from/to OpenXml.
///</summary>
public static class ContextMenusConverter
{
  private static Collection<DM.ContextMenu>? GetItems(DXO2010CustUI.ContextMenus openXmlElement)
  {
    var collection = new Collection<DM.ContextMenu>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.ContextMenu>())
    {
      var newItem = DMX.ContextMenuConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO2010CustUI.ContextMenus openXmlElement, Collection<DM.ContextMenu>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2010CustUI.ContextMenu>();
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
  
  private static void SetItems(DXO2010CustUI.ContextMenus openXmlElement, Collection<DM.ContextMenu>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.ContextMenu>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.ContextMenuConverter.CreateOpenXmlElement<DXO2010CustUI.ContextMenu>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.ContextMenus? CreateModelElement(DXO2010CustUI.ContextMenus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ContextMenus();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.ContextMenus? openXmlElement, DM.ContextMenus? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXO2010CustUI.ContextMenus, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.ContextMenus openXmlElement, DM.ContextMenus value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
