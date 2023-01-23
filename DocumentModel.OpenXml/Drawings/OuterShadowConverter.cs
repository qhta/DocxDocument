namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Outer Shadow Effect.
/// </summary>
public static class OuterShadowConverter
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  private static Int64? GetBlurRadius(DXDraw.OuterShadow openXmlElement)
  {
    return openXmlElement.BlurRadius?.Value;
  }
  
  private static bool CmpBlurRadius(DXDraw.OuterShadow openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.BlurRadius?.Value == value;
  }
  
  private static void SetBlurRadius(DXDraw.OuterShadow openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// Shadow Offset Distance
  /// </summary>
  private static Int64? GetDistance(DXDraw.OuterShadow openXmlElement)
  {
    return openXmlElement.Distance?.Value;
  }
  
  private static bool CmpDistance(DXDraw.OuterShadow openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Distance?.Value == value;
  }
  
  private static void SetDistance(DXDraw.OuterShadow openXmlElement, Int64? value)
  {
    openXmlElement.Distance = value;
  }
  
  /// <summary>
  /// Shadow Direction
  /// </summary>
  private static Int32? GetDirection(DXDraw.OuterShadow openXmlElement)
  {
    return openXmlElement.Direction?.Value;
  }
  
  private static bool CmpDirection(DXDraw.OuterShadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Direction?.Value == value;
  }
  
  private static void SetDirection(DXDraw.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.Direction = value;
  }
  
  /// <summary>
  /// Horizontal Scaling Factor
  /// </summary>
  private static Int32? GetHorizontalRatio(DXDraw.OuterShadow openXmlElement)
  {
    return openXmlElement.HorizontalRatio?.Value;
  }
  
  private static bool CmpHorizontalRatio(DXDraw.OuterShadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.HorizontalRatio?.Value == value;
  }
  
  private static void SetHorizontalRatio(DXDraw.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Scaling Factor
  /// </summary>
  private static Int32? GetVerticalRatio(DXDraw.OuterShadow openXmlElement)
  {
    return openXmlElement.VerticalRatio?.Value;
  }
  
  private static bool CmpVerticalRatio(DXDraw.OuterShadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.VerticalRatio?.Value == value;
  }
  
  private static void SetVerticalRatio(DXDraw.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  private static Int32? GetHorizontalSkew(DXDraw.OuterShadow openXmlElement)
  {
    return openXmlElement.HorizontalSkew?.Value;
  }
  
  private static bool CmpHorizontalSkew(DXDraw.OuterShadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.HorizontalSkew?.Value == value;
  }
  
  private static void SetHorizontalSkew(DXDraw.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  private static Int32? GetVerticalSkew(DXDraw.OuterShadow openXmlElement)
  {
    return openXmlElement.VerticalSkew?.Value;
  }
  
  private static bool CmpVerticalSkew(DXDraw.OuterShadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.VerticalSkew?.Value == value;
  }
  
  private static void SetVerticalSkew(DXDraw.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  private static DMDraws.RectangleAlignmentKind? GetAlignment(DXDraw.OuterShadow openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMDraws.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXDraw.OuterShadow openXmlElement, DMDraws.RectangleAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMDraws.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlignment(DXDraw.OuterShadow openXmlElement, DMDraws.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMDraws.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXDraw.OuterShadow openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXDraw.OuterShadow openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RotateWithShape?.Value == value;
  }
  
  private static void SetRotateWithShape(DXDraw.OuterShadow openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXDraw.OuterShadow openXmlElement)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>());
  }
  
  private static bool CmpRgbColorModelPercentage(DXDraw.OuterShadow openXmlElement, DMDraws.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelPercentage(DXDraw.OuterShadow openXmlElement, DMDraws.RgbColorModelPercentage? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RgbColorModelPercentage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RgbColorModelPercentageConverter.CreateOpenXmlElement<DXDraw.RgbColorModelPercentage>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXDraw.OuterShadow openXmlElement)
  {
    return DMXDraws.RgbColorModelHexConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>());
  }
  
  private static bool CmpRgbColorModelHex(DXDraw.OuterShadow openXmlElement, DMDraws.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelHexConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelHex(DXDraw.OuterShadow openXmlElement, DMDraws.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RgbColorModelHexConverter.CreateOpenXmlElement<DXDraw.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  private static DMDraws.HslColor? GetHslColor(DXDraw.OuterShadow openXmlElement)
  {
    return DMXDraws.HslColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HslColor>());
  }
  
  private static bool CmpHslColor(DXDraw.OuterShadow openXmlElement, DMDraws.HslColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HslColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HslColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHslColor(DXDraw.OuterShadow openXmlElement, DMDraws.HslColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HslColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HslColorConverter.CreateOpenXmlElement<DXDraw.HslColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  private static DMDraws.SystemColor? GetSystemColor(DXDraw.OuterShadow openXmlElement)
  {
    return DMXDraws.SystemColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SystemColor>());
  }
  
  private static bool CmpSystemColor(DXDraw.OuterShadow openXmlElement, DMDraws.SystemColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SystemColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SystemColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSystemColor(DXDraw.OuterShadow openXmlElement, DMDraws.SystemColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SystemColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SystemColorConverter.CreateOpenXmlElement<DXDraw.SystemColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  private static DMDraws.SchemeColor? GetSchemeColor(DXDraw.OuterShadow openXmlElement)
  {
    return DMXDraws.SchemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SchemeColor>());
  }
  
  private static bool CmpSchemeColor(DXDraw.OuterShadow openXmlElement, DMDraws.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SchemeColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SchemeColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSchemeColor(DXDraw.OuterShadow openXmlElement, DMDraws.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SchemeColorConverter.CreateOpenXmlElement<DXDraw.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  private static DMDraws.PresetColor? GetPresetColor(DXDraw.OuterShadow openXmlElement)
  {
    return DMXDraws.PresetColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetColor>());
  }
  
  private static bool CmpPresetColor(DXDraw.OuterShadow openXmlElement, DMDraws.PresetColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetColor(DXDraw.OuterShadow openXmlElement, DMDraws.PresetColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PresetColorConverter.CreateOpenXmlElement<DXDraw.PresetColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.OuterShadow? CreateModelElement(DXDraw.OuterShadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.OuterShadow();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.OuterShadow? openXmlElement, DMDraws.OuterShadow? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlurRadius(openXmlElement, value.BlurRadius, diffs, objName))
        ok = false;
      if (!CmpDistance(openXmlElement, value.Distance, diffs, objName))
        ok = false;
      if (!CmpDirection(openXmlElement, value.Direction, diffs, objName))
        ok = false;
      if (!CmpHorizontalRatio(openXmlElement, value.HorizontalRatio, diffs, objName))
        ok = false;
      if (!CmpVerticalRatio(openXmlElement, value.VerticalRatio, diffs, objName))
        ok = false;
      if (!CmpHorizontalSkew(openXmlElement, value.HorizontalSkew, diffs, objName))
        ok = false;
      if (!CmpVerticalSkew(openXmlElement, value.VerticalSkew, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      if (!CmpRotateWithShape(openXmlElement, value.RotateWithShape, diffs, objName))
        ok = false;
      if (!CmpRgbColorModelPercentage(openXmlElement, value.RgbColorModelPercentage, diffs, objName))
        ok = false;
      if (!CmpRgbColorModelHex(openXmlElement, value.RgbColorModelHex, diffs, objName))
        ok = false;
      if (!CmpHslColor(openXmlElement, value.HslColor, diffs, objName))
        ok = false;
      if (!CmpSystemColor(openXmlElement, value.SystemColor, diffs, objName))
        ok = false;
      if (!CmpSchemeColor(openXmlElement, value.SchemeColor, diffs, objName))
        ok = false;
      if (!CmpPresetColor(openXmlElement, value.PresetColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.OuterShadow? value)
    where OpenXmlElementType: DXDraw.OuterShadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetDistance(openXmlElement, value?.Distance);
      SetDirection(openXmlElement, value?.Direction);
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
      SetVerticalSkew(openXmlElement, value?.VerticalSkew);
      SetAlignment(openXmlElement, value?.Alignment);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      return openXmlElement;
    }
    return default;
  }
}
