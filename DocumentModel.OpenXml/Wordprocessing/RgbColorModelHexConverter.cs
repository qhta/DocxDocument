namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RgbColorModelHex Class converter from/to OpenXml.
///</summary>
public static class RgbColorModelHexConverter
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.RGB? GetVal(DXO2010W.RgbColorModelHex openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return (DocumentModel.RGB)UInt32.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpVal(DXO2010W.RgbColorModelHex openXmlElement, DM.RGB? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value != null)
      if (UInt32.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.Val?.Value == null && value == null) return true;
    diffs?.Add(objName, "Normal", openXmlElement?.Val?.Value, value?.ToString());
    return false;
  }
  
  private static void SetVal(DXO2010W.RgbColorModelHex openXmlElement, DM.RGB? value)
  {
    if (value != null)
      openXmlElement.Val = ((UInt32)value).ToString("X6");
    else
      openXmlElement.Val = null;
  }
  
  private static Int32? GetTint(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.Tint>()?.Val);
  }
  
  private static bool CmpTint(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.Tint>()?.Val, value, diffs, objName, "Tint");
  }
  
  private static void SetTint(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.Tint,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetShade(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.Shade>()?.Val);
  }
  
  private static bool CmpShade(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.Shade>()?.Val, value, diffs, objName, "Shade");
  }
  
  private static void SetShade(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.Shade,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetAlpha(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.Alpha>()?.Val);
  }
  
  private static bool CmpAlpha(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.Alpha>()?.Val, value, diffs, objName, "Alpha");
  }
  
  private static void SetAlpha(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.Alpha,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHueModulation(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.HueModulation>()?.Val);
  }
  
  private static bool CmpHueModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.HueModulation>()?.Val, value, diffs, objName, "HueModulation");
  }
  
  private static void SetHueModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.HueModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturation(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.Saturation>()?.Val);
  }
  
  private static bool CmpSaturation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.Saturation>()?.Val, value, diffs, objName, "Saturation");
  }
  
  private static void SetSaturation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.Saturation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationOffset(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.SaturationOffset>()?.Val);
  }
  
  private static bool CmpSaturationOffset(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.SaturationOffset>()?.Val, value, diffs, objName, "SaturationOffset");
  }
  
  private static void SetSaturationOffset(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.SaturationOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationModulation(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.SaturationModulation>()?.Val);
  }
  
  private static bool CmpSaturationModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.SaturationModulation>()?.Val, value, diffs, objName, "SaturationModulation");
  }
  
  private static void SetSaturationModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.SaturationModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminance(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.Luminance>()?.Val);
  }
  
  private static bool CmpLuminance(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.Luminance>()?.Val, value, diffs, objName, "Luminance");
  }
  
  private static void SetLuminance(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.Luminance,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceOffset(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.LuminanceOffset>()?.Val);
  }
  
  private static bool CmpLuminanceOffset(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.LuminanceOffset>()?.Val, value, diffs, objName, "LuminanceOffset");
  }
  
  private static void SetLuminanceOffset(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.LuminanceOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceModulation(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO2010W.LuminanceModulation>()?.Val);
  }
  
  private static bool CmpLuminanceModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO2010W.LuminanceModulation>()?.Val, value, diffs, objName, "LuminanceModulation");
  }
  
  private static void SetLuminanceModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXO2010W.LuminanceModulation,System.Int32>(openXmlElement, value);
  }
  
  public static DMW.RgbColorModelHex? CreateModelElement(DXO2010W.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RgbColorModelHex();
      value.Val = GetVal(openXmlElement);
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
  
  public static bool CompareModelElement(DXO2010W.RgbColorModelHex? openXmlElement, DMW.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpTint(openXmlElement, value.Tint, diffs, objName))
        ok = false;
      if (!CmpShade(openXmlElement, value.Shade, diffs, objName))
        ok = false;
      if (!CmpAlpha(openXmlElement, value.Alpha, diffs, objName))
        ok = false;
      if (!CmpHueModulation(openXmlElement, value.HueModulation, diffs, objName))
        ok = false;
      if (!CmpSaturation(openXmlElement, value.Saturation, diffs, objName))
        ok = false;
      if (!CmpSaturationOffset(openXmlElement, value.SaturationOffset, diffs, objName))
        ok = false;
      if (!CmpSaturationModulation(openXmlElement, value.SaturationModulation, diffs, objName))
        ok = false;
      if (!CmpLuminance(openXmlElement, value.Luminance, diffs, objName))
        ok = false;
      if (!CmpLuminanceOffset(openXmlElement, value.LuminanceOffset, diffs, objName))
        ok = false;
      if (!CmpLuminanceModulation(openXmlElement, value.LuminanceModulation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RgbColorModelHex value)
    where OpenXmlElementType: DXO2010W.RgbColorModelHex, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.RgbColorModelHex openXmlElement, DMW.RgbColorModelHex value)
  {
    SetVal(openXmlElement, value?.Val);
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
