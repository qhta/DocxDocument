namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Hue, Saturation, Luminance Color Model.
/// </summary>
public static class HslColorConverter
{
  /// <summary>
  /// Hue
  /// </summary>
  private static Int32? GetHueValue(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.HueValue?.Value;
  }
  
  private static bool CmpHueValue(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HueValue?.Value == value) return true;
    diffs?.Add(objName, "HueValue", openXmlElement?.HueValue?.Value, value);
    return false;
  }
  
  private static void SetHueValue(DXD.HslColor openXmlElement, Int32? value)
  {
    openXmlElement.HueValue = value;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  private static Int32? GetSatValue(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.SatValue?.Value;
  }
  
  private static bool CmpSatValue(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SatValue?.Value == value) return true;
    diffs?.Add(objName, "SatValue", openXmlElement?.SatValue?.Value, value);
    return false;
  }
  
  private static void SetSatValue(DXD.HslColor openXmlElement, Int32? value)
  {
    openXmlElement.SatValue = value;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  private static Int32? GetLumValue(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.LumValue?.Value;
  }
  
  private static bool CmpLumValue(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.LumValue?.Value == value) return true;
    diffs?.Add(objName, "LumValue", openXmlElement?.LumValue?.Value, value);
    return false;
  }
  
  private static void SetLumValue(DXD.HslColor openXmlElement, Int32? value)
  {
    openXmlElement.LumValue = value;
  }
  
  private static Int32? GetTint(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Tint>()?.Val?.Value;
  }
  
  private static bool CmpTint(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Tint>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Tint", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTint(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Tint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Tint{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetShade(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Shade>()?.Val?.Value;
  }
  
  private static bool CmpShade(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Shade>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Shade", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetShade(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Shade>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Shade{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean GetComplement(DXD.HslColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Complement>() != null;
  }
  
  private static bool CmpComplement(DXD.HslColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Complement>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Complement", val, value);
    return false;
  }
  
  private static void SetComplement(DXD.HslColor openXmlElement, Boolean? value)
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
  
  private static Boolean GetInverse(DXD.HslColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Inverse>() != null;
  }
  
  private static bool CmpInverse(DXD.HslColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Inverse>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Inverse", val, value);
    return false;
  }
  
  private static void SetInverse(DXD.HslColor openXmlElement, Boolean? value)
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
  
  private static Boolean GetGray(DXD.HslColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Gray>() != null;
  }
  
  private static bool CmpGray(DXD.HslColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Gray>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Gray", val, value);
    return false;
  }
  
  private static void SetGray(DXD.HslColor openXmlElement, Boolean? value)
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
  
  private static Int32? GetAlpha(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Alpha>()?.Val?.Value;
  }
  
  private static bool CmpAlpha(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Alpha>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Alpha", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlpha(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Alpha>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Alpha{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetAlphaOffset(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.AlphaOffset>()?.Val?.Value;
  }
  
  private static bool CmpAlphaOffset(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.AlphaOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.AlphaOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlphaOffset(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.AlphaOffset{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetAlphaModulation(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.AlphaModulation>()?.Val?.Value;
  }
  
  private static bool CmpAlphaModulation(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.AlphaModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.AlphaModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlphaModulation(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.AlphaModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.AlphaModulation{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetHue(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Hue>()?.Val?.Value;
  }
  
  private static bool CmpHue(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Hue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Hue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHue(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Hue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Hue{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetHueOffset(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.HueOffset>()?.Val?.Value;
  }
  
  private static bool CmpHueOffset(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.HueOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.HueOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueOffset(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HueOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.HueOffset{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetHueModulation(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.HueModulation>()?.Val?.Value;
  }
  
  private static bool CmpHueModulation(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.HueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.HueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueModulation(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.HueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.HueModulation{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetSaturation(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Saturation>()?.Val?.Value;
  }
  
  private static bool CmpSaturation(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Saturation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Saturation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturation(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Saturation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Saturation{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationOffset(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.SaturationOffset>()?.Val?.Value;
  }
  
  private static bool CmpSaturationOffset(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.SaturationOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.SaturationOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationOffset(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SaturationOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.SaturationOffset{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationModulation(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.SaturationModulation>()?.Val?.Value;
  }
  
  private static bool CmpSaturationModulation(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.SaturationModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.SaturationModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationModulation(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SaturationModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.SaturationModulation{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetLuminance(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Luminance>()?.Val?.Value;
  }
  
  private static bool CmpLuminance(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Luminance>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Luminance", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminance(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Luminance>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Luminance{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceOffset(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.LuminanceOffset>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceOffset(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.LuminanceOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.LuminanceOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceOffset(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LuminanceOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.LuminanceOffset{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceModulation(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.LuminanceModulation>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceModulation(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.LuminanceModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.LuminanceModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceModulation(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LuminanceModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.LuminanceModulation{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetRed(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Red>()?.Val?.Value;
  }
  
  private static bool CmpRed(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Red>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Red", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRed(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Red>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Red{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetRedOffset(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.RedOffset>()?.Val?.Value;
  }
  
  private static bool CmpRedOffset(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.RedOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.RedOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRedOffset(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RedOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.RedOffset{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetRedModulation(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.RedModulation>()?.Val?.Value;
  }
  
  private static bool CmpRedModulation(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.RedModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.RedModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRedModulation(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RedModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.RedModulation{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetGreen(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Green>()?.Val?.Value;
  }
  
  private static bool CmpGreen(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Green>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Green", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreen(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Green>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Green{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetGreenOffset(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.GreenOffset>()?.Val?.Value;
  }
  
  private static bool CmpGreenOffset(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.GreenOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.GreenOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreenOffset(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GreenOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.GreenOffset{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetGreenModulation(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.GreenModulation>()?.Val?.Value;
  }
  
  private static bool CmpGreenModulation(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.GreenModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.GreenModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreenModulation(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GreenModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.GreenModulation{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetBlue(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.Blue>()?.Val?.Value;
  }
  
  private static bool CmpBlue(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.Blue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.Blue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlue(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.Blue{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetBlueOffset(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.BlueOffset>()?.Val?.Value;
  }
  
  private static bool CmpBlueOffset(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.BlueOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.BlueOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlueOffset(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlueOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.BlueOffset{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetBlueModulation(DXD.HslColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXD.BlueModulation>()?.Val?.Value;
  }
  
  private static bool CmpBlueModulation(DXD.HslColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXD.BlueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXD.BlueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlueModulation(DXD.HslColor openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BlueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXD.BlueModulation{ Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean GetGamma(DXD.HslColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.Gamma>() != null;
  }
  
  private static bool CmpGamma(DXD.HslColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.Gamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.Gamma", val, value);
    return false;
  }
  
  private static void SetGamma(DXD.HslColor openXmlElement, Boolean? value)
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
  
  private static Boolean GetInverseGamma(DXD.HslColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXD.InverseGamma>() != null;
  }
  
  private static bool CmpInverseGamma(DXD.HslColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXD.InverseGamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXD.InverseGamma", val, value);
    return false;
  }
  
  private static void SetInverseGamma(DXD.HslColor openXmlElement, Boolean? value)
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
  
  public static DMD.HslColor? CreateModelElement(DXD.HslColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.HslColor();
      value.HueValue = GetHueValue(openXmlElement);
      value.SatValue = GetSatValue(openXmlElement);
      value.LumValue = GetLumValue(openXmlElement);
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
  
  public static bool CompareModelElement(DXD.HslColor? openXmlElement, DMD.HslColor? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHueValue(openXmlElement, value.HueValue, diffs, objName))
        ok = false;
      if (!CmpSatValue(openXmlElement, value.SatValue, diffs, objName))
        ok = false;
      if (!CmpLumValue(openXmlElement, value.LumValue, diffs, objName))
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMD.HslColor? value)
    where OpenXmlElementType: DXD.HslColor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHueValue(openXmlElement, value?.HueValue);
      SetSatValue(openXmlElement, value?.SatValue);
      SetLumValue(openXmlElement, value?.LumValue);
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
