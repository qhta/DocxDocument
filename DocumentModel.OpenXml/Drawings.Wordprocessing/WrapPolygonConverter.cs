namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Tight Wrapping Extents Polygon.
/// </summary>
public static class WrapPolygonConverter
{
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  private static Boolean? GetEdited(DXDW.WrapPolygon openXmlElement)
  {
    return openXmlElement?.Edited?.Value;
  }
  
  private static bool CmpEdited(DXDW.WrapPolygon openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Edited?.Value == value) return true;
    diffs?.Add(objName, "Edited", openXmlElement?.Edited?.Value, value);
    return false;
  }
  
  private static void SetEdited(DXDW.WrapPolygon openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Edited = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Edited = null;
  }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  private static DMDW.Point2DType? GetStartPoint(DXDW.WrapPolygon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.StartPoint>();
    if (element != null)
      return DMXDW.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStartPoint(DXDW.WrapPolygon openXmlElement, DMDW.Point2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.StartPoint>(), value, diffs, objName, propName);
  }
  
  private static void SetStartPoint(DXDW.WrapPolygon openXmlElement, DMDW.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.StartPoint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.Point2DTypeConverter.CreateOpenXmlElement<DXDW.StartPoint>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDW.Point2DType? GetLineTo(DXDW.WrapPolygon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDW.LineTo>();
    if (element != null)
      return DMXDW.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineTo(DXDW.WrapPolygon openXmlElement, DMDW.Point2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDW.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDW.LineTo>(), value, diffs, objName, propName);
  }
  
  private static void SetLineTo(DXDW.WrapPolygon openXmlElement, DMDW.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.LineTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDW.Point2DTypeConverter.CreateOpenXmlElement<DXDW.LineTo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Wordprocessing.WrapPolygon? CreateModelElement(DXDW.WrapPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Wordprocessing.WrapPolygon();
      value.Edited = GetEdited(openXmlElement);
      value.StartPoint = GetStartPoint(openXmlElement);
      value.LineTo = GetLineTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDW.WrapPolygon? openXmlElement, DMDW.WrapPolygon? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEdited(openXmlElement, value.Edited, diffs, objName, propName))
        ok = false;
      if (!CmpStartPoint(openXmlElement, value.StartPoint, diffs, objName, propName))
        ok = false;
      if (!CmpLineTo(openXmlElement, value.LineTo, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.WrapPolygon value)
    where OpenXmlElementType: DXDW.WrapPolygon, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.WrapPolygon openXmlElement, DMDW.WrapPolygon value)
  {
    SetEdited(openXmlElement, value?.Edited);
    SetStartPoint(openXmlElement, value?.StartPoint);
    SetLineTo(openXmlElement, value?.LineTo);
  }
}
