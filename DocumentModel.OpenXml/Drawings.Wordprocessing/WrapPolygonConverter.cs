namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Tight Wrapping Extents Polygon.
/// </summary>
public static class WrapPolygonConverter
{
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  private static Boolean? GetEdited(DXDrawW.WrapPolygon openXmlElement)
  {
    return openXmlElement?.Edited?.Value;
  }
  
  private static void SetEdited(DXDrawW.WrapPolygon openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Edited = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Edited = null;
  }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  private static DMDrawsW.Point2DType? GetStartPoint(DXDrawW.WrapPolygon openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.StartPoint>();
    if (itemElement != null)
      return DMXDrawsW.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStartPoint(DXDrawW.WrapPolygon openXmlElement, DMDrawsW.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.StartPoint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.Point2DTypeConverter.CreateOpenXmlElement<DXDrawW.StartPoint>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsW.Point2DType? GetLineTo(DXDrawW.WrapPolygon openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.LineTo>();
    if (itemElement != null)
      return DMXDrawsW.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineTo(DXDrawW.WrapPolygon openXmlElement, DMDrawsW.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.LineTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.Point2DTypeConverter.CreateOpenXmlElement<DXDrawW.LineTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsW.WrapPolygon? CreateModelElement(DXDrawW.WrapPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.WrapPolygon();
      value.Edited = GetEdited(openXmlElement);
      value.StartPoint = GetStartPoint(openXmlElement);
      value.LineTo = GetLineTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.WrapPolygon? value)
    where OpenXmlElementType: DXDrawW.WrapPolygon, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEdited(openXmlElement, value?.Edited);
      SetStartPoint(openXmlElement, value?.StartPoint);
      SetLineTo(openXmlElement, value?.LineTo);
      return openXmlElement;
    }
    return default;
  }
}
