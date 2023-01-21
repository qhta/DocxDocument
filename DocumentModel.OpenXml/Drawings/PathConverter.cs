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
    return openXmlElement.Width?.Value;
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
    return openXmlElement.Height?.Value;
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
  
  private static void SetExtrusionOk(DXDraw.Path openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ExtrusionOk = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ExtrusionOk = null;
  }
  
  private static Boolean? GetCloseShapePath(DXDraw.Path openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CloseShapePath>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.MoveTo>();
    if (itemElement != null)
      return DMXDraws.MoveToConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LineTo>();
    if (itemElement != null)
      return DMXDraws.LineToConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ArcTo>();
    if (itemElement != null)
      return DMXDraws.ArcToConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.QuadraticBezierCurveTo>();
    if (itemElement != null)
      return DMXDraws.QuadraticBezierCurveToConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.CubicBezierCurveTo>();
    if (itemElement != null)
      return DMXDraws.CubicBezierCurveToConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.Path? CreateModelElement(DXDraw.Path? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Path();
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
