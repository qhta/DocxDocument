namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// System Color.
/// </summary>
public static class SystemColorConverter
{
  /// <summary>
  /// Value
  /// </summary>
  private static DMDraws.SystemColorKind? GetVal(DXDraw.SystemColor openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.SystemColorValues, DMDraws.SystemColorKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXDraw.SystemColor openXmlElement, DMDraws.SystemColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.SystemColorValues, DMDraws.SystemColorKind>(openXmlElement?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVal(DXDraw.SystemColor openXmlElement, DMDraws.SystemColorKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.SystemColorValues, DMDraws.SystemColorKind>(value);
  }
  
  /// <summary>
  /// Last Color
  /// </summary>
  private static DM.RGB? GetLastColor(DXDraw.SystemColor openXmlElement)
  {
    if (openXmlElement?.LastColor?.Value != null)
      return (DocumentModel.RGB)UInt32.Parse(openXmlElement.LastColor.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpLastColor(DXDraw.SystemColor openXmlElement, DM.RGB? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LastColor?.Value != null)
      if (UInt32.Parse(openXmlElement.LastColor.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.LastColor?.Value == null && value == null) return true;
    diffs?.Add(objName, "LastColor", openXmlElement?.LastColor?.Value, value?.ToString());
    return false;
  }
  
  private static void SetLastColor(DXDraw.SystemColor openXmlElement, DM.RGB? value)
  {
    if (value != null)
      openXmlElement.LastColor = ((UInt32)value).ToString("X6");
    else
      openXmlElement.LastColor = null;
  }
  
  private static Int32? GetTint(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Tint>()?.Val);
  }
  
  private static bool CmpTint(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Tint>()?.Val, value, diffs, objName, "Tint");
  }
  
  private static void SetTint(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Tint,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetShade(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Shade>()?.Val);
  }
  
  private static bool CmpShade(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Shade>()?.Val, value, diffs, objName, "Shade");
  }
  
  private static void SetShade(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Shade,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetComplement(DXDraw.SystemColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Complement>() != null;
  }
  
  private static bool CmpComplement(DXDraw.SystemColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Complement>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Complement", val, value);
    return false;
  }
  
  private static void SetComplement(DXDraw.SystemColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.Complement>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.Complement();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetInverse(DXDraw.SystemColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Inverse>() != null;
  }
  
  private static bool CmpInverse(DXDraw.SystemColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Inverse>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Inverse", val, value);
    return false;
  }
  
  private static void SetInverse(DXDraw.SystemColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.Inverse>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.Inverse();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGray(DXDraw.SystemColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gray>() != null;
  }
  
  private static bool CmpGray(DXDraw.SystemColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Gray>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Gray", val, value);
    return false;
  }
  
  private static void SetGray(DXDraw.SystemColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.Gray>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.Gray();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlpha(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Alpha>()?.Val);
  }
  
  private static bool CmpAlpha(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Alpha>()?.Val, value, diffs, objName, "Alpha");
  }
  
  private static void SetAlpha(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Alpha,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetAlphaOffset(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>()?.Val);
  }
  
  private static bool CmpAlphaOffset(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>()?.Val, value, diffs, objName, "AlphaOffset");
  }
  
  private static void SetAlphaOffset(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.AlphaOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetAlphaModulation(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>()?.Val);
  }
  
  private static bool CmpAlphaModulation(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>()?.Val, value, diffs, objName, "AlphaModulation");
  }
  
  private static void SetAlphaModulation(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.AlphaModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHue(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Hue>()?.Val);
  }
  
  private static bool CmpHue(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Hue>()?.Val, value, diffs, objName, "Hue");
  }
  
  private static void SetHue(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Hue,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHueOffset(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.HueOffset>()?.Val);
  }
  
