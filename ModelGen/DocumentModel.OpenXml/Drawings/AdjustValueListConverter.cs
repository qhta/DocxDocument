namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public static class AdjustValueListConverter
{
  private static Collection<DMDraws.ShapeGuide>? GetShapeGuides(DXDraw.AdjustValueList openXmlElement)
  {
    var collection = new Collection<DMDraws.ShapeGuide>();
    foreach (var item in openXmlElement.Elements<DXDraw.ShapeGuide>())
    {
      var newItem = DMXDraws.ShapeGuideConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpShapeGuides(DXDraw.AdjustValueList openXmlElement, Collection<DMDraws.ShapeGuide>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDraw.ShapeGuide>();
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
        if (!DMXDraws.ShapeGuideConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetShapeGuides(DXDraw.AdjustValueList openXmlElement, Collection<DMDraws.ShapeGuide>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ShapeGuide>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ShapeGuideConverter.CreateOpenXmlElement<DXDraw.ShapeGuide>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.AdjustValueList? CreateModelElement(DXDraw.AdjustValueList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustValueList();
      value.ShapeGuides = GetShapeGuides(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AdjustValueList? openXmlElement, DMDraws.AdjustValueList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeGuides(openXmlElement, value.ShapeGuides, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustValueList value)
    where OpenXmlElementType: DXDraw.AdjustValueList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AdjustValueList openXmlElement, DMDraws.AdjustValueList value)
  {
    SetShapeGuides(openXmlElement, value?.ShapeGuides);
  }
}
