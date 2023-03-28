namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// RGB Color Model - Percentage Variant converter from/to OpenXml.
///</summary>
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
    return openXmlElement?.GetFirstChild<DXDraw.Tint>()?.Val?.Value;
  }
  
  private static bool CmpTint(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Tint>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Tint", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTint(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetShade(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Shade>()?.Val?.Value;
  }
  
  private static bool CmpShade(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Shade>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Shade", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetShade(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Boolean GetComplement(DXDraw.RgbColorModelPercentage openXmlElement)
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
  
  private static Boolean GetInverse(DXDraw.RgbColorModelPercentage openXmlElement)
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
  
  private static Boolean GetGray(DXDraw.RgbColorModelPercentage openXmlElement)
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
    return openXmlElement?.GetFirstChild<DXDraw.Alpha>()?.Val?.Value;
  }
  
  private static bool CmpAlpha(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Alpha>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Alpha", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlpha(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetAlphaOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>()?.Val?.Value;
  }
  
  private static bool CmpAlphaOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.AlphaOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlphaOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetAlphaModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>()?.Val?.Value;
  }
  
  private static bool CmpAlphaModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.AlphaModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlphaModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetHue(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Hue>()?.Val?.Value;
  }
  
  private static bool CmpHue(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Hue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Hue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHue(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetHueOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.HueOffset>()?.Val?.Value;
  }
  
  private static bool CmpHueOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HueOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.HueOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetHueModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.HueModulation>()?.Val?.Value;
  }
  
  private static bool CmpHueModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.HueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Saturation>()?.Val?.Value;
  }
  
  private static bool CmpSaturation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Saturation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Saturation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturationOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>()?.Val?.Value;
  }
  
  private static bool CmpSaturationOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.SaturationOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturationModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>()?.Val?.Value;
  }
  
  private static bool CmpSaturationModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.SaturationModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminance(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Luminance>()?.Val?.Value;
  }
  
  private static bool CmpLuminance(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Luminance>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Luminance", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminance(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminanceOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.LuminanceOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminanceModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.LuminanceModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetRed(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Red>()?.Val?.Value;
  }
  
  private static bool CmpRed(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Red>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Red", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRed(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetRedOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.RedOffset>()?.Val?.Value;
  }
  
  private static bool CmpRedOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RedOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.RedOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRedOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetRedModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.RedModulation>()?.Val?.Value;
  }
  
  private static bool CmpRedModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RedModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.RedModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRedModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetGreen(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Green>()?.Val?.Value;
  }
  
  private static bool CmpGreen(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Green>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Green", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreen(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetGreenOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.GreenOffset>()?.Val?.Value;
  }
  
  private static bool CmpGreenOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GreenOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.GreenOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreenOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetGreenModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.GreenModulation>()?.Val?.Value;
  }
  
  private static bool CmpGreenModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GreenModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.GreenModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreenModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetBlue(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Blue>()?.Val?.Value;
  }
  
  private static bool CmpBlue(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Blue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlue(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetBlueOffset(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BlueOffset>()?.Val?.Value;
  }
  
  private static bool CmpBlueOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlueOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.BlueOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlueOffset(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Int32? GetBlueModulation(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BlueModulation>()?.Val?.Value;
  }
  
  private static bool CmpBlueModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.BlueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlueModulation(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
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
  
  private static Boolean GetGamma(DXDraw.RgbColorModelPercentage openXmlElement)
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
  
  private static Boolean GetInverseGamma(DXDraw.RgbColorModelPercentage openXmlElement)
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
  
  public static DMDraws.RgbColorModelPercentage? CreateModelElement(DXDraw.RgbColorModelPercentage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.RgbColorModelPercentage();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.RgbColorModelPercentage? value)
    where OpenXmlElementType: DXDraw.RgbColorModelPercentage, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
