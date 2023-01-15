using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using Boolean = System.Boolean;

namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
///   Defines the StyleColor Class.
/// </summary>
public static class StyleColorConverter
{
  /// <summary>
  ///   val, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetVal(StyleColor? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(StyleColor? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static Int32? GetTint(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Tint>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTint(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetShade(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Shade>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetShade(StyleColor? openXmlElement, Int32? value)
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

  public static Boolean? GetComplement(StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Complement>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetComplement(StyleColor? openXmlElement, Boolean? value)
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

  public static Boolean? GetInverse(StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Inverse>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInverse(StyleColor? openXmlElement, Boolean? value)
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

  public static Boolean? GetGray(StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Gray>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGray(StyleColor? openXmlElement, Boolean? value)
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

  public static Int32? GetAlpha(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Alpha>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlpha(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetAlphaOffset(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AlphaOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlphaOffset(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetAlphaModulation(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AlphaModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlphaModulation(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetHue(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Hue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHue(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetHueOffset(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHueOffset(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetHueModulation(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHueModulation(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetSaturation(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Saturation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturation(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetSaturationOffset(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SaturationOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturationOffset(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetSaturationModulation(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SaturationModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturationModulation(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetLuminance(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Luminance>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminance(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetLuminanceOffset(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LuminanceOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminanceOffset(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetLuminanceModulation(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LuminanceModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminanceModulation(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetRed(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Red>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRed(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetRedOffset(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RedOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRedOffset(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetRedModulation(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RedModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRedModulation(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetGreen(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Green>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreen(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetGreenOffset(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GreenOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreenOffset(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetGreenModulation(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GreenModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGreenModulation(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetBlue(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Blue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlue(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetBlueOffset(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BlueOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlueOffset(StyleColor? openXmlElement, Int32? value)
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

  public static Int32? GetBlueModulation(StyleColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BlueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBlueModulation(StyleColor? openXmlElement, Int32? value)
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

  public static Boolean? GetGamma(StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Gamma>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGamma(StyleColor? openXmlElement, Boolean? value)
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

  public static Boolean? GetInverseGamma(StyleColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<InverseGamma>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetInverseGamma(StyleColor? openXmlElement, Boolean? value)
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

  public static DocumentModel.Drawings.ChartsStyle.StyleColor? CreateModelElement(StyleColor? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.StyleColor? value)
    where OpenXmlElementType : StyleColor, new()
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