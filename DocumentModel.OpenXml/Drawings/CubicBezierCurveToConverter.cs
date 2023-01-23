namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Draw Cubic Bezier Curve To.
/// </summary>
public static class CubicBezierCurveToConverter
{
  private static Collection<DMDraws.AdjustPoint2DType> GetPoints(DXDraw.CubicBezierCurveTo openXmlElement)
  {
    var collection = new Collection<DMDraws.AdjustPoint2DType>();
    foreach (var item in openXmlElement.Elements<DXDraw.Point>())
    {
      var newItem = DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpPoints(DXDraw.CubicBezierCurveTo openXmlElement, Collection<DMDraws.AdjustPoint2DType>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetPoints(DXDraw.CubicBezierCurveTo openXmlElement, Collection<DMDraws.AdjustPoint2DType>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.Point>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXDraw.Point>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.CubicBezierCurveTo? CreateModelElement(DXDraw.CubicBezierCurveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.CubicBezierCurveTo();
      value.Points = GetPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.CubicBezierCurveTo? openXmlElement, DMDraws.CubicBezierCurveTo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPoints(openXmlElement, value.Points, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.CubicBezierCurveTo? value)
    where OpenXmlElementType: DXDraw.CubicBezierCurveTo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPoints(openXmlElement, value?.Points);
      return openXmlElement;
    }
    return default;
  }
}
