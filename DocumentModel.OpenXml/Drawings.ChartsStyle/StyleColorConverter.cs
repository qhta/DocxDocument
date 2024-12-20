namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleColor Class.
/// </summary>
public static class StyleColorConverter
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetVal(DXO13DCS.StyleColor openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXO13DCS.StyleColor openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXO13DCS.StyleColor openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  private static Int32? GetTint(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Tint>()?.Val);
  }
  
  private static bool CmpTint(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Tint>()?.Val, value, diffs, objName, "Tint");
  }
  
  private static void SetTint(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Tint,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetShade(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Shade>()?.Val);
  }
  
  private static bool CmpShade(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Shade>()?.Val, value, diffs, objName, "Shade");
  }
  
  private static void SetShade(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Shade,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean GetComplement(DXO13DCS.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Complement>() != null;
  }
  
  private static bool CmpComplement(DXO13DCS.StyleColor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.Complement>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Complement", val, value);
    return false;
  }
  
  private static void SetComplement(DXO13DCS.StyleColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.Complement>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.Complement();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean GetInverse(DXO13DCS.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Inverse>() != null;
  }
  
  private static bool CmpInverse(DXO13DCS.StyleColor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.Inverse>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Inverse", val, value);
    return false;
  }
  
  private static void SetInverse(DXO13DCS.StyleColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.Inverse>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.Inverse();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean GetGray(DXO13DCS.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Gray>() != null;
  }
  
  private static bool CmpGray(DXO13DCS.StyleColor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.Gray>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Gray", val, value);
    return false;
  }
  
  private static void SetGray(DXO13DCS.StyleColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.Gray>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.Gray();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetAlpha(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Alpha>()?.Val);
  }
  
  private static bool CmpAlpha(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Alpha>()?.Val, value, diffs, objName, "Alpha");
  }
  
  private static void SetAlpha(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Alpha,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetAlphaOffset(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.AlphaOffset>()?.Val);
  }
  
  private static bool CmpAlphaOffset(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.AlphaOffset>()?.Val, value, diffs, objName, "AlphaOffset");
  }
  
  private static void SetAlphaOffset(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.AlphaOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetAlphaModulation(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.AlphaModulation>()?.Val);
  }
  
  private static bool CmpAlphaModulation(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.AlphaModulation>()?.Val, value, diffs, objName, "AlphaModulation");
  }
  
  private static void SetAlphaModulation(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.AlphaModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHue(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Hue>()?.Val);
  }
  
  private static bool CmpHue(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Hue>()?.Val, value, diffs, objName, "Hue");
  }
  
  private static void SetHue(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Hue,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHueOffset(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.HueOffset>()?.Val);
  }
  
  private static bool CmpHueOffset(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.HueOffset>()?.Val, value, diffs, objName, "HueOffset");
  }
  
  private static void SetHueOffset(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.HueOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHueModulation(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.HueModulation>()?.Val);
  }
  
  private static bool CmpHueModulation(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.HueModulation>()?.Val, value, diffs, objName, "HueModulation");
  }
  
  private static void SetHueModulation(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.HueModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturation(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Saturation>()?.Val);
  }
  
  private static bool CmpSaturation(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Saturation>()?.Val, value, diffs, objName, "Saturation");
  }
  
  private static void SetSaturation(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Saturation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationOffset(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.SaturationOffset>()?.Val);
  }
  
  private static bool CmpSaturationOffset(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.SaturationOffset>()?.Val, value, diffs, objName, "SaturationOffset");
  }
  
  private static void SetSaturationOffset(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.SaturationOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationModulation(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.SaturationModulation>()?.Val);
  }
  
  private static bool CmpSaturationModulation(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.SaturationModulation>()?.Val, value, diffs, objName, "SaturationModulation");
  }
  
  private static void SetSaturationModulation(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.SaturationModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminance(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Luminance>()?.Val);
  }
  
  private static bool CmpLuminance(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Luminance>()?.Val, value, diffs, objName, "Luminance");
  }
  
  private static void SetLuminance(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Luminance,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceOffset(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.LuminanceOffset>()?.Val);
  }
  
  private static bool CmpLuminanceOffset(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.LuminanceOffset>()?.Val, value, diffs, objName, "LuminanceOffset");
  }
  
  private static void SetLuminanceOffset(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.LuminanceOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceModulation(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.LuminanceModulation>()?.Val);
  }
  
  private static bool CmpLuminanceModulation(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.LuminanceModulation>()?.Val, value, diffs, objName, "LuminanceModulation");
  }
  
  private static void SetLuminanceModulation(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.LuminanceModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRed(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Red>()?.Val);
  }
  
  private static bool CmpRed(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Red>()?.Val, value, diffs, objName, "Red");
  }
  
  private static void SetRed(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Red,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRedOffset(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.RedOffset>()?.Val);
  }
  
  private static bool CmpRedOffset(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.RedOffset>()?.Val, value, diffs, objName, "RedOffset");
  }
  
  private static void SetRedOffset(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.RedOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRedModulation(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.RedModulation>()?.Val);
  }
  
  private static bool CmpRedModulation(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.RedModulation>()?.Val, value, diffs, objName, "RedModulation");
  }
  
  private static void SetRedModulation(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.RedModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreen(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Green>()?.Val);
  }
  
  private static bool CmpGreen(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Green>()?.Val, value, diffs, objName, "Green");
  }
  
  private static void SetGreen(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Green,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreenOffset(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.GreenOffset>()?.Val);
  }
  
  private static bool CmpGreenOffset(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.GreenOffset>()?.Val, value, diffs, objName, "GreenOffset");
  }
  
  private static void SetGreenOffset(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.GreenOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreenModulation(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.GreenModulation>()?.Val);
  }
  
  private static bool CmpGreenModulation(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.GreenModulation>()?.Val, value, diffs, objName, "GreenModulation");
  }
  
  private static void SetGreenModulation(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.GreenModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlue(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.Blue>()?.Val);
  }
  
  private static bool CmpBlue(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.Blue>()?.Val, value, diffs, objName, "Blue");
  }
  
  private static void SetBlue(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.Blue,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlueOffset(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.BlueOffset>()?.Val);
  }
  
  private static bool CmpBlueOffset(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.BlueOffset>()?.Val, value, diffs, objName, "BlueOffset");
  }
  
  private static void SetBlueOffset(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.BlueOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlueModulation(DXO13DCS.StyleColor openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXD.BlueModulation>()?.Val);
  }
  
  private static bool CmpBlueModulation(DXO13DCS.StyleColor openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXD.BlueModulation>()?.Val, value, diffs, objName, "BlueModulation");
  }
  
  private static void SetBlueModulation(DXO13DCS.StyleColor openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXD.BlueModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean GetGamma(DXO13DCS.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Gamma>() != null;
  }
  
  private static bool CmpGamma(DXO13DCS.StyleColor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.Gamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Gamma", val, value);
    return false;
  }
  
  private static void SetGamma(DXO13DCS.StyleColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.Gamma>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.Gamma();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean GetInverseGamma(DXO13DCS.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.InverseGamma>() != null;
  }
  
  private static bool CmpInverseGamma(DXO13DCS.StyleColor openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXD.InverseGamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.InverseGamma", val, value);
    return false;
  }
  
  private static void SetInverseGamma(DXO13DCS.StyleColor openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXD.InverseGamma>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXD.InverseGamma();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCS.StyleColor? CreateModelElement(DXO13DCS.StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCS.StyleColor();
      value.Val = GetVal(openXmlElement);
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
  
  public static bool CompareModelElement(DXO13DCS.StyleColor? openXmlElement, DMDCS.StyleColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      if (!CmpTint(openXmlElement, value.Tint, diffs, objName, propName))
        ok = false;
      if (!CmpShade(openXmlElement, value.Shade, diffs, objName, propName))
        ok = false;
      if (!CmpComplement(openXmlElement, value.Complement, diffs, objName, propName))
        ok = false;
      if (!CmpInverse(openXmlElement, value.Inverse, diffs, objName, propName))
        ok = false;
      if (!CmpGray(openXmlElement, value.Gray, diffs, objName, propName))
        ok = false;
      if (!CmpAlpha(openXmlElement, value.Alpha, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaOffset(openXmlElement, value.AlphaOffset, diffs, objName, propName))
        ok = false;
      if (!CmpAlphaModulation(openXmlElement, value.AlphaModulation, diffs, objName, propName))
        ok = false;
      if (!CmpHue(openXmlElement, value.Hue, diffs, objName, propName))
        ok = false;
      if (!CmpHueOffset(openXmlElement, value.HueOffset, diffs, objName, propName))
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
      if (!CmpRed(openXmlElement, value.Red, diffs, objName, propName))
        ok = false;
      if (!CmpRedOffset(openXmlElement, value.RedOffset, diffs, objName, propName))
        ok = false;
      if (!CmpRedModulation(openXmlElement, value.RedModulation, diffs, objName, propName))
        ok = false;
      if (!CmpGreen(openXmlElement, value.Green, diffs, objName, propName))
        ok = false;
      if (!CmpGreenOffset(openXmlElement, value.GreenOffset, diffs, objName, propName))
        ok = false;
      if (!CmpGreenModulation(openXmlElement, value.GreenModulation, diffs, objName, propName))
        ok = false;
      if (!CmpBlue(openXmlElement, value.Blue, diffs, objName, propName))
        ok = false;
      if (!CmpBlueOffset(openXmlElement, value.BlueOffset, diffs, objName, propName))
        ok = false;
      if (!CmpBlueModulation(openXmlElement, value.BlueModulation, diffs, objName, propName))
        ok = false;
      if (!CmpGamma(openXmlElement, value.Gamma, diffs, objName, propName))
        ok = false;
      if (!CmpInverseGamma(openXmlElement, value.InverseGamma, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.StyleColor value)
    where OpenXmlElementType: DXO13DCS.StyleColor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.StyleColor openXmlElement, DMDCS.StyleColor value)
  {
    SetVal(openXmlElement, value?.Val);
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
