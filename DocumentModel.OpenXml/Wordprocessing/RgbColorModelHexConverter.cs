namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RgbColorModelHex Class.
/// </summary>
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
    diffs?.Add(objName, "Val", openXmlElement?.Val?.Value, value?.ToString());
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
    return openXmlElement?.GetFirstChild<DXO2010W.Tint>()?.Val?.Value;
  }
  
  private static bool CmpTint(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Tint>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.Tint", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetTint(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Tint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.Tint{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetShade(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.Shade>()?.Val?.Value;
  }
  
  private static bool CmpShade(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Shade>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.Shade", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetShade(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Shade>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.Shade{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetAlpha(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.Alpha>()?.Val?.Value;
  }
  
  private static bool CmpAlpha(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Alpha>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.Alpha", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetAlpha(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Alpha>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.Alpha{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetHueModulation(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.HueModulation>()?.Val?.Value;
  }
  
  private static bool CmpHueModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.HueModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.HueModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetHueModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.HueModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.HueModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturation(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.Saturation>()?.Val?.Value;
  }
  
  private static bool CmpSaturation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Saturation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.Saturation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Saturation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.Saturation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationOffset(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.SaturationOffset>()?.Val?.Value;
  }
  
  private static bool CmpSaturationOffset(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SaturationOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.SaturationOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationOffset(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.SaturationOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.SaturationOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSaturationModulation(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.SaturationModulation>()?.Val?.Value;
  }
  
  private static bool CmpSaturationModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SaturationModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.SaturationModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetSaturationModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.SaturationModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.SaturationModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminance(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.Luminance>()?.Val?.Value;
  }
  
  private static bool CmpLuminance(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Luminance>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.Luminance", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminance(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Luminance>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.Luminance{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceOffset(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.LuminanceOffset>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceOffset(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.LuminanceOffset>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.LuminanceOffset", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceOffset(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.LuminanceOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.LuminanceOffset{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetLuminanceModulation(DXO2010W.RgbColorModelHex openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXO2010W.LuminanceModulation>()?.Val?.Value;
  }
  
  private static bool CmpLuminanceModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.LuminanceModulation>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXO2010W.LuminanceModulation", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetLuminanceModulation(DXO2010W.RgbColorModelHex openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.LuminanceModulation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010W.LuminanceModulation{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.RgbColorModelHex? CreateModelElement(DXO2010W.RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RgbColorModelHex();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RgbColorModelHex? value)
    where OpenXmlElementType: DXO2010W.RgbColorModelHex, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
