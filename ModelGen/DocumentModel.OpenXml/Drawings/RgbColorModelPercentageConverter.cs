namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// RGB Color Model - Percentage Variant.
/// </summary>
public static class RgbColorModelPercentageConverter
{
  /// <summary>
  /// Red
  /// </summary>
  private static Int32? GetRedPortion(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.RedPortion?.Value;
  }
  
  private static bool CmpRedPortion(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RedPortion?.Value == value) return true;
    diffs?.Add(objName, "RedPortion", openXmlElement?.RedPortion?.Value, value);
    return false;
  }
  
  private static void SetRedPortion(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    openXmlElement.RedPortion = value;
  }
  
  /// <summary>
  /// Green
  /// </summary>
  private static Int32? GetGreenPortion(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GreenPortion?.Value;
  }
  
  private static bool CmpGreenPortion(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GreenPortion?.Value == value) return true;
    diffs?.Add(objName, "GreenPortion", openXmlElement?.GreenPortion?.Value, value);
    return false;
  }
  
  private static void SetGreenPortion(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    openXmlElement.GreenPortion = value;
  }
  
  /// <summary>
  /// Blue
  /// </summary>
  private static Int32? GetBluePortion(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.BluePortion?.Value;
  }
  
  private static bool CmpBluePortion(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.BluePortion?.Value == value) return true;
    diffs?.Add(objName, "BluePortion", openXmlElement?.BluePortion?.Value, value);
    return false;
  }
  
  private static void SetBluePortion(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    openXmlElement.BluePortion = value;
  }
  
  private static Int32? GetTint(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Tint>()?.Val);
  }
  
  private static bool CmpTint(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Tint>()?.Val, value, diffs, objName, "Tint");
  }
  
  private static void SetTint(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Tint,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetShade(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Shade>()?.Val);
  }
  
  private static bool CmpShade(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Shade>()?.Val, value, diffs, objName, "Shade");
  }
  
  private static void SetShade(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Shade,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetComplement(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Complement>() != null;
  }
  
  private static bool CmpComplement(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Complement>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Complement", val, value);
    return false;
  }
  
  private static void SetComplement(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverse(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Inverse>() != null;
  }
  
  private static bool CmpInverse(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Inverse>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Inverse", val, value);
    return false;
  }
  
  private static void SetInverse(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value)
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
  
  private static Boolean? GetGray(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gray>() != null;
  }
  
  private static bool CmpGray(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Gray>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Gray", val, value);
    return false;
  }
  
  private static void SetGray(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value)
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
  
  private static Int32? GetAlpha(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Alpha>()?.Val);
  }
  
  private static bool CmpAlpha(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Alpha>()?.Val, value, diffs, objName, "Alpha");
  }
  
  private static void SetAlpha(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Alpha,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetAlphaOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>()?.Val);
  }
  
  private static bool CmpAlphaOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>()?.Val, value, diffs, objName, "AlphaOffset");
  }
  
  private static void SetAlphaOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.AlphaOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetAlphaModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>()?.Val);
  }
  
  private static bool CmpAlphaModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>()?.Val, value, diffs, objName, "AlphaModulation");
  }
  
  private static void SetAlphaModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.AlphaModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHue(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Hue>()?.Val);
  }
  
  private static bool CmpHue(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Hue>()?.Val, value, diffs, objName, "Hue");
  }
  
  private static void SetHue(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Hue,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHueOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.HueOffset>()?.Val);
  }
  
  private static bool CmpHueOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.HueOffset>()?.Val, value, diffs, objName, "HueOffset");
  }
  
  private static void SetHueOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.HueOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetHueModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.HueModulation>()?.Val);
  }
  
  private static bool CmpHueModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.HueModulation>()?.Val, value, diffs, objName, "HueModulation");
  }
  
  private static void SetHueModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.HueModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Saturation>()?.Val);
  }
  
  private static bool CmpSaturation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Saturation>()?.Val, value, diffs, objName, "Saturation");
  }
  
  private static void SetSaturation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Saturation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>()?.Val);
  }
  
  private static bool CmpSaturationOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>()?.Val, value, diffs, objName, "SaturationOffset");
  }
  
  private static void SetSaturationOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.SaturationOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetSaturationModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>()?.Val);
  }
  
  private static bool CmpSaturationModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>()?.Val, value, diffs, objName, "SaturationModulation");
  }
  
  private static void SetSaturationModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.SaturationModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminance(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Luminance>()?.Val);
  }
  
  private static bool CmpLuminance(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Luminance>()?.Val, value, diffs, objName, "Luminance");
  }
  
  private static void SetLuminance(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Luminance,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>()?.Val);
  }
  
  private static bool CmpLuminanceOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>()?.Val, value, diffs, objName, "LuminanceOffset");
  }
  
  private static void SetLuminanceOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.LuminanceOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetLuminanceModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>()?.Val);
  }
  
  private static bool CmpLuminanceModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>()?.Val, value, diffs, objName, "LuminanceModulation");
  }
  
  private static void SetLuminanceModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.LuminanceModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRed(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Red>()?.Val);
  }
  
  private static bool CmpRed(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Red>()?.Val, value, diffs, objName, "Red");
  }
  
  private static void SetRed(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Red,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRedOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.RedOffset>()?.Val);
  }
  
  private static bool CmpRedOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.RedOffset>()?.Val, value, diffs, objName, "RedOffset");
  }
  
  private static void SetRedOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.RedOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetRedModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.RedModulation>()?.Val);
  }
  
  private static bool CmpRedModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.RedModulation>()?.Val, value, diffs, objName, "RedModulation");
  }
  
  private static void SetRedModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.RedModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreen(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Green>()?.Val);
  }
  
  private static bool CmpGreen(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Green>()?.Val, value, diffs, objName, "Green");
  }
  
  private static void SetGreen(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Green,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreenOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.GreenOffset>()?.Val);
  }
  
  private static bool CmpGreenOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.GreenOffset>()?.Val, value, diffs, objName, "GreenOffset");
  }
  
  private static void SetGreenOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.GreenOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetGreenModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.GreenModulation>()?.Val);
  }
  
  private static bool CmpGreenModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.GreenModulation>()?.Val, value, diffs, objName, "GreenModulation");
  }
  
  private static void SetGreenModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.GreenModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlue(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.Blue>()?.Val);
  }
  
  private static bool CmpBlue(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.Blue>()?.Val, value, diffs, objName, "Blue");
  }
  
  private static void SetBlue(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.Blue,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlueOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.BlueOffset>()?.Val);
  }
  
  private static bool CmpBlueOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.BlueOffset>()?.Val, value, diffs, objName, "BlueOffset");
  }
  
  private static void SetBlueOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.BlueOffset,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetBlueModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDraw.BlueModulation>()?.Val);
  }
  
  private static bool CmpBlueModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDraw.BlueModulation>()?.Val, value, diffs, objName, "BlueModulation");
  }
  
  private static void SetBlueModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDraw.BlueModulation,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetGamma(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gamma>() != null;
  }
  
  private static bool CmpGamma(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Gamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Gamma", val, value);
    return false;
  }
  
  private static void SetGamma(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverseGamma(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.InverseGamma>() != null;
  }
  
  private static bool CmpInverseGamma(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.InverseGamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.InverseGamma", val, value);
    return false;
  }
  
  private static void SetInverseGamma(DXDraw.RgbColorModelPercentage openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Drawings.RgbColorModelPercentage? CreateModelElement(DXDraw.RgbColorModelPercentage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RgbColorModelPercentage();
      value.RedPortion = GetRedPortion(openXmlElement);
      value.GreenPortion = GetGreenPortion(openXmlElement);
      value.BluePortion = GetBluePortion(openXmlElement);
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
  
  public static bool CompareModelElement(DXDraw.RgbColorModelPercentage? openXmlElement, DMDraws.RgbColorModelPercentage? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRedPortion(openXmlElement, value.RedPortion, diffs, objName))
        ok = false;
      if (!CmpGreenPortion(openXmlElement, value.GreenPortion, diffs, objName))
        ok = false;
      if (!CmpBluePortion(openXmlElement, value.BluePortion, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.RgbColorModelPercentage value)
    where OpenXmlElementType: DXDraw.RgbColorModelPercentage, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.RgbColorModelPercentage openXmlElement, DMDraws.RgbColorModelPercentage value)
  {
    SetRedPortion(openXmlElement, value?.RedPortion);
    SetGreenPortion(openXmlElement, value?.GreenPortion);
    SetBluePortion(openXmlElement, value?.BluePortion);
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
