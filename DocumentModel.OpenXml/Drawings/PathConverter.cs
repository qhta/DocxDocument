namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public static class PathConverter
{
  /// <summary>
  /// Path Width
  /// </summary>
  private static Int64? GetWidth(DXDraw.Path openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXDraw.Path openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Width", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXDraw.Path openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Path Height
  /// </summary>
  private static Int64? GetHeight(DXDraw.Path openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXDraw.Path openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXDraw.Path openXmlElement, Int64? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  private static DMDraws.PathFillMode? GetFill(DXDraw.Path openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DMDraws.PathFillMode>(openXmlElement?.Fill?.Value);
  }
  
  private static bool CmpFill(DXDraw.Path openXmlElement, DMDraws.PathFillMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DMDraws.PathFillMode>(openXmlElement?.Fill?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFill(DXDraw.Path openXmlElement, DMDraws.PathFillMode? value)
  {
    openXmlElement.Fill = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DMDraws.PathFillMode>(value);
  }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  private static Boolean? GetStroke(DXDraw.Path openXmlElement)
  {
    return openXmlElement?.Stroke?.Value;
  }
  
  private static bool CmpStroke(DXDraw.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Stroke?.Value == value) return true;
    diffs?.Add(objName, "Stroke", openXmlElement?.Stroke?.Value, value);
    return false;
  }
  
  private static void SetStroke(DXDraw.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroke = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Stroke = null;
  }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  private static Boolean? GetExtrusionOk(DXDraw.Path openXmlElement)
  {
    return openXmlElement?.ExtrusionOk?.Value;
  }
  
  private static bool CmpExtrusionOk(DXDraw.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ExtrusionOk?.Value == value) return true;
    diffs?.Add(objName, "ExtrusionOk", openXmlElement?.ExtrusionOk?.Value, value);
    return false;
  }
  
  private static void SetExtrusionOk(DXDraw.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ExtrusionOk = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ExtrusionOk = null;
  }
  
  private static Boolean? GetCloseShapePath(DXDraw.Path openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.CloseShapePath>() != null;
  }
  
  private static bool CmpCloseShapePath(DXDraw.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.CloseShapePath>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.CloseShapePath", val, value);
    return false;
  }
  
  private static void SetCloseShapePath(DXDraw.Path openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.CloseShapePath>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.CloseShapePath();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.MoveTo? GetMoveTo(DXDraw.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.MoveTo>();
    if (element != null)
      return DMXDraws.MoveToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveTo(DXDraw.Path openXmlElement, DMDraws.MoveTo? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.MoveToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.MoveTo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMoveTo(DXDraw.Path openXmlElement, DMDraws.MoveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.MoveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.MoveToConverter.CreateOpenXmlElement<DXDraw.MoveTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LineTo? GetLineTo(DXDraw.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.LineTo>();
    if (element != null)
      return DMXDraws.LineToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineTo(DXDraw.Path openXmlElement, DMDraws.LineTo? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LineTo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineTo(DXDraw.Path openXmlElement, DMDraws.LineTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineToConverter.CreateOpenXmlElement<DXDraw.LineTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ArcTo? GetArcTo(DXDraw.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ArcTo>();
    if (element != null)
      return DMXDraws.ArcToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArcTo(DXDraw.Path openXmlElement, DMDraws.ArcTo? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ArcToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ArcTo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetArcTo(DXDraw.Path openXmlElement, DMDraws.ArcTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ArcTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ArcToConverter.CreateOpenXmlElement<DXDraw.ArcTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.QuadraticBezierCurveTo? GetQuadraticBezierCurveTo(DXDraw.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.QuadraticBezierCurveTo>();
    if (element != null)
      return DMXDraws.QuadraticBezierCurveToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpQuadraticBezierCurveTo(DXDraw.Path openXmlElement, DMDraws.QuadraticBezierCurveTo? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.QuadraticBezierCurveToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.QuadraticBezierCurveTo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetQuadraticBezierCurveTo(DXDraw.Path openXmlElement, DMDraws.QuadraticBezierCurveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.QuadraticBezierCurveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.QuadraticBezierCurveToConverter.CreateOpenXmlElement<DXDraw.QuadraticBezierCurveTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.CubicBezierCurveTo? GetCubicBezierCurveTo(DXDraw.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.CubicBezierCurveTo>();
    if (element != null)
      return DMXDraws.CubicBezierCurveToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCubicBezierCurveTo(DXDraw.Path openXmlElement, DMDraws.CubicBezierCurveTo? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CubicBezierCurveToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.CubicBezierCurveTo>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCubicBezierCurveTo(DXDraw.Path openXmlElement, DMDraws.CubicBezierCurveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CubicBezierCurveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CubicBezierCurveToConverter.CreateOpenXmlElement<DXDraw.CubicBezierCurveTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Path? CreateModelElement(DXDraw.Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Path();
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      value.Stroke = GetStroke(openXmlElement);
      value.ExtrusionOk = GetExtrusionOk(openXmlElement);
      value.CloseShapePath = GetCloseShapePath(openXmlElement);
      value.MoveTo = GetMoveTo(openXmlElement);
      value.LineTo = GetLineTo(openXmlElement);
      value.ArcTo = GetArcTo(openXmlElement);
      value.QuadraticBezierCurveTo = GetQuadraticBezierCurveTo(openXmlElement);
      value.CubicBezierCurveTo = GetCubicBezierCurveTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Path? openXmlElement, DMDraws.Path? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpFill(openXmlElement, value.Fill, diffs, objName))
        ok = false;
      if (!CmpStroke(openXmlElement, value.Stroke, diffs, objName))
        ok = false;
      if (!CmpExtrusionOk(openXmlElement, value.ExtrusionOk, diffs, objName))
        ok = false;
      if (!CmpCloseShapePath(openXmlElement, value.CloseShapePath, diffs, objName))
        ok = false;
      if (!CmpMoveTo(openXmlElement, value.MoveTo, diffs, objName))
        ok = false;
      if (!CmpLineTo(openXmlElement, value.LineTo, diffs, objName))
        ok = false;
      if (!CmpArcTo(openXmlElement, value.ArcTo, diffs, objName))
        ok = false;
      if (!CmpQuadraticBezierCurveTo(openXmlElement, value.QuadraticBezierCurveTo, diffs, objName))
        ok = false;
      if (!CmpCubicBezierCurveTo(openXmlElement, value.CubicBezierCurveTo, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Path? value)
    where OpenXmlElementType: DXDraw.Path, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetFill(openXmlElement, value?.Fill);
      SetStroke(openXmlElement, value?.Stroke);
      SetExtrusionOk(openXmlElement, value?.ExtrusionOk);
      SetCloseShapePath(openXmlElement, value?.CloseShapePath);
      SetMoveTo(openXmlElement, value?.MoveTo);
      SetLineTo(openXmlElement, value?.LineTo);
      SetArcTo(openXmlElement, value?.ArcTo);
      SetQuadraticBezierCurveTo(openXmlElement, value?.QuadraticBezierCurveTo);
      SetCubicBezierCurveTo(openXmlElement, value?.CubicBezierCurveTo);
      return openXmlElement;
    }
    return default;
  }
}
