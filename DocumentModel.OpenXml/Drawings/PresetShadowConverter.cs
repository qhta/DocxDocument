using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using HslColor = DocumentModel.Drawings.HslColor;
using PresetColor = DocumentModel.Drawings.PresetColor;
using PresetShadow = DocumentFormat.OpenXml.Drawing.PresetShadow;
using RgbColorModelHex = DocumentModel.Drawings.RgbColorModelHex;
using RgbColorModelPercentage = DocumentModel.Drawings.RgbColorModelPercentage;
using SchemeColor = DocumentModel.Drawings.SchemeColor;
using SystemColor = DocumentModel.Drawings.SystemColor;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Preset Shadow.
/// </summary>
public static class PresetShadowConverter
{
  /// <summary>
  ///   Preset Shadow
  /// </summary>
  public static PresetShadowKind? GetPreset(PresetShadow? openXmlElement)
  {
    return EnumValueConverter.GetValue<PresetShadowValues, PresetShadowKind>(openXmlElement?.Preset?.Value);
  }

  public static void SetPreset(PresetShadow? openXmlElement, PresetShadowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<PresetShadowValues, PresetShadowKind>(value);
  }

  /// <summary>
  ///   Distance
  /// </summary>
  public static Int64? GetDistance(PresetShadow? openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }

  public static void SetDistance(PresetShadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Distance = value;
  }

  /// <summary>
  ///   Direction
  /// </summary>
  public static Int32? GetDirection(PresetShadow? openXmlElement)
  {
    return openXmlElement?.Direction?.Value;
  }

  public static void SetDirection(PresetShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Direction = value;
  }

  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  public static RgbColorModelPercentage? GetRgbColorModelPercentage(PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
    if (itemElement != null)
      return RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelPercentage(PresetShadow? openXmlElement, RgbColorModelPercentage? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RgbColorModelPercentageConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  public static RgbColorModelHex? GetRgbColorModelHex(PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
    if (itemElement != null)
      return RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelHex(PresetShadow? openXmlElement, RgbColorModelHex? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  public static HslColor? GetHslColor(PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
    if (itemElement != null)
      return HslColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHslColor(PresetShadow? openXmlElement, HslColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HslColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HslColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   System Color.
  /// </summary>
  public static SystemColor? GetSystemColor(PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
    if (itemElement != null)
      return SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSystemColor(PresetShadow? openXmlElement, SystemColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SystemColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SystemColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Scheme Color.
  /// </summary>
  public static SchemeColor? GetSchemeColor(PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
    if (itemElement != null)
      return SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSchemeColor(PresetShadow? openXmlElement, SchemeColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SchemeColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SchemeColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Preset Color.
  /// </summary>
  public static PresetColor? GetPresetColor(PresetShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
    if (itemElement != null)
      return PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetColor(PresetShadow? openXmlElement, PresetColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.PresetShadow? CreateModelElement(PresetShadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PresetShadow();
      value.Preset = GetPreset(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PresetShadow? value)
    where OpenXmlElementType : PresetShadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetDistance(openXmlElement, value?.Distance);
      SetDirection(openXmlElement, value?.Direction);
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      return openXmlElement;
    }
    return default;
  }
}