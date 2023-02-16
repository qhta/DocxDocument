namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleColor Class.
/// </summary>
public static class StyleColorConverter
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetVal(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXO2013DrawChartStyle.StyleColor openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Val", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXO2013DrawChartStyle.StyleColor openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  private static Int32? GetTint(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Tint>()?.Val?.Value;
  }
  
  private static bool CmpTint(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Tint>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Tint", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTint(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetShade(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Shade>()?.Val?.Value;
  }
  
  private static bool CmpShade(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Shade>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Shade", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetShade(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Boolean? GetComplement(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Complement>() != null;
  }
  
  private static bool CmpComplement(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Complement>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Complement", val, value);
    return false;
  }
  
  private static void SetComplement(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverse(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Inverse>() != null;
  }
  
  private static bool CmpInverse(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Inverse>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Inverse", val, value);
    return false;
  }
  
  private static void SetInverse(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetGray(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gray>() != null;
  }
  
  private static bool CmpGray(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Gray>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Gray", val, value);
    return false;
  }
  
  private static void SetGray(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value)
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
  
  private static Int32? GetAlpha(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Alpha>()?.Val?.Value;
  }
  
  private static bool CmpAlpha(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Alpha>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Alpha", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlpha(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetAlphaOffset(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>()?.Val?.Value;
  }
  
  private static bool CmpAlphaOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.AlphaOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlphaOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetAlphaModulation(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>()?.Val?.Value;
  }
  
  private static bool CmpAlphaModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.AlphaModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlphaModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetHue(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Hue>()?.Val?.Value;
  }
  
  private static bool CmpHue(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Hue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Hue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHue(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetHueOffset(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.HueOffset>()?.Val?.Value;
  }
  
  private static bool CmpHueOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HueOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.HueOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetHueModulation(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.HueModulation>()?.Val?.Value;
  }
  
  private static bool CmpHueModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.HueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturation(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Saturation>()?.Val?.Value;
  }
  
  private static bool CmpSaturation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Saturation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Saturation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturationOffset(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>()?.Val?.Value;
  }
  
  private static bool CmpSaturationOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.SaturationOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturationModulation(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>()?.Val?.Value;
  }
  
  private static bool CmpSaturationModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.SaturationModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminance(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Luminance>()?.Val?.Value;
  }
  
  private static bool CmpLuminance(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Luminance>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Luminance", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminance(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminanceOffset(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.LuminanceOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminanceModulation(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.LuminanceModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetRed(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Red>()?.Val?.Value;
  }
  
  private static bool CmpRed(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Red>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Red", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRed(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetRedOffset(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.RedOffset>()?.Val?.Value;
  }
  
  private static bool CmpRedOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RedOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.RedOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRedOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetRedModulation(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.RedModulation>()?.Val?.Value;
  }
  
  private static bool CmpRedModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RedModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.RedModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetRedModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetGreen(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Green>()?.Val?.Value;
  }
  
  private static bool CmpGreen(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Green>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Green", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreen(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetGreenOffset(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.GreenOffset>()?.Val?.Value;
  }
  
  private static bool CmpGreenOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GreenOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.GreenOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreenOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetGreenModulation(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.GreenModulation>()?.Val?.Value;
  }
  
  private static bool CmpGreenModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GreenModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.GreenModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetGreenModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetBlue(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.Blue>()?.Val?.Value;
  }
  
  private static bool CmpBlue(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blue>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.Blue", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlue(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetBlueOffset(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BlueOffset>()?.Val?.Value;
  }
  
  private static bool CmpBlueOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlueOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.BlueOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlueOffset(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Int32? GetBlueModulation(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDraw.BlueModulation>()?.Val?.Value;
  }
  
  private static bool CmpBlueModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDraw.BlueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetBlueModulation(DXO2013DrawChartStyle.StyleColor openXmlElement, Int32? value)
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
  
  private static Boolean? GetGamma(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.Gamma>() != null;
  }
  
  private static bool CmpGamma(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.Gamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.Gamma", val, value);
    return false;
  }
  
  private static void SetGamma(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverseGamma(DXO2013DrawChartStyle.StyleColor openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDraw.InverseGamma>() != null;
  }
  
  private static bool CmpInverseGamma(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDraw.InverseGamma>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDraw.InverseGamma", val, value);
    return false;
  }
  
  private static void SetInverseGamma(DXO2013DrawChartStyle.StyleColor openXmlElement, Boolean? value)
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
  
  public static DocumentModel.Drawings.ChartsStyle.StyleColor? CreateModelElement(DXO2013DrawChartStyle.StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.StyleColor();
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
  
  public static bool CompareModelElement(DXO2013DrawChartStyle.StyleColor? openXmlElement, DMDrawsChartsStyle.StyleColor? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.StyleColor? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.StyleColor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
