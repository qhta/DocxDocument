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
    return openXmlElement.RedPortion?.Value;
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
    return openXmlElement.GreenPortion?.Value;
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
    return openXmlElement.BluePortion?.Value;
  }
  
  private static void SetBluePortion(DXDraw.RgbColorModelPercentage openXmlElement, Int32? value)
  {
    openXmlElement.BluePortion = value;
  }
  
  private static Int32? GetTint(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Tint>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Shade>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
  
  private static Boolean? GetComplement(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Complement>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Inverse>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Gray>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Alpha>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.AlphaModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Hue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Saturation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SaturationOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SaturationModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Luminance>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LuminanceModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Red>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RedOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RedModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Green>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GreenOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GreenModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BlueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
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
  
  private static Boolean? GetGamma(DXDraw.RgbColorModelPercentage openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Gamma>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDraw.InverseGamma>();
    return itemElement != null;
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
