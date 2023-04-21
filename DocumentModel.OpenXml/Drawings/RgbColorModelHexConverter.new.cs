namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// RGB Color Model - Hex Variant.
/// </summary>
public static class RgbColorModelHexConverter
{
  /// <summary>
  /// Value
  /// </summary>
  private static DM.RGB? GetVal(DXD.RgbColorModelHex openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
    {
      var val = UInt32.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber);
      var rgb = (DM.RGB)val;
      return rgb;
    }
    return null;
  }
  
  private static bool CmpVal(DXD.RgbColorModelHex openXmlElement, DM.RGB? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value != null)
      if (UInt32.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber) == (UInt32?)value)
        return true;
    if (openXmlElement?.Val?.Value == null && value == null) return true;
    diffs?.Add(objName, "Value", openXmlElement?.Val?.Value, value?.ToString());
    return false;
  }
  
  private static void SetVal(DXD.RgbColorModelHex openXmlElement, DM.RGB? value)
  {
    if (value != null)
      openXmlElement.Val = ((UInt32)value).ToString("X6");
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// legacySpreadsheetColorIndex, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLegacySpreadsheetColorIndex(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.LegacySpreadsheetColorIndex?.Value;
  }
  
  private static bool CmpLegacySpreadsheetColorIndex(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LegacySpreadsheetColorIndex?.Value == value) return true;
    diffs?.Add(objName, "LegacySpreadsheetColorIndex", openXmlElement?.LegacySpreadsheetColorIndex?.Value, value);
    return false;
  }
  
  private static void SetLegacySpreadsheetColorIndex(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    openXmlElement.LegacySpreadsheetColorIndex = value;
  }
  
  private static Int32? GetTint(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Tint>()?.Val?.Value;
  }
  
  private static bool CmpTint(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Tint>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Tint", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTint(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Tint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Tint{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetShade(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Shade>()?.Val?.Value;
  }
  
  private static bool CmpShade(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Shade>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Shade", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetShade(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Shade>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Shade{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean GetComplement(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Complement>() != null;
  }
  
  private static bool CmpComplement(DXD.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Complement>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Complement", val, value);
    return false;
  }
  
  private static void SetComplement(DXD.RgbColorModelHex openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean GetInverse(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Inverse>() != null;
  }
  
  private static bool CmpInverse(DXD.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Inverse>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Inverse", val, value);
    return false;
  }
  
  private static void SetInverse(DXD.RgbColorModelHex openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean GetGray(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Gray>() != null;
  }
  
  private static bool CmpGray(DXD.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Gray>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Gray", val, value);
    return false;
  }
  
  private static void SetGray(DXD.RgbColorModelHex openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlpha(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Alpha>()?.Val?.Value;
  }
  
  private static bool CmpAlpha(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Alpha>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Alpha", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlpha(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Alpha>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Alpha{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlphaOffset(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.AlphaOffset>()?.Val?.Value;
  }
  
  private static bool CmpAlphaOffset(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.AlphaOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.AlphaOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlphaOffset(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.AlphaOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlphaModulation(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.AlphaModulation>()?.Val?.Value;
  }
  
  private static bool CmpAlphaModulation(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.AlphaModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.AlphaModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlphaModulation(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.AlphaModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHue(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Hue>()?.Val?.Value;
  }
  
  private static bool CmpHue(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Hue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Hue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHue(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Hue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Hue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHueOffset(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.HueOffset>()?.Val?.Value;
  }
  
  private static bool CmpHueOffset(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.HueOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.HueOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueOffset(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HueOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.HueOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHueModulation(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.HueModulation>()?.Val?.Value;
  }
  
  private static bool CmpHueModulation(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.HueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.HueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueModulation(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.HueModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturation(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Saturation>()?.Val?.Value;
  }
  
  private static bool CmpSaturation(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Saturation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Saturation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturation(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Saturation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Saturation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationOffset(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.SaturationOffset>()?.Val?.Value;
  }
  
  private static bool CmpSaturationOffset(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.SaturationOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.SaturationOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationOffset(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SaturationOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.SaturationOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationModulation(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.SaturationModulation>()?.Val?.Value;
  }
  
  private static bool CmpSaturationModulation(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.SaturationModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.SaturationModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationModulation(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SaturationModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.SaturationModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminance(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Luminance>()?.Val?.Value;
  }
  
  private static bool CmpLuminance(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Luminance>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Luminance", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminance(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Luminance>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Luminance{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceOffset(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.LuminanceOffset>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceOffset(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.LuminanceOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.LuminanceOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceOffset(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LuminanceOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.LuminanceOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceModulation(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.LuminanceModulation>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceModulation(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.LuminanceModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.LuminanceModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceModulation(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LuminanceModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.LuminanceModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRed(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Red>()?.Val?.Value;
  }
  
  private static bool CmpRed(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Red>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Red", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRed(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Red>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Red{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRedOffset(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.RedOffset>()?.Val?.Value;
  }
  
  private static bool CmpRedOffset(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.RedOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.RedOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRedOffset(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RedOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.RedOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRedModulation(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.RedModulation>()?.Val?.Value;
  }
  
  private static bool CmpRedModulation(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.RedModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.RedModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRedModulation(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RedModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.RedModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreen(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Green>()?.Val?.Value;
  }
  
  private static bool CmpGreen(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Green>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Green", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreen(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Green>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Green{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreenOffset(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.GreenOffset>()?.Val?.Value;
  }
  
  private static bool CmpGreenOffset(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.GreenOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.GreenOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreenOffset(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GreenOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.GreenOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreenModulation(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.GreenModulation>()?.Val?.Value;
  }
  
  private static bool CmpGreenModulation(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.GreenModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.GreenModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreenModulation(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GreenModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.GreenModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlue(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Blue>()?.Val?.Value;
  }
  
  private static bool CmpBlue(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Blue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Blue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlue(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Blue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlueOffset(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.BlueOffset>()?.Val?.Value;
  }
  
  private static bool CmpBlueOffset(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.BlueOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.BlueOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlueOffset(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlueOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.BlueOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlueModulation(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.BlueModulation>()?.Val?.Value;
  }
  
  private static bool CmpBlueModulation(DXD.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.BlueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.BlueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlueModulation(DXD.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.BlueModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean GetGamma(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Gamma>() != null;
  }
  
  private static bool CmpGamma(DXD.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Gamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Gamma", val, value);
    return false;
  }
  
  private static void SetGamma(DXD.RgbColorModelHex openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean GetInverseGamma(DXD.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.InverseGamma>() != null;
  }
  
  private static bool CmpInverseGamma(DXD.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.InverseGamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.InverseGamma", val, value);
    return false;
  }
  
  private static void SetInverseGamma(DXD.RgbColorModelHex openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMD.RgbColorModelHex? CreateModelElement(DXD.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.RgbColorModelHex();
      value.Val = GetVal(openXmlElement);
      value.LegacySpreadsheetColorIndex = GetLegacySpreadsheetColorIndex(openXmlElement);
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
  
  public static bool CompareModelElement(DXD.RgbColorModelHex? openXmlElement, DMD.RgbColorModelHex? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpLegacySpreadsheetColorIndex(openXmlElement, value.LegacySpreadsheetColorIndex, diffs, objName))
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMD.RgbColorModelHex? value)
    where OpenXmlElementType: DXD.RgbColorModelHex, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetLegacySpreadsheetColorIndex(openXmlElement, value?.LegacySpreadsheetColorIndex);
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
      return openXmlElement;
    }
    return default;
  }
}
