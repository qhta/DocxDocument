namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextualTabs Class converter from/to OpenXml.
///</summary>
public static class ContextualTabsConverter
{
  private static Collection<DM.TabSet>? GetTabSets(DXO2010CustUI.ContextualTabs openXmlElement)
  {
    var collection = new Collection<DM.TabSet>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.TabSet>())
    {
      var newItem = DMX.TabSetConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTabSets(DXO2010CustUI.ContextualTabs openXmlElement, Collection<DM.TabSet>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2010CustUI.TabSet>();
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
        if (!DMX.TabSetConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTabSets(DXO2010CustUI.ContextualTabs openXmlElement, Collection<DM.TabSet>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.TabSet>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TabSetConverter.CreateOpenXmlElement<DXO2010CustUI.TabSet>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.ContextualTabs? CreateModelElement(DXO2010CustUI.ContextualTabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ContextualTabs();
      value.TabSets = GetTabSets(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.ContextualTabs? openXmlElement, DM.ContextualTabs? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTabSets(openXmlElement, value.TabSets, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ContextualTabs value)
    where OpenXmlElementType: DXO2010CustUI.ContextualTabs, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.ContextualTabs openXmlElement, DM.ContextualTabs value)
  {
    SetTabSets(openXmlElement, value?.TabSets);
  }
}
