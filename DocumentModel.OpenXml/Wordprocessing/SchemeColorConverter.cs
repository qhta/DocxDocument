namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public static class SchemeColorConverter
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.SchemeColorKind? GetVal(DXO2010W.SchemeColor openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues, DMW.SchemeColorKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DXO2010W.SchemeColor openXmlElement, DMW.SchemeColorKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.SchemeColorValues, DMW.SchemeColorKind>(value);
  }
  
  private static Int32? GetTint(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Tint>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTint(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetShade(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Shade>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetShade(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetAlpha(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Alpha>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAlpha(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetHueModulation(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.HueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHueModulation(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturation(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Saturation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturation(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturationOffset(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SaturationOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturationOffset(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturationModulation(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SaturationModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturationModulation(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminance(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.Luminance>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminance(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminanceOffset(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.LuminanceOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminanceOffset(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminanceModulation(DXO2010W.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.LuminanceModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminanceModulation(DXO2010W.SchemeColor openXmlElement, Int32? value)
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
  
  public static DMW.SchemeColor? CreateModelElement(DXO2010W.SchemeColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SchemeColor();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SchemeColor? value)
    where OpenXmlElementType: DXO2010W.SchemeColor, new()
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
