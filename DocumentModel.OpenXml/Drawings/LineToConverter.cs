namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Draw Line To.
/// </summary>
public static class LineToConverter
{
  /// <summary>
  /// Line end point.
  /// </summary>
  private static DMDraws.AdjustPoint2DType? GetPoint(DXDraw.LineTo openXmlElement)
  {
    return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Point>());
  }
  
  private static bool CmpPoint(DXDraw.LineTo openXmlElement, DMDraws.AdjustPoint2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Point>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPoint(DXDraw.LineTo openXmlElement, DMDraws.AdjustPoint2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Point>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DXDraw.Point>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.LineTo? CreateModelElement(DXDraw.LineTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LineTo();
      value.Point = GetPoint(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.LineTo? openXmlElement, DMDraws.LineTo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPoint(openXmlElement, value.Point, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineTo? value)
    where OpenXmlElementType: DXDraw.LineTo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPoint(openXmlElement, value?.Point);
      return openXmlElement;
    }
    return default;
  }
}
