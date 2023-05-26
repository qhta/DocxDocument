namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Draw Cubic Bezier Curve To.
/// </summary>
public static class CubicBezierCurveToConverter
{
  private static Collection<DMD.AdjustPoint2DType>? GetPoints(DXD.CubicBezierCurveTo openXmlElement)
  {
    var collection = new Collection<DMD.AdjustPoint2DType>();
    foreach (var item in openXmlElement.Elements<DXD.Point>())
    {
      var newItem = DMXD.AdjustPoint2DTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPoints(DXD.CubicBezierCurveTo openXmlElement, Collection<DMD.AdjustPoint2DType>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXD.Point>();
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
        if (!DMXD.AdjustPoint2DTypeConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPoints(DXD.CubicBezierCurveTo openXmlElement, Collection<DMD.AdjustPoint2DType>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.Point>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXD.Point>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.CubicBezierCurveTo? CreateModelElement(DXD.CubicBezierCurveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.CubicBezierCurveTo();
      value.Points = GetPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.CubicBezierCurveTo? openXmlElement, DMD.CubicBezierCurveTo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPoints(openXmlElement, value.Points, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.CubicBezierCurveTo value)
    where OpenXmlElementType: DXD.CubicBezierCurveTo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.CubicBezierCurveTo openXmlElement, DMD.CubicBezierCurveTo value)
  {
    SetPoints(openXmlElement, value?.Points);
  }
}
