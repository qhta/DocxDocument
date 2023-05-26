namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RgbColorModelHex Class.
/// </summary>
public static class RgbColorModelHexConverter
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.RGB? GetVal(DXO10W.RgbColorModelHex openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return (DocumentModel.RGB)UInt32.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpVal(DXO10W.RgbColorModelHex openXmlElement, DM.RGB? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Val?.Value != null)
      if (UInt32.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.Val?.Value == null && value == null) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value?.ToString());
    return false;
  }
  
  private static void SetVal(DXO10W.RgbColorModelHex openXmlElement, DM.RGB? value)
  {
    if (value != null)
      openXmlElement.Val = ((UInt32)value).ToString("X6");
    else
      openXmlElement.Val = null;
  }
  
  private static Int32? GetTint(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.Tint>()?.Val);
  }
  
  private static bool CmpTint(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.Tint>()?.Val, value, diffs, objName, "Tint");
  }
  
  private static void SetTint(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.Tint,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetShade(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.Shade>()?.Val);
  }
  
  private static bool CmpShade(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.Shade>()?.Val, value, diffs, objName, "Shade");
  }
  
  private static void SetShade(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.Shade,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetAlpha(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.Alpha>()?.Val);
  }
  
  private static bool CmpAlpha(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.Alpha>()?.Val, value, diffs, objName, "Alpha");
  }
  
  private static void SetAlpha(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.Alpha,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHueModulation(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.HueModulation>()?.Val);
  }
  
  private static bool CmpHueModulation(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.HueModulation>()?.Val, value, diffs, objName, "HueModulation");
  }
  
  private static void SetHueModulation(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.HueModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturation(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.Saturation>()?.Val);
  }
  
  private static bool CmpSaturation(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.Saturation>()?.Val, value, diffs, objName, "Saturation");
  }
  
  private static void SetSaturation(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.Saturation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationOffset(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.SaturationOffset>()?.Val);
  }
  
  private static bool CmpSaturationOffset(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.SaturationOffset>()?.Val, value, diffs, objName, "SaturationOffset");
  }
  
  private static void SetSaturationOffset(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.SaturationOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationModulation(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.SaturationModulation>()?.Val);
  }
  
  private static bool CmpSaturationModulation(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.SaturationModulation>()?.Val, value, diffs, objName, "SaturationModulation");
  }
  
  private static void SetSaturationModulation(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.SaturationModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminance(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.Luminance>()?.Val);
  }
  
  private static bool CmpLuminance(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.Luminance>()?.Val, value, diffs, objName, "Luminance");
  }
  
  private static void SetLuminance(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.Luminance,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceOffset(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.LuminanceOffset>()?.Val);
  }
  
  private static bool CmpLuminanceOffset(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.LuminanceOffset>()?.Val, value, diffs, objName, "LuminanceOffset");
  }
  
  private static void SetLuminanceOffset(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.LuminanceOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceModulation(DXO10W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO10W.LuminanceModulation>()?.Val);
  }
  
  private static bool CmpLuminanceModulation(DXO10W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO10W.LuminanceModulation>()?.Val, value, diffs, objName, "LuminanceModulation");
  }
  
  private static void SetLuminanceModulation(DXO10W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO10W.LuminanceModulation,System.Int32>(openXmlElement, value);
  }
  
  public static DMW.RgbColorModelHex? CreateModelElement(DXO10W.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RgbColorModelHex();
      value.RGB = GetVal(openXmlElement);
      value.Tint = GetTint(openXmlElement);
      value.Shade = GetShade(openXmlElement);
      value.Alpha = GetAlpha(openXmlElement);
      value.HueModulation = GetHueModulation(openXmlElement);
      value.Saturation = GetSaturation(openXmlElement);
      value.SaturationOffset = GetSaturationOffset(openXmlElement);
      value.SaturationModulation = GetSaturationModulation(openXmlElement);
      value.Luminance = GetLuminance(openXmlElement);
      value.LuminanceOffset = GetLuminanceOffset(openXmlElement);
      value.LuminanceModulation = GetLuminanceModulation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.RgbColorModelHex? openXmlElement, DMW.RgbColorModelHex? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.RGB, diffs, objName, propName))
        ok = false;
      if (!CmpTint(openXmlElement, value.Tint, diffs, objName, propName))
        ok = false;
      if (!CmpShade(openXmlElement, value.Shade, diffs, objName, propName))
        ok = false;
      if (!CmpAlpha(openXmlElement, value.Alpha, diffs, objName, propName))
        ok = false;
      if (!CmpHueModulation(openXmlElement, value.HueModulation, diffs, objName, propName))
        ok = false;
      if (!CmpSaturation(openXmlElement, value.Saturation, diffs, objName, propName))
        ok = false;
      if (!CmpSaturationOffset(openXmlElement, value.SaturationOffset, diffs, objName, propName))
        ok = false;
      if (!CmpSaturationModulation(openXmlElement, value.SaturationModulation, diffs, objName, propName))
        ok = false;
      if (!CmpLuminance(openXmlElement, value.Luminance, diffs, objName, propName))
        ok = false;
      if (!CmpLuminanceOffset(openXmlElement, value.LuminanceOffset, diffs, objName, propName))
        ok = false;
      if (!CmpLuminanceModulation(openXmlElement, value.LuminanceModulation, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RgbColorModelHex value)
    where OpenXmlElementType: DXO10W.RgbColorModelHex, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.RgbColorModelHex openXmlElement, DMW.RgbColorModelHex value)
  {
    SetVal(openXmlElement, value?.RGB);
    SetTint(openXmlElement, value?.Tint);
    SetShade(openXmlElement, value?.Shade);
    SetAlpha(openXmlElement, value?.Alpha);
    SetHueModulation(openXmlElement, value?.HueModulation);
    SetSaturation(openXmlElement, value?.Saturation);
    SetSaturationOffset(openXmlElement, value?.SaturationOffset);
    SetSaturationModulation(openXmlElement, value?.SaturationModulation);
    SetLuminance(openXmlElement, value?.Luminance);
    SetLuminanceOffset(openXmlElement, value?.LuminanceOffset);
    SetLuminanceModulation(openXmlElement, value?.LuminanceModulation);
  }
}
