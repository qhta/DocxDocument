namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public static class AdjustValueListConverter
{
  private static Collection<DMD.ShapeGuide>? GetShapeGuides(DXD.AdjustValueList openXmlElement)
  {
    var collection = new Collection<DMD.ShapeGuide>();
    foreach (var item in openXmlElement.Elements<DXD.ShapeGuide>())
    {
      var newItem = DMXD.ShapeGuideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpShapeGuides(DXD.AdjustValueList openXmlElement, Collection<DMD.ShapeGuide>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.ShapeGuide>();
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
        if (!DMXD.ShapeGuideConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetShapeGuides(DXD.AdjustValueList openXmlElement, Collection<DMD.ShapeGuide>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.ShapeGuide>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.ShapeGuideConverter.CreateOpenXmlElement<DXD.ShapeGuide>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMD.AdjustValueList? CreateModelElement(DXD.AdjustValueList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.AdjustValueList();
      value.ShapeGuides = GetShapeGuides(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AdjustValueList? openXmlElement, DMD.AdjustValueList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeGuides(openXmlElement, value.ShapeGuides, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AdjustValueList value)
    where OpenXmlElementType: DXD.AdjustValueList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AdjustValueList openXmlElement, DMD.AdjustValueList value)
  {
    SetShapeGuides(openXmlElement, value?.ShapeGuides);
  }
}
