namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape Adjust List.
/// </summary>
public static class AdjustListConverter
{
  private static Collection<DMDrawsDgms.Adjust> GetAdjusts(DXDrawDgms.AdjustList openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Adjust>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Adjust>())
    {
      var newItem = DMXDrawsDgms.AdjustConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpAdjusts(DXDrawDgms.AdjustList openXmlElement, Collection<DMDrawsDgms.Adjust>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawDgms.Adjust>();
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
        if (!DMXDrawsDgms.AdjustConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAdjusts(DXDrawDgms.AdjustList openXmlElement, Collection<DMDrawsDgms.Adjust>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Adjust>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.AdjustConverter.CreateOpenXmlElement<DXDrawDgms.Adjust>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsDgms.AdjustList? CreateModelElement(DXDrawDgms.AdjustList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.AdjustList();
      value.Adjusts = GetAdjusts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.AdjustList? openXmlElement, DMDrawsDgms.AdjustList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.AdjustList? value)
    where OpenXmlElementType: DXDrawDgms.AdjustList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAdjusts(openXmlElement, value?.Adjusts);
      return openXmlElement;
    }
    return default;
  }
}
