namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Outer Shadow Effect.
/// </summary>
public static class OuterShadowConverter
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  private static Int64? GetBlurRadius(DXD.OuterShadow openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }
  
  private static bool CmpBlurRadius(DXD.OuterShadow openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.BlurRadius?.Value == value) return true;
    diffs?.Add(objName, "BlurRadius", openXmlElement?.BlurRadius?.Value, value);
    return false;
  }
  
  private static void SetBlurRadius(DXD.OuterShadow openXmlElement, Int64? value)
  {
    openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// Shadow Offset Distance
  /// </summary>
  private static Int64? GetDistance(DXD.OuterShadow openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  private static bool CmpDistance(DXD.OuterShadow openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Distance?.Value == value) return true;
    diffs?.Add(objName, "Distance", openXmlElement?.Distance?.Value, value);
    return false;
  }
  
  private static void SetDistance(DXD.OuterShadow openXmlElement, Int64? value)
  {
    openXmlElement.Distance = value;
  }
  
  /// <summary>
  /// Shadow Direction
  /// </summary>
  private static Int32? GetDirection(DXD.OuterShadow openXmlElement)
  {
    return openXmlElement?.Direction?.Value;
  }
  
  private static bool CmpDirection(DXD.OuterShadow openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Direction?.Value == value) return true;
    diffs?.Add(objName, "Direction", openXmlElement?.Direction?.Value, value);
    return false;
  }
  
  private static void SetDirection(DXD.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.Direction = value;
  }
  
  /// <summary>
  /// Horizontal Scaling Factor
  /// </summary>
  private static Int32? GetHorizontalRatio(DXD.OuterShadow openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  private static bool CmpHorizontalRatio(DXD.OuterShadow openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalRatio?.Value == value) return true;
    diffs?.Add(objName, "HorizontalRatio", openXmlElement?.HorizontalRatio?.Value, value);
    return false;
  }
  
  private static void SetHorizontalRatio(DXD.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Scaling Factor
  /// </summary>
  private static Int32? GetVerticalRatio(DXD.OuterShadow openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  private static bool CmpVerticalRatio(DXD.OuterShadow openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalRatio?.Value == value) return true;
    diffs?.Add(objName, "VerticalRatio", openXmlElement?.VerticalRatio?.Value, value);
    return false;
  }
  
  private static void SetVerticalRatio(DXD.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  private static Int32? GetHorizontalSkew(DXD.OuterShadow openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }
  
  private static bool CmpHorizontalSkew(DXD.OuterShadow openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalSkew?.Value == value) return true;
    diffs?.Add(objName, "HorizontalSkew", openXmlElement?.HorizontalSkew?.Value, value);
    return false;
  }
  
  private static void SetHorizontalSkew(DXD.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  private static Int32? GetVerticalSkew(DXD.OuterShadow openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }
  
  private static bool CmpVerticalSkew(DXD.OuterShadow openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalSkew?.Value == value) return true;
    diffs?.Add(objName, "VerticalSkew", openXmlElement?.VerticalSkew?.Value, value);
    return false;
  }
  
  private static void SetVerticalSkew(DXD.OuterShadow openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  private static DMD.RectangleAlignmentKind? GetAlignment(DXD.OuterShadow openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXD.OuterShadow openXmlElement, DMD.RectangleAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXD.OuterShadow openXmlElement, DMD.RectangleAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DMD.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXD.OuterShadow openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXD.OuterShadow openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RotateWithShape?.Value == value) return true;
    diffs?.Add(objName, "RotateWithShape", openXmlElement?.RotateWithShape?.Value, value);
    return false;
  }
  
  private static void SetRotateWithShape(DXD.OuterShadow openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  private static DMD.RgbColorModelPercentage? GetRgbColorModelPercentage(DXD.OuterShadow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelPercentage>();
    if (element != null)
      return DMXD.RgbColorModelPercentageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelPercentage(DXD.OuterShadow openXmlElement, DMD.RgbColorModelPercentage? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelPercentage>(), value, diffs, objName, propName);
  }
  
  private static void SetRgbColorModelPercentage(DXD.OuterShadow openXmlElement, DMD.RgbColorModelPercentage? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RgbColorModelPercentage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RgbColorModelPercentageConverter.CreateOpenXmlElement<DXD.RgbColorModelPercentage>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  private static DMD.RgbColorModelHex? GetRgbColorModelHex(DXD.OuterShadow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RgbColorModelHex>();
    if (element != null)
      return DMXD.RgbColorModelHexConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRgbColorModelHex(DXD.OuterShadow openXmlElement, DMD.RgbColorModelHex? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RgbColorModelHexConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RgbColorModelHex>(), value, diffs, objName, propName);
  }
  
  private static void SetRgbColorModelHex(DXD.OuterShadow openXmlElement, DMD.RgbColorModelHex? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RgbColorModelHex>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RgbColorModelHexConverter.CreateOpenXmlElement<DXD.RgbColorModelHex>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  private static DMD.HslColor? GetHslColor(DXD.OuterShadow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.HslColor>();
    if (element != null)
      return DMXD.HslColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHslColor(DXD.OuterShadow openXmlElement, DMD.HslColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.HslColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.HslColor>(), value, diffs, objName, propName);
  }
  
  private static void SetHslColor(DXD.OuterShadow openXmlElement, DMD.HslColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HslColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.HslColorConverter.CreateOpenXmlElement<DXD.HslColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  private static DMD.SystemColor? GetSystemColor(DXD.OuterShadow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SystemColor>();
    if (element != null)
      return DMXD.SystemColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSystemColor(DXD.OuterShadow openXmlElement, DMD.SystemColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SystemColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SystemColor>(), value, diffs, objName, propName);
  }
  
  private static void SetSystemColor(DXD.OuterShadow openXmlElement, DMD.SystemColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SystemColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SystemColorConverter.CreateOpenXmlElement<DXD.SystemColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  private static DMD.SchemeColor? GetSchemeColor(DXD.OuterShadow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SchemeColor>();
    if (element != null)
      return DMXD.SchemeColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSchemeColor(DXD.OuterShadow openXmlElement, DMD.SchemeColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SchemeColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SchemeColor>(), value, diffs, objName, propName);
  }
  
  private static void SetSchemeColor(DXD.OuterShadow openXmlElement, DMD.SchemeColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SchemeColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SchemeColorConverter.CreateOpenXmlElement<DXD.SchemeColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  private static DMD.PresetColor? GetPresetColor(DXD.OuterShadow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetColor>();
    if (element != null)
      return DMXD.PresetColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetColor(DXD.OuterShadow openXmlElement, DMD.PresetColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PresetColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetColor>(), value, diffs, objName, propName);
  }
  
  private static void SetPresetColor(DXD.OuterShadow openXmlElement, DMD.PresetColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetColorConverter.CreateOpenXmlElement<DXD.PresetColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.OuterShadow? CreateModelElement(DXD.OuterShadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.OuterShadow();
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
  
  public static bool CompareModelElement(DXD.OuterShadow? openXmlElement, DMD.OuterShadow? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBlurRadius(openXmlElement, value.BlurRadius, diffs, objName, propName))
        ok = false;
      if (!CmpDistance(openXmlElement, value.Distance, diffs, objName, propName))
        ok = false;
      if (!CmpDirection(openXmlElement, value.Direction, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalRatio(openXmlElement, value.HorizontalRatio, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalRatio(openXmlElement, value.VerticalRatio, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalSkew(openXmlElement, value.HorizontalSkew, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalSkew(openXmlElement, value.VerticalSkew, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName, propName))
        ok = false;
      if (!CmpRotateWithShape(openXmlElement, value.RotateWithShape, diffs, objName, propName))
        ok = false;
      if (!CmpRgbColorModelPercentage(openXmlElement, value.RgbColorModelPercentage, diffs, objName, propName))
        ok = false;
      if (!CmpRgbColorModelHex(openXmlElement, value.RgbColorModelHex, diffs, objName, propName))
        ok = false;
      if (!CmpHslColor(openXmlElement, value.HslColor, diffs, objName, propName))
        ok = false;
      if (!CmpSystemColor(openXmlElement, value.SystemColor, diffs, objName, propName))
        ok = false;
      if (!CmpSchemeColor(openXmlElement, value.SchemeColor, diffs, objName, propName))
        ok = false;
      if (!CmpPresetColor(openXmlElement, value.PresetColor, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.OuterShadow value)
    where OpenXmlElementType: DXD.OuterShadow, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.OuterShadow openXmlElement, DMD.OuterShadow value)
  {
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
  }
}
