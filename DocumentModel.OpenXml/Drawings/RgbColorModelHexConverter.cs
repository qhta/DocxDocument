namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// RGB Color Model - Hex Variant.
/// </summary>
public static class RgbColorModelHexConverter
{
  /// <summary>
  /// Value
  /// </summary>
  private static DM.RGB? GetVal(DXDraw.RgbColorModelHex openXmlElement)
  {
    if (openXmlElement.Val?.Value != null)
      return (DocumentModel.RGB)UInt32.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpVal(DXDraw.RgbColorModelHex openXmlElement, DM.RGB? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement.Val?.Value != null)
      return (DocumentModel.RGB)UInt32.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber) == value;
    return openXmlElement == null && value == null;
  }
  
  private static void SetVal(DXDraw.RgbColorModelHex openXmlElement, DM.RGB? value)
  {
      if (value != null)
        openXmlElement.Val = ((UInt32)value).ToString("X6");
      else
        openXmlElement.Val = null;
  }
  
  /// <summary>
  /// legacySpreadsheetColorIndex, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLegacySpreadsheetColorIndex(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.LegacySpreadsheetColorIndex?.Value;
  }
  
  private static bool CmpLegacySpreadsheetColorIndex(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.LegacySpreadsheetColorIndex?.Value == value;
  }
  
  private static void SetLegacySpreadsheetColorIndex(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    openXmlElement.LegacySpreadsheetColorIndex = value;
  }
  
  private static Int32? GetTint(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Tint>()?.Val?.Value;
  }
  
  private static bool CmpTint(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Tint>()?.Val?.Value == value;
  }
  
  private static void SetTint(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Tint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Tint{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetShade(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Shade>()?.Val?.Value;
  }
  
  private static bool CmpShade(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Shade>()?.Val?.Value == value;
  }
  
  private static void SetShade(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Shade>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Shade{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetComplement(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Complement>() != null;
  }
  
  private static bool CmpComplement(DXDraw.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.Complement>() != null == value;
  }
  
  private static void SetComplement(DXDraw.RgbColorModelHex openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverse(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Inverse>() != null;
  }
  
  private static bool CmpInverse(DXDraw.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.Inverse>() != null == value;
  }
  
  private static void SetInverse(DXDraw.RgbColorModelHex openXmlElement, Boolean? value)
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
  
  private static Boolean? GetGray(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gray>() != null;
  }
  
  private static bool CmpGray(DXDraw.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gray>() != null == value;
  }
  
  private static void SetGray(DXDraw.RgbColorModelHex openXmlElement, Boolean? value)
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
  
  private static Int32? GetAlpha(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Alpha>()?.Val?.Value;
  }
  
  private static bool CmpAlpha(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Alpha>()?.Val?.Value == value;
  }
  
  private static void SetAlpha(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Alpha>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Alpha{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlphaOffset(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>()?.Val?.Value;
  }
  
  private static bool CmpAlphaOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>()?.Val?.Value == value;
  }
  
  private static void SetAlphaOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.AlphaOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlphaModulation(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>()?.Val?.Value;
  }
  
  private static bool CmpAlphaModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>()?.Val?.Value == value;
  }
  
  private static void SetAlphaModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.AlphaModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.AlphaModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHue(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Hue>()?.Val?.Value;
  }
  
  private static bool CmpHue(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Hue>()?.Val?.Value == value;
  }
  
  private static void SetHue(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Hue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Hue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHueOffset(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.HueOffset>()?.Val?.Value;
  }
  
  private static bool CmpHueOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.HueOffset>()?.Val?.Value == value;
  }
  
  private static void SetHueOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HueOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.HueOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHueModulation(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.HueModulation>()?.Val?.Value;
  }
  
  private static bool CmpHueModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.HueModulation>()?.Val?.Value == value;
  }
  
  private static void SetHueModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.HueModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturation(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Saturation>()?.Val?.Value;
  }
  
  private static bool CmpSaturation(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Saturation>()?.Val?.Value == value;
  }
  
  private static void SetSaturation(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Saturation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Saturation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationOffset(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>()?.Val?.Value;
  }
  
  private static bool CmpSaturationOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>()?.Val?.Value == value;
  }
  
  private static void SetSaturationOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SaturationOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.SaturationOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationModulation(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>()?.Val?.Value;
  }
  
  private static bool CmpSaturationModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>()?.Val?.Value == value;
  }
  
  private static void SetSaturationModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SaturationModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.SaturationModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminance(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Luminance>()?.Val?.Value;
  }
  
  private static bool CmpLuminance(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Luminance>()?.Val?.Value == value;
  }
  
  private static void SetLuminance(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Luminance>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Luminance{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceOffset(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>()?.Val?.Value == value;
  }
  
  private static void SetLuminanceOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LuminanceOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.LuminanceOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceModulation(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>()?.Val?.Value == value;
  }
  
  private static void SetLuminanceModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LuminanceModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.LuminanceModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRed(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Red>()?.Val?.Value;
  }
  
  private static bool CmpRed(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Red>()?.Val?.Value == value;
  }
  
  private static void SetRed(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Red>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Red{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRedOffset(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.RedOffset>()?.Val?.Value;
  }
  
  private static bool CmpRedOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.RedOffset>()?.Val?.Value == value;
  }
  
  private static void SetRedOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RedOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.RedOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetRedModulation(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.RedModulation>()?.Val?.Value;
  }
  
  private static bool CmpRedModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.RedModulation>()?.Val?.Value == value;
  }
  
  private static void SetRedModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RedModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.RedModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreen(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Green>()?.Val?.Value;
  }
  
  private static bool CmpGreen(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Green>()?.Val?.Value == value;
  }
  
  private static void SetGreen(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Green>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Green{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreenOffset(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.GreenOffset>()?.Val?.Value;
  }
  
  private static bool CmpGreenOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.GreenOffset>()?.Val?.Value == value;
  }
  
  private static void SetGreenOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GreenOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.GreenOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGreenModulation(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.GreenModulation>()?.Val?.Value;
  }
  
  private static bool CmpGreenModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.GreenModulation>()?.Val?.Value == value;
  }
  
  private static void SetGreenModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GreenModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.GreenModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlue(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Blue>()?.Val?.Value;
  }
  
  private static bool CmpBlue(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Blue>()?.Val?.Value == value;
  }
  
  private static void SetBlue(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Blue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.Blue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlueOffset(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BlueOffset>()?.Val?.Value;
  }
  
  private static bool CmpBlueOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BlueOffset>()?.Val?.Value == value;
  }
  
  private static void SetBlueOffset(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BlueOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.BlueOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetBlueModulation(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BlueModulation>()?.Val?.Value;
  }
  
  private static bool CmpBlueModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BlueModulation>()?.Val?.Value == value;
  }
  
  private static void SetBlueModulation(DXDraw.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BlueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDraw.BlueModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetGamma(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gamma>() != null;
  }
  
  private static bool CmpGamma(DXDraw.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gamma>() != null == value;
  }
  
  private static void SetGamma(DXDraw.RgbColorModelHex openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverseGamma(DXDraw.RgbColorModelHex openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.InverseGamma>() != null;
  }
  
  private static bool CmpInverseGamma(DXDraw.RgbColorModelHex openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDraw.InverseGamma>() != null == value;
  }
  
  private static void SetInverseGamma(DXDraw.RgbColorModelHex openXmlElement, Boolean? value)
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
  
  public static DMDraws.RgbColorModelHex? CreateModelElement(DXDraw.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.RgbColorModelHex();
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
  
  public static bool CompareModelElement(DXDraw.RgbColorModelHex? openXmlElement, DMDraws.RgbColorModelHex? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.RgbColorModelHex? value)
    where OpenXmlElementType: DXDraw.RgbColorModelHex, new()
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
