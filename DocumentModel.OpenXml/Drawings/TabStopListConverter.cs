namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tab List.
/// </summary>
public static class TabStopListConverter
{
  private static Collection<DMD.TabStop>? GetTabStops(DXD.TabStopList openXmlElement)
  {
    var collection = new Collection<DMD.TabStop>();
    foreach (var item in openXmlElement.Elements<DXD.TabStop>())
    {
      var newItem = DMXD.TabStopConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTabStops(DXD.TabStopList openXmlElement, Collection<DMD.TabStop>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.TabStop>();
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
        if (!DMXD.TabStopConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTabStops(DXD.TabStopList openXmlElement, Collection<DMD.TabStop>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.TabStop>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.TabStopConverter.CreateOpenXmlElement<DXD.TabStop>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.TabStopList? CreateModelElement(DXD.TabStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.TabStopList();
      value.TabStops = GetTabStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.TabStopList? openXmlElement, DMD.TabStopList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTabStops(openXmlElement, value.TabStops, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.TabStopList value)
    where OpenXmlElementType: DXD.TabStopList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.TabStopList openXmlElement, DMD.TabStopList value)
  {
    SetTabStops(openXmlElement, value?.TabStops);
  }
}
