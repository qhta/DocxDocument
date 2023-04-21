namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Adjust List.
/// </summary>
public static class AdjustListConverter
{
  private static Collection<DMDD.Adjust>? GetAdjusts(DXDD.AdjustList openXmlElement)
  {
    var collection = new Collection<DMDD.Adjust>();
    foreach (var item in openXmlElement.Elements<DXDD.Adjust>())
    {
      var newItem = DMXDD.AdjustConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAdjusts(DXDD.AdjustList openXmlElement, Collection<DMDD.Adjust>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDD.Adjust>();
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
        if (!DMXDD.AdjustConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAdjusts(DXDD.AdjustList openXmlElement, Collection<DMDD.Adjust>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Adjust>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.AdjustConverter.CreateOpenXmlElement<DXDD.Adjust>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.AdjustList? CreateModelElement(DXDD.AdjustList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.AdjustList();
      value.Adjusts = GetAdjusts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.AdjustList? openXmlElement, DMDD.AdjustList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAdjusts(openXmlElement, value.Adjusts, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.AdjustList value)
    where OpenXmlElementType: DXDD.AdjustList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.AdjustList openXmlElement, DMDD.AdjustList value)
  {
    SetAdjusts(openXmlElement, value?.Adjusts);
  }
}
