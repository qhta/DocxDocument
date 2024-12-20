namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the ContextualTabSets Class.
/// </summary>
public static class ContextualTabSetsConverter
{
  private static Collection<DMUI.ContextualTabSet>? GetItems(DXOCUI.ContextualTabSets openXmlElement)
  {
    var collection = new Collection<DMUI.ContextualTabSet>();
    foreach (var item in openXmlElement.Elements<DXOCUI.ContextualTabSet>())
    {
      var newItem = DMXUI.ContextualTabSetConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXOCUI.ContextualTabSets openXmlElement, Collection<DMUI.ContextualTabSet>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXOCUI.ContextualTabSet>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXUI.ContextualTabSetConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXOCUI.ContextualTabSets openXmlElement, Collection<DMUI.ContextualTabSet>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCUI.ContextualTabSet>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.ContextualTabSetConverter.CreateOpenXmlElement<DXOCUI.ContextualTabSet>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.ContextualTabSets? CreateModelElement(DXOCUI.ContextualTabSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.ContextualTabSets();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.ContextualTabSets? openXmlElement, DMUI.ContextualTabSets? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.ContextualTabSets value)
    where OpenXmlElementType: DXOCUI.ContextualTabSets, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.ContextualTabSets openXmlElement, DMUI.ContextualTabSets value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
