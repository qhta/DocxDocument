using DocumentFormat.OpenXml.Office2010.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the RgbColorModelHex Class.
/// </summary>
public static class RgbColorModelHexConverter
{
  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
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

  public static DocumentModel.Wordprocessing.RgbColorModelHex? CreateModelElement(RgbColorModelHex? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RgbColorModelHex? value)
    where OpenXmlElementType : RgbColorModelHex, new()
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