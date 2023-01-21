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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Point>();
    if (itemElement != null)
      return DMXDraws.AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
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
