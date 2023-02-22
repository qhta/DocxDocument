namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tab List.
/// </summary>
public static class TabStopListConverter
{
  private static Collection<DMDraws.TabStop>? GetTabStops(DXDraw.TabStopList openXmlElement)
  {
    var collection = new Collection<DMDraws.TabStop>();
    foreach (var item in openXmlElement.Elements<DXDraw.TabStop>())
    {
      var newItem = DMXDraws.TabStopConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTabStops(DXDraw.TabStopList openXmlElement, Collection<DMDraws.TabStop>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.TabStop>();
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
        if (!DMXDraws.TabStopConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTabStops(DXDraw.TabStopList openXmlElement, Collection<DMDraws.TabStop>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.TabStop>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.TabStopConverter.CreateOpenXmlElement<DXDraw.TabStop>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.TabStopList? CreateModelElement(DXDraw.TabStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TabStopList();
      value.TabStops = GetTabStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.TabStopList? openXmlElement, DMDraws.TabStopList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTabStops(openXmlElement, value.TabStops, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TabStopList value)
    where OpenXmlElementType: DXDraw.TabStopList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.TabStopList openXmlElement, DMDraws.TabStopList value)
  {
    SetTabStops(openXmlElement, value?.TabStops);
  }
}
