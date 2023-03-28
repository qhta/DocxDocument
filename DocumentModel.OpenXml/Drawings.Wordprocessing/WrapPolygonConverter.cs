namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Tight Wrapping Extents Polygon converter from/to OpenXml.
///</summary>
public static class WrapPolygonConverter
{
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  private static Boolean? GetEdited(DXDrawW.WrapPolygon openXmlElement)
  {
    return openXmlElement?.Edited?.Value;
  }
  
  private static bool CmpEdited(DXDrawW.WrapPolygon openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Edited?.Value == value) return true;
    diffs?.Add(objName, "Edited", openXmlElement?.Edited?.Value, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDrawW.StartPoint>();
    if (element != null)
      return DMXDrawsW.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartPoint(DXDrawW.WrapPolygon openXmlElement, DMDrawsW.Point2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawW.StartPoint>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawW.LineTo>();
    if (element != null)
      return DMXDrawsW.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineTo(DXDrawW.WrapPolygon openXmlElement, DMDrawsW.Point2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsW.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawW.LineTo>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Wordprocessing.WrapPolygon? CreateModelElement(DXDrawW.WrapPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapPolygon();
      value.Edited = GetEdited(openXmlElement);
      value.StartPoint = GetStartPoint(openXmlElement);
      value.LineTo = GetLineTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawW.WrapPolygon? openXmlElement, DMDrawsW.WrapPolygon? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEdited(openXmlElement, value.Edited, diffs, objName))
        ok = false;
      if (!CmpStartPoint(openXmlElement, value.StartPoint, diffs, objName))
        ok = false;
      if (!CmpLineTo(openXmlElement, value.LineTo, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.WrapPolygon value)
    where OpenXmlElementType: DXDrawW.WrapPolygon, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawW.WrapPolygon openXmlElement, DMDrawsW.WrapPolygon value)
  {
    SetEdited(openXmlElement, value?.Edited);
    SetStartPoint(openXmlElement, value?.StartPoint);
    SetLineTo(openXmlElement, value?.LineTo);
  }
}
