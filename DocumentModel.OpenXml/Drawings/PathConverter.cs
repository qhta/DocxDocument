namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Shape Path.
/// </summary>
public static class PathConverter
{
  /// <summary>
  /// Path Width
  /// </summary>
  private static Int64? GetWidth(DXD.Path openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static bool CmpWidth(DXD.Path openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Width?.Value == value) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Width?.Value, value);
    return false;
  }
  
  private static void SetWidth(DXD.Path openXmlElement, Int64? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// Path Height
  /// </summary>
  private static Int64? GetHeight(DXD.Path openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXD.Path openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXD.Path openXmlElement, Int64? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Path Fill
  /// </summary>
  private static DMD.PathFillMode? GetFill(DXD.Path openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DMD.PathFillMode>(openXmlElement?.Fill?.Value);
  }
  
  private static bool CmpFill(DXD.Path openXmlElement, DMD.PathFillMode? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DMD.PathFillMode>(openXmlElement?.Fill?.Value, value, diffs, objName);
  }
  
  private static void SetFill(DXD.Path openXmlElement, DMD.PathFillMode? value)
  {
    openXmlElement.Fill = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PathFillModeValues, DMD.PathFillMode>(value);
  }
  
  /// <summary>
  /// Path Stroke
  /// </summary>
  private static Boolean? GetStroke(DXD.Path openXmlElement)
  {
    return openXmlElement?.Stroke?.Value;
  }
  
  private static bool CmpStroke(DXD.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Stroke?.Value == value) return true;
    diffs?.Add(objName, "Stroke", openXmlElement?.Stroke?.Value, value);
    return false;
  }
  
  private static void SetStroke(DXD.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Stroke = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Stroke = null;
  }
  
  /// <summary>
  /// 3D Extrusion Allowed
  /// </summary>
  private static Boolean? GetExtrusionOk(DXD.Path openXmlElement)
  {
    return openXmlElement?.ExtrusionOk?.Value;
  }
  
  private static bool CmpExtrusionOk(DXD.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ExtrusionOk?.Value == value) return true;
    diffs?.Add(objName, "ExtrusionOk", openXmlElement?.ExtrusionOk?.Value, value);
    return false;
  }
  
  private static void SetExtrusionOk(DXD.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ExtrusionOk = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ExtrusionOk = null;
  }
  
  private static Boolean? GetCloseShapePath(DXD.Path openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.CloseShapePath>() != null;
  }
  
  private static bool CmpCloseShapePath(DXD.Path openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.CloseShapePath>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.CloseShapePath", val, value);
    return false;
  }
  
  private static void SetCloseShapePath(DXD.Path openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.CloseShapePath>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.CloseShapePath();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.MoveTo? GetMoveTo(DXD.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.MoveTo>();
    if (element != null)
      return DMXD.MoveToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMoveTo(DXD.Path openXmlElement, DMD.MoveTo? value, DiffList? diffs, string? objName)
  {
    return DMXD.MoveToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.MoveTo>(), value, diffs, objName);
  }
  
  private static void SetMoveTo(DXD.Path openXmlElement, DMD.MoveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.MoveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.MoveToConverter.CreateOpenXmlElement<DXD.MoveTo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineTo? GetLineTo(DXD.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LineTo>();
    if (element != null)
      return DMXD.LineToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineTo(DXD.Path openXmlElement, DMD.LineTo? value, DiffList? diffs, string? objName)
  {
    return DMXD.LineToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LineTo>(), value, diffs, objName);
  }
  
  private static void SetLineTo(DXD.Path openXmlElement, DMD.LineTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LineTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineToConverter.CreateOpenXmlElement<DXD.LineTo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.ArcTo? GetArcTo(DXD.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ArcTo>();
    if (element != null)
      return DMXD.ArcToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArcTo(DXD.Path openXmlElement, DMD.ArcTo? value, DiffList? diffs, string? objName)
  {
    return DMXD.ArcToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ArcTo>(), value, diffs, objName);
  }
  
  private static void SetArcTo(DXD.Path openXmlElement, DMD.ArcTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ArcTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ArcToConverter.CreateOpenXmlElement<DXD.ArcTo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.QuadraticBezierCurveTo? GetQuadraticBezierCurveTo(DXD.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.QuadraticBezierCurveTo>();
    if (element != null)
      return DMXD.QuadraticBezierCurveToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpQuadraticBezierCurveTo(DXD.Path openXmlElement, DMD.QuadraticBezierCurveTo? value, DiffList? diffs, string? objName)
  {
    return DMXD.QuadraticBezierCurveToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.QuadraticBezierCurveTo>(), value, diffs, objName);
  }
  
  private static void SetQuadraticBezierCurveTo(DXD.Path openXmlElement, DMD.QuadraticBezierCurveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.QuadraticBezierCurveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.QuadraticBezierCurveToConverter.CreateOpenXmlElement<DXD.QuadraticBezierCurveTo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.CubicBezierCurveTo? GetCubicBezierCurveTo(DXD.Path openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CubicBezierCurveTo>();
    if (element != null)
      return DMXD.CubicBezierCurveToConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCubicBezierCurveTo(DXD.Path openXmlElement, DMD.CubicBezierCurveTo? value, DiffList? diffs, string? objName)
  {
    return DMXD.CubicBezierCurveToConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CubicBezierCurveTo>(), value, diffs, objName);
  }
  
  private static void SetCubicBezierCurveTo(DXD.Path openXmlElement, DMD.CubicBezierCurveTo? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CubicBezierCurveTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CubicBezierCurveToConverter.CreateOpenXmlElement<DXD.CubicBezierCurveTo>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Path? CreateModelElement(DXD.Path? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.Path? openXmlElement, DMD.Path? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Path value)
    where OpenXmlElementType: DXD.Path, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Path openXmlElement, DMD.Path value)
  {
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
  }
}
