namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextMenus Class.
/// </summary>
public static class ContextMenusConverter
{
  private static Collection<DM.ContextMenu> GetItems(DXO2010CustUI.ContextMenus openXmlElement)
  {
    var collection = new Collection<DM.ContextMenu>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.ContextMenu>())
    {
      var newItem = DMX.ContextMenuConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXO2010CustUI.ContextMenus openXmlElement, Collection<DM.ContextMenu>? value, DiffList? diffs, string? objName)
  {
    return true;
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
  
  public static DM.ContextMenus? CreateModelElement(DXO2010CustUI.ContextMenus? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ContextMenus();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ContextMenus? value)
    where OpenXmlElementType: DXO2010CustUI.ContextMenus, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
