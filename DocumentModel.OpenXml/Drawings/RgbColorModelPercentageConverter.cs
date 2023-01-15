using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   RGB Color Model - Percentage Variant.
/// </summary>
public static class RgbColorModelPercentageConverter
{
  /// <summary>
  ///   Red
  /// </summary>
  public static Int32? GetRedPortion(RgbColorModelPercentage? openXmlElement)
  {
    return openXmlElement?.RedPortion?.Value;
  }

  public static void SetRedPortion(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.RedPortion = value;
  }

  /// <summary>
  ///   Green
  /// </summary>
  public static Int32? GetGreenPortion(RgbColorModelPercentage? openXmlElement)
  {
    return openXmlElement?.GreenPortion?.Value;
  }

  public static void SetGreenPortion(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.GreenPortion = value;
  }

  /// <summary>
  ///   Blue
  /// </summary>
  public static Int32? GetBluePortion(RgbColorModelPercentage? openXmlElement)
  {
    return openXmlElement?.BluePortion?.Value;
  }

  public static void SetBluePortion(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.BluePortion = value;
  }

  public static Int32? GetTint(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Tint>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTint(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Tint>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Tint { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetShade(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Shade>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetShade(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Shade>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Shade { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetComplement(RgbColorModelPercentage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Complement>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetComplement(RgbColorModelPercentage? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Complement>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Complement();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetInverse(RgbColorModelPercentage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Inverse>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInverse(RgbColorModelPercentage? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Inverse>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Inverse();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetGray(RgbColorModelPercentage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Gray>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGray(RgbColorModelPercentage? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Gray>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Gray();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetAlpha(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Alpha>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlpha(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Alpha>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Alpha { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetAlphaOffset(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AlphaOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlphaOffset(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlphaOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new AlphaOffset { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetAlphaModulation(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AlphaModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlphaModulation(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlphaModulation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new AlphaModulation { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetHue(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Hue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHue(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Hue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Hue { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetHueOffset(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHueOffset(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HueOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new HueOffset { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetHueModulation(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHueModulation(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HueModulation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new HueModulation { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetSaturation(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Saturation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturation(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Saturation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Saturation { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetSaturationOffset(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SaturationOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturationOffset(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SaturationOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SaturationOffset { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetSaturationModulation(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SaturationModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturationModulation(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SaturationModulation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SaturationModulation { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetLuminance(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Luminance>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminance(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Luminance>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Luminance { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetLuminanceOffset(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LuminanceOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminanceOffset(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LuminanceOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LuminanceOffset { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetLuminanceModulation(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LuminanceModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminanceModulation(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LuminanceModulation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LuminanceModulation { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetRed(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Red>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRed(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Red>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Red { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetRedOffset(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RedOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRedOffset(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RedOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RedOffset { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetRedModulation(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RedModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRedModulation(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RedModulation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RedModulation { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetGreen(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Green>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreen(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Green>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Green { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetGreenOffset(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GreenOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreenOffset(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GreenOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new GreenOffset { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetGreenModulation(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GreenModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreenModulation(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GreenModulation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new GreenModulation { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetBlue(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Blue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlue(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Blue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Blue { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetBlueOffset(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BlueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlueOffset(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BlueOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BlueOffset { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetBlueModulation(RgbColorModelPercentage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BlueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlueModulation(RgbColorModelPercentage? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BlueModulation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BlueModulation { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetGamma(RgbColorModelPercentage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Gamma>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGamma(RgbColorModelPercentage? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Gamma>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Gamma();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetInverseGamma(RgbColorModelPercentage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InverseGamma>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInverseGamma(RgbColorModelPercentage? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<InverseGamma>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new InverseGamma();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.RgbColorModelPercentage? CreateModelElement(RgbColorModelPercentage? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.RgbColorModelPercentage? value)
    where OpenXmlElementType : RgbColorModelPercentage, new()
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