namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the ContextualTabSets Class.
/// </summary>
public static class ContextualTabSetsConverter
{
  private static Collection<DMUI.ContextualTabSet> GetItems(DXOCustUI.ContextualTabSets openXmlElement)
  {
    var collection = new Collection<DMUI.ContextualTabSet>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.ContextualTabSet>())
    {
      var newItem = DMXUI.ContextualTabSetConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXOCustUI.ContextualTabSets openXmlElement, Collection<DMUI.ContextualTabSet>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXOCustUI.ContextualTabSet>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
        if (!DMXUI.ContextualTabSetConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXOCustUI.ContextualTabSets openXmlElement, Collection<DMUI.ContextualTabSet>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCustUI.ContextualTabSet>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.ContextualTabSetConverter.CreateOpenXmlElement<DXOCustUI.ContextualTabSet>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMUI.ContextualTabSets? CreateModelElement(DXOCustUI.ContextualTabSets? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.ContextualTabSets();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.ContextualTabSets? openXmlElement, DMUI.ContextualTabSets? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.ContextualTabSets? value)
    where OpenXmlElementType: DXOCustUI.ContextualTabSets, new()
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