  private static bool CmpHueOffset(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.HueOffset>()?.Val, value, diffs, objName, "HueOffset");
  }
  
  private static void SetHueOffset(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.HueOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHueModulation(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.HueModulation>()?.Val);
  }
  
  private static bool CmpHueModulation(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.HueModulation>()?.Val, value, diffs, objName, "HueModulation");
  }
  
  private static void SetHueModulation(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.HueModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturation(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Saturation>()?.Val);
  }
  
  private static bool CmpSaturation(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Saturation>()?.Val, value, diffs, objName, "Saturation");
  }
  
  private static void SetSaturation(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Saturation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationOffset(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>()?.Val);
  }
  
  private static bool CmpSaturationOffset(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>()?.Val, value, diffs, objName, "SaturationOffset");
  }
  
  private static void SetSaturationOffset(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.SaturationOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationModulation(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>()?.Val);
  }
  
  private static bool CmpSaturationModulation(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>()?.Val, value, diffs, objName, "SaturationModulation");
  }
  
  private static void SetSaturationModulation(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.SaturationModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminance(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Luminance>()?.Val);
  }
  
  private static bool CmpLuminance(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Luminance>()?.Val, value, diffs, objName, "Luminance");
  }
  
  private static void SetLuminance(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Luminance,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceOffset(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>()?.Val);
  }
  
  private static bool CmpLuminanceOffset(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>()?.Val, value, diffs, objName, "LuminanceOffset");
  }
  
  private static void SetLuminanceOffset(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.LuminanceOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceModulation(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>()?.Val);
  }
  
  private static bool CmpLuminanceModulation(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>()?.Val, value, diffs, objName, "LuminanceModulation");
  }
  
  private static void SetLuminanceModulation(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.LuminanceModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRed(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Red>()?.Val);
  }
  
  private static bool CmpRed(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Red>()?.Val, value, diffs, objName, "Red");
  }
  
  private static void SetRed(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Red,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRedOffset(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.RedOffset>()?.Val);
  }
  
  private static bool CmpRedOffset(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.RedOffset>()?.Val, value, diffs, objName, "RedOffset");
  }
  
  private static void SetRedOffset(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.RedOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRedModulation(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.RedModulation>()?.Val);
  }
  
  private static bool CmpRedModulation(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.RedModulation>()?.Val, value, diffs, objName, "RedModulation");
  }
  
  private static void SetRedModulation(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.RedModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreen(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Green>()?.Val);
  }
  
  private static bool CmpGreen(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Green>()?.Val, value, diffs, objName, "Green");
  }
  
  private static void SetGreen(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Green,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreenOffset(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.GreenOffset>()?.Val);
  }
  
  private static bool CmpGreenOffset(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.GreenOffset>()?.Val, value, diffs, objName, "GreenOffset");
  }
  
  private static void SetGreenOffset(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.GreenOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreenModulation(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.GreenModulation>()?.Val);
  }
  
  private static bool CmpGreenModulation(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.GreenModulation>()?.Val, value, diffs, objName, "GreenModulation");
  }
  
  private static void SetGreenModulation(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.GreenModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlue(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Blue>()?.Val);
  }
  
  private static bool CmpBlue(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Blue>()?.Val, value, diffs, objName, "Blue");
  }
  
  private static void SetBlue(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Blue,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlueOffset(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.BlueOffset>()?.Val);
  }
  
  private static bool CmpBlueOffset(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.BlueOffset>()?.Val, value, diffs, objName, "BlueOffset");
  }
  
  private static void SetBlueOffset(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.BlueOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlueModulation(DXDraw.SystemColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.BlueModulation>()?.Val);
  }
  
  private static bool CmpBlueModulation(DXDraw.SystemColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.BlueModulation>()?.Val, value, diffs, objName, "BlueModulation");
  }
  
  private static void SetBlueModulation(DXDraw.SystemColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.BlueModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetGamma(DXDraw.SystemColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gamma>() != null;
  }
  
  private static bool CmpGamma(DXDraw.SystemColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Gamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Gamma", val, value);
    return false;
  }
  
  private static void SetGamma(DXDraw.SystemColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.Gamma>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.Gamma();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetInverseGamma(DXDraw.SystemColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.InverseGamma>() != null;
  }
  
  private static bool CmpInverseGamma(DXDraw.SystemColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.InverseGamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.InverseGamma", val, value);
    return false;
  }
  
  private static void SetInverseGamma(DXDraw.SystemColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDraw.InverseGamma>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDraw.InverseGamma();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.SystemColor? CreateModelElement(DXDraw.SystemColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SystemColor();
      value.Val = GetVal(openXmlElement);
      value.LastColor = GetLastColor(openXmlElement);
      value.Tint = GetTint(openXmlElement);
      value.Shade = GetShade(openXmlElement);
      value.Complement = GetComplement(openXmlElement);
      value.Inverse = GetInverse(openXmlElement);
      value.Gray = GetGray(openXmlElement);
      value.Alpha = GetAlpha(openXmlElement);
      value.AlphaOffset = GetAlphaOffset(openXmlElement);
      value.AlphaModulation = GetAlphaModulation(openXmlElement);
      value.Hue = GetHue(openXmlElement);
      value.HueOffset = GetHueOffset(openXmlElement);
      value.HueModulation = GetHueModulation(openXmlElement);
      value.Saturation = GetSaturation(openXmlElement);
      value.SaturationOffset = GetSaturationOffset(openXmlElement);
      value.SaturationModulation = GetSaturationModulation(openXmlElement);
      value.Luminance = GetLuminance(openXmlElement);
      value.LuminanceOffset = GetLuminanceOffset(openXmlElement);
      value.LuminanceModulation = GetLuminanceModulation(openXmlElement);
      value.Red = GetRed(openXmlElement);
      value.RedOffset = GetRedOffset(openXmlElement);
      value.RedModulation = GetRedModulation(openXmlElement);
      value.Green = GetGreen(openXmlElement);
      value.GreenOffset = GetGreenOffset(openXmlElement);
      value.GreenModulation = GetGreenModulation(openXmlElement);
      value.Blue = GetBlue(openXmlElement);
      value.BlueOffset = GetBlueOffset(openXmlElement);
      value.BlueModulation = GetBlueModulation(openXmlElement);
      value.Gamma = GetGamma(openXmlElement);
      value.InverseGamma = GetInverseGamma(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.SystemColor? openXmlElement, DMDraws.SystemColor? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpLastColor(openXmlElement, value.LastColor, diffs, objName))
        ok = false;
      if (!CmpTint(openXmlElement, value.Tint, diffs, objName))
        ok = false;
      if (!CmpShade(openXmlElement, value.Shade, diffs, objName))
        ok = false;
      if (!CmpComplement(openXmlElement, value.Complement, diffs, objName))
        ok = false;
      if (!CmpInverse(openXmlElement, value.Inverse, diffs, objName))
        ok = false;
      if (!CmpGray(openXmlElement, value.Gray, diffs, objName))
        ok = false;
      if (!CmpAlpha(openXmlElement, value.Alpha, diffs, objName))
        ok = false;
      if (!CmpAlphaOffset(openXmlElement, value.AlphaOffset, diffs, objName))
        ok = false;
      if (!CmpAlphaModulation(openXmlElement, value.AlphaModulation, diffs, objName))
        ok = false;
      if (!CmpHue(openXmlElement, value.Hue, diffs, objName))
        ok = false;
      if (!CmpHueOffset(openXmlElement, value.HueOffset, diffs, objName))
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
      if (!CmpRed(openXmlElement, value.Red, diffs, objName))
        ok = false;
      if (!CmpRedOffset(openXmlElement, value.RedOffset, diffs, objName))
        ok = false;
      if (!CmpRedModulation(openXmlElement, value.RedModulation, diffs, objName))
        ok = false;
      if (!CmpGreen(openXmlElement, value.Green, diffs, objName))
        ok = false;
      if (!CmpGreenOffset(openXmlElement, value.GreenOffset, diffs, objName))
        ok = false;
      if (!CmpGreenModulation(openXmlElement, value.GreenModulation, diffs, objName))
        ok = false;
      if (!CmpBlue(openXmlElement, value.Blue, diffs, objName))
        ok = false;
      if (!CmpBlueOffset(openXmlElement, value.BlueOffset, diffs, objName))
        ok = false;
      if (!CmpBlueModulation(openXmlElement, value.BlueModulation, diffs, objName))
        ok = false;
      if (!CmpGamma(openXmlElement, value.Gamma, diffs, objName))
        ok = false;
      if (!CmpInverseGamma(openXmlElement, value.InverseGamma, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SystemColor value)
    where OpenXmlElementType: DXDraw.SystemColor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.SystemColor openXmlElement, DMDraws.SystemColor value)
  {
    SetVal(openXmlElement, value?.Val);
    SetLastColor(openXmlElement, value?.LastColor);
    SetTint(openXmlElement, value?.Tint);
    SetShade(openXmlElement, value?.Shade);
    SetComplement(openXmlElement, value?.Complement);
    SetInverse(openXmlElement, value?.Inverse);
    SetGray(openXmlElement, value?.Gray);
    SetAlpha(openXmlElement, value?.Alpha);
    SetAlphaOffset(openXmlElement, value?.AlphaOffset);
    SetAlphaModulation(openXmlElement, value?.AlphaModulation);
    SetHue(openXmlElement, value?.Hue);
    SetHueOffset(openXmlElement, value?.HueOffset);
    SetHueModulation(openXmlElement, value?.HueModulation);
    SetSaturation(openXmlElement, value?.Saturation);
    SetSaturationOffset(openXmlElement, value?.SaturationOffset);
    SetSaturationModulation(openXmlElement, value?.SaturationModulation);
    SetLuminance(openXmlElement, value?.Luminance);
    SetLuminanceOffset(openXmlElement, value?.LuminanceOffset);
    SetLuminanceModulation(openXmlElement, value?.LuminanceModulation);
    SetRed(openXmlElement, value?.Red);
    SetRedOffset(openXmlElement, value?.RedOffset);
    SetRedModulation(openXmlElement, value?.RedModulation);
    SetGreen(openXmlElement, value?.Green);
    SetGreenOffset(openXmlElement, value?.GreenOffset);
    SetGreenModulation(openXmlElement, value?.GreenModulation);
    SetBlue(openXmlElement, value?.Blue);
    SetBlueOffset(openXmlElement, value?.BlueOffset);
    SetBlueModulation(openXmlElement, value?.BlueModulation);
    SetGamma(openXmlElement, value?.Gamma);
    SetInverseGamma(openXmlElement, value?.InverseGamma);
  }
}
