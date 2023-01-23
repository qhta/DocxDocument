namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Move Path To.
/// </summary>
public static class MoveToConverter
{
  /// <summary>
  /// Move end point.
  /// </summary>
  private static DMDraws.AdjustPoint2DType? GetPoint(DXDraw.MoveTo openXmlElement)
  {
    return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Point>());
  }
  
  private static bool CmpPoint(DXDraw.MoveTo openXmlElement, DMDraws.AdjustPoint2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.AdjustPoint2DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Point>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPoint(DXDraw.MoveTo openXmlElement, DMDraws.AdjustPoint2DType? value)
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
  
  public static DMDraws.MoveTo? CreateModelElement(DXDraw.MoveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.MoveTo();
      value.Point = GetPoint(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.MoveTo? openXmlElement, DMDraws.MoveTo? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.MoveTo? value)
    where OpenXmlElementType: DXDraw.MoveTo, new()
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
