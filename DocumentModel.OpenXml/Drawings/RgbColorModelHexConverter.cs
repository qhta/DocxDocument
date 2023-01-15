using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   RGB Color Model - Hex Variant.
/// </summary>
public static class RgbColorModelHexConverter
{
  /// <summary>
  ///   Value
  /// </summary>
  public static Byte[]? GetVal(RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return Convert.FromHexString(openXmlElement.Val.Value);
    return null;
  }

  public static void SetVal(RgbColorModelHex? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Val = Convert.ToHexString(value);
      else
        openXmlElement.Val = null;
    }
  }

  /// <summary>
  ///   legacySpreadsheetColorIndex, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetLegacySpreadsheetColorIndex(RgbColorModelHex? openXmlElement)
  {
    return openXmlElement?.LegacySpreadsheetColorIndex?.Value;
  }

  public static void SetLegacySpreadsheetColorIndex(RgbColorModelHex? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LegacySpreadsheetColorIndex = value;
  }

  public static Int32? GetTint(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Tint>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTint(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetShade(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Shade>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetShade(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Boolean? GetComplement(RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Complement>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetComplement(RgbColorModelHex? openXmlElement, Boolean? value)
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

  public static Boolean? GetInverse(RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Inverse>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInverse(RgbColorModelHex? openXmlElement, Boolean? value)
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

  public static Boolean? GetGray(RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Gray>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGray(RgbColorModelHex? openXmlElement, Boolean? value)
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

  public static Int32? GetAlpha(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Alpha>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlpha(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetAlphaOffset(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AlphaOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlphaOffset(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetAlphaModulation(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AlphaModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlphaModulation(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetHue(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Hue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHue(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetHueOffset(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHueOffset(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetHueModulation(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHueModulation(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetSaturation(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Saturation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturation(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetSaturationOffset(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SaturationOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturationOffset(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetSaturationModulation(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SaturationModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturationModulation(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetLuminance(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Luminance>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminance(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetLuminanceOffset(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LuminanceOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminanceOffset(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetLuminanceModulation(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LuminanceModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminanceModulation(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetRed(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Red>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRed(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetRedOffset(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RedOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRedOffset(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetRedModulation(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RedModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRedModulation(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetGreen(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Green>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreen(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetGreenOffset(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GreenOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreenOffset(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetGreenModulation(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GreenModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreenModulation(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetBlue(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Blue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlue(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetBlueOffset(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BlueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlueOffset(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Int32? GetBlueModulation(RgbColorModelHex? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BlueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlueModulation(RgbColorModelHex? openXmlElement, Int32? value)
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

  public static Boolean? GetGamma(RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Gamma>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGamma(RgbColorModelHex? openXmlElement, Boolean? value)
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

  public static Boolean? GetInverseGamma(RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InverseGamma>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInverseGamma(RgbColorModelHex? openXmlElement, Boolean? value)
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

  public static DocumentModel.Drawings.RgbColorModelHex? CreateModelElement(RgbColorModelHex? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.RgbColorModelHex();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.RgbColorModelHex? value)
    where OpenXmlElementType : RgbColorModelHex, new()
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