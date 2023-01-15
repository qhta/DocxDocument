using DocumentFormat.OpenXml.Drawing;
using HslColor = DocumentModel.Drawings.HslColor;
using PresetColor = DocumentModel.Drawings.PresetColor;
using RgbColorModelHex = DocumentModel.Drawings.RgbColorModelHex;
using RgbColorModelPercentage = DocumentModel.Drawings.RgbColorModelPercentage;
using SchemeColor = DocumentModel.Drawings.SchemeColor;
using SystemColor = DocumentModel.Drawings.SystemColor;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Glow Effect.
/// </summary>
public static class GlowConverter
{
  /// <summary>
  ///   Radius
  /// </summary>
  public static Int64? GetRadius(Glow? openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }

  public static void SetRadius(Glow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Radius = value;
  }

  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  public static RgbColorModelPercentage? GetRgbColorModelPercentage(Glow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
    if (itemElement != null)
      return RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelPercentage(Glow? openXmlElement, RgbColorModelPercentage? value)
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
  public static RgbColorModelHex? GetRgbColorModelHex(Glow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
    if (itemElement != null)
      return RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelHex(Glow? openXmlElement, RgbColorModelHex? value)
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
  public static HslColor? GetHslColor(Glow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
    if (itemElement != null)
      return HslColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHslColor(Glow? openXmlElement, HslColor? value)
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
  public static SystemColor? GetSystemColor(Glow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
    if (itemElement != null)
      return SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSystemColor(Glow? openXmlElement, SystemColor? value)
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
  public static SchemeColor? GetSchemeColor(Glow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
    if (itemElement != null)
      return SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSchemeColor(Glow? openXmlElement, SchemeColor? value)
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
  public static PresetColor? GetPresetColor(Glow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
    if (itemElement != null)
      return PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetColor(Glow? openXmlElement, PresetColor? value)
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

  public static DocumentModel.Drawings.Glow? CreateModelElement(Glow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Glow();
      value.Radius = GetRadius(openXmlElement);
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Glow? value)
    where OpenXmlElementType : Glow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadius(openXmlElement, value?.Radius);
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