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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Point>();
    if (itemElement != null)
      return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
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
