namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Scheme Color.
/// </summary>
public static class SchemeColorConverter
{
  /// <summary>
  /// Value
  /// </summary>
  private static DMDraws.SchemeColorKind? GetVal(DXDraw.SchemeColor openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.SchemeColorValues, DMDraws.SchemeColorKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DXDraw.SchemeColor openXmlElement, DMDraws.SchemeColorKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.SchemeColorValues, DMDraws.SchemeColorKind>(value);
  }
  
  private static Int32? GetTint(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Tint>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTint(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetShade(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Shade>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetShade(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Boolean? GetComplement(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Complement>();
    return itemElement != null;
  }
  
  private static void SetComplement(DXDraw.SchemeColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverse(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Inverse>();
    return itemElement != null;
  }
  
  private static void SetInverse(DXDraw.SchemeColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetGray(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Gray>();
    return itemElement != null;
  }
  
  private static void SetGray(DXDraw.SchemeColor openXmlElement, Boolean? value)
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
  
  private static Int32? GetAlpha(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Alpha>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAlpha(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetAlphaOffset(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAlphaOffset(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetAlphaModulation(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAlphaModulation(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetHue(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Hue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHue(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetHueOffset(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHueOffset(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetHueModulation(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHueModulation(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturation(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Saturation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturation(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturationOffset(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturationOffset(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetSaturationModulation(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSaturationModulation(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminance(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Luminance>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminance(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminanceOffset(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminanceOffset(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetLuminanceModulation(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLuminanceModulation(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetRed(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Red>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRed(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetRedOffset(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RedOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRedOffset(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetRedModulation(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RedModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRedModulation(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetGreen(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Green>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGreen(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetGreenOffset(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GreenOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGreenOffset(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetGreenModulation(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GreenModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGreenModulation(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetBlue(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBlue(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetBlueOffset(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBlueOffset(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Int32? GetBlueModulation(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBlueModulation(DXDraw.SchemeColor openXmlElement, Int32? value)
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
  
  private static Boolean? GetGamma(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Gamma>();
    return itemElement != null;
  }
  
  private static void SetGamma(DXDraw.SchemeColor openXmlElement, Boolean? value)
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
  
  private static Boolean? GetInverseGamma(DXDraw.SchemeColor openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.InverseGamma>();
    return itemElement != null;
  }
  
  private static void SetInverseGamma(DXDraw.SchemeColor openXmlElement, Boolean? value)
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
  
  public static DMDraws.SchemeColor? CreateModelElement(DXDraw.SchemeColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.SchemeColor();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SchemeColor? value)
    where OpenXmlElementType: DXDraw.SchemeColor, new()
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
