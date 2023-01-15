using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using SchemeColor = DocumentFormat.OpenXml.Office2010.Word.SchemeColor;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SchemeColor Class.
/// </summary>
public static class SchemeColorConverter
{
  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  public static SchemeColorKind? GetVal(SchemeColor? openXmlElement)
  {
    return EnumValueConverter.GetValue<SchemeColorValues, SchemeColorKind>(openXmlElement?.Val?.Value);
  }

  public static void SetVal(SchemeColor? openXmlElement, SchemeColorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = EnumValueConverter.CreateEnumValue<SchemeColorValues, SchemeColorKind>(value);
  }

  public static Int32? GetTint(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Tint>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTint(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetShade(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Shade>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetShade(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetAlpha(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Alpha>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAlpha(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetHueModulation(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HueModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHueModulation(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetSaturation(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Saturation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturation(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetSaturationOffset(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SaturationOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturationOffset(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetSaturationModulation(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SaturationModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSaturationModulation(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetLuminance(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Luminance>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminance(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetLuminanceOffset(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LuminanceOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminanceOffset(SchemeColor? openXmlElement, Int32? value)
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

  public static Int32? GetLuminanceModulation(SchemeColor? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LuminanceModulation>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLuminanceModulation(SchemeColor? openXmlElement, Int32? value)
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

  public static DocumentModel.Wordprocessing.SchemeColor? CreateModelElement(SchemeColor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SchemeColor();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SchemeColor? value)
    where OpenXmlElementType : SchemeColor, new()
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