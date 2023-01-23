namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset Shadow.
/// </summary>
public static class PresetShadowConverter
{
  /// <summary>
  /// Preset Shadow
  /// </summary>
  private static DMDraws.PresetShadowKind? GetPreset(DXDraw.PresetShadow openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetShadowValues, DMDraws.PresetShadowKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXDraw.PresetShadow openXmlElement, DMDraws.PresetShadowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetShadowValues, DMDraws.PresetShadowKind>(openXmlElement?.Preset?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreset(DXDraw.PresetShadow openXmlElement, DMDraws.PresetShadowKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetShadowValues, DMDraws.PresetShadowKind>(value);
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  private static Int64? GetDistance(DXDraw.PresetShadow openXmlElement)
  {
    return openXmlElement.Distance?.Value;
  }
  
  private static bool CmpDistance(DXDraw.PresetShadow openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Distance?.Value == value;
  }
  
  private static void SetDistance(DXDraw.PresetShadow openXmlElement, Int64? value)
  {
    openXmlElement.Distance = value;
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  private static Int32? GetDirection(DXDraw.PresetShadow openXmlElement)
  {
    return openXmlElement.Direction?.Value;
  }
  
  private static bool CmpDirection(DXDraw.PresetShadow openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Direction?.Value == value;
  }
  
  private static void SetDirection(DXDraw.PresetShadow openXmlElement, Int32? value)
  {
    openXmlElement.Direction = value;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  private static DMDraws.RgbColorModelPercentage? GetRgbColorModelPercentage(DXDraw.PresetShadow openXmlElement)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>());
  }
  
  private static bool CmpRgbColorModelPercentage(DXDraw.PresetShadow openXmlElement, DMDraws.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelPercentageConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelPercentage>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelPercentage(DXDraw.PresetShadow openXmlElement, DMDraws.RgbColorModelPercentage? value)
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
  private static DMDraws.RgbColorModelHex? GetRgbColorModelHex(DXDraw.PresetShadow openXmlElement)
  {
    return DMXDraws.RgbColorModelHexConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>());
  }
  
  private static bool CmpRgbColorModelHex(DXDraw.PresetShadow openXmlElement, DMDraws.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RgbColorModelHexConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.RgbColorModelHex>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRgbColorModelHex(DXDraw.PresetShadow openXmlElement, DMDraws.RgbColorModelHex? value)
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
  private static DMDraws.HslColor? GetHslColor(DXDraw.PresetShadow openXmlElement)
  {
    return DMXDraws.HslColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.HslColor>());
  }
  
  private static bool CmpHslColor(DXDraw.PresetShadow openXmlElement, DMDraws.HslColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.HslColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.HslColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHslColor(DXDraw.PresetShadow openXmlElement, DMDraws.HslColor? value)
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
  private static DMDraws.SystemColor? GetSystemColor(DXDraw.PresetShadow openXmlElement)
  {
    return DMXDraws.SystemColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SystemColor>());
  }
  
  private static bool CmpSystemColor(DXDraw.PresetShadow openXmlElement, DMDraws.SystemColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SystemColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SystemColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSystemColor(DXDraw.PresetShadow openXmlElement, DMDraws.SystemColor? value)
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
  private static DMDraws.SchemeColor? GetSchemeColor(DXDraw.PresetShadow openXmlElement)
  {
    return DMXDraws.SchemeColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SchemeColor>());
  }
  
  private static bool CmpSchemeColor(DXDraw.PresetShadow openXmlElement, DMDraws.SchemeColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SchemeColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SchemeColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSchemeColor(DXDraw.PresetShadow openXmlElement, DMDraws.SchemeColor? value)
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
  private static DMDraws.PresetColor? GetPresetColor(DXDraw.PresetShadow openXmlElement)
  {
    return DMXDraws.PresetColorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetColor>());
  }
  
  private static bool CmpPresetColor(DXDraw.PresetShadow openXmlElement, DMDraws.PresetColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetColorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetColor>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetColor(DXDraw.PresetShadow openXmlElement, DMDraws.PresetColor? value)
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
  
  public static DMDraws.PresetShadow? CreateModelElement(DXDraw.PresetShadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PresetShadow();
      value.Preset = GetPreset(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
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
  
  public static bool CompareModelElement(DXDraw.PresetShadow? openXmlElement, DMDraws.PresetShadow? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreset(openXmlElement, value.Preset, diffs, objName))
        ok = false;
      if (!CmpDistance(openXmlElement, value.Distance, diffs, objName))
        ok = false;
      if (!CmpDirection(openXmlElement, value.Direction, diffs, objName))
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PresetShadow? value)
    where OpenXmlElementType: DXDraw.PresetShadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetDistance(openXmlElement, value?.Distance);
      SetDirection(openXmlElement, value?.Direction);
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
