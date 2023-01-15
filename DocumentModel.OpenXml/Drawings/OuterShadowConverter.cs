using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using HslColor = DocumentModel.Drawings.HslColor;
using OuterShadow = DocumentFormat.OpenXml.Drawing.OuterShadow;
using PresetColor = DocumentModel.Drawings.PresetColor;
using RgbColorModelHex = DocumentModel.Drawings.RgbColorModelHex;
using RgbColorModelPercentage = DocumentModel.Drawings.RgbColorModelPercentage;
using SchemeColor = DocumentModel.Drawings.SchemeColor;
using SystemColor = DocumentModel.Drawings.SystemColor;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Outer Shadow Effect.
/// </summary>
public static class OuterShadowConverter
{
  /// <summary>
  ///   Blur Radius
  /// </summary>
  public static Int64? GetBlurRadius(OuterShadow? openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }

  public static void SetBlurRadius(OuterShadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlurRadius = value;
  }

  /// <summary>
  ///   Shadow Offset Distance
  /// </summary>
  public static Int64? GetDistance(OuterShadow? openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }

  public static void SetDistance(OuterShadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Distance = value;
  }

  /// <summary>
  ///   Shadow Direction
  /// </summary>
  public static Int32? GetDirection(OuterShadow? openXmlElement)
  {
    return openXmlElement?.Direction?.Value;
  }

  public static void SetDirection(OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Direction = value;
  }

  /// <summary>
  ///   Horizontal Scaling Factor
  /// </summary>
  public static Int32? GetHorizontalRatio(OuterShadow? openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }

  public static void SetHorizontalRatio(OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalRatio = value;
  }

  /// <summary>
  ///   Vertical Scaling Factor
  /// </summary>
  public static Int32? GetVerticalRatio(OuterShadow? openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }

  public static void SetVerticalRatio(OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalRatio = value;
  }

  /// <summary>
  ///   Horizontal Skew
  /// </summary>
  public static Int32? GetHorizontalSkew(OuterShadow? openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }

  public static void SetHorizontalSkew(OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkew = value;
  }

  /// <summary>
  ///   Vertical Skew
  /// </summary>
  public static Int32? GetVerticalSkew(OuterShadow? openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }

  public static void SetVerticalSkew(OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkew = value;
  }

  /// <summary>
  ///   Shadow Alignment
  /// </summary>
  public static RectangleAlignmentKind? GetAlignment(OuterShadow? openXmlElement)
  {
    return EnumValueConverter.GetValue<RectangleAlignmentValues, RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(OuterShadow? openXmlElement, RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<RectangleAlignmentValues, RectangleAlignmentKind>(value);
  }

  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(OuterShadow? openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }

  public static void SetRotateWithShape(OuterShadow? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RotateWithShape = null;
  }

  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  public static RgbColorModelPercentage? GetRgbColorModelPercentage(OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
    if (itemElement != null)
      return RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelPercentage(OuterShadow? openXmlElement, RgbColorModelPercentage? value)
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
  public static RgbColorModelHex? GetRgbColorModelHex(OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
    if (itemElement != null)
      return RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelHex(OuterShadow? openXmlElement, RgbColorModelHex? value)
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
  public static HslColor? GetHslColor(OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
    if (itemElement != null)
      return HslColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHslColor(OuterShadow? openXmlElement, HslColor? value)
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
  public static SystemColor? GetSystemColor(OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
    if (itemElement != null)
      return SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSystemColor(OuterShadow? openXmlElement, SystemColor? value)
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
  public static SchemeColor? GetSchemeColor(OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
    if (itemElement != null)
      return SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSchemeColor(OuterShadow? openXmlElement, SchemeColor? value)
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
  public static PresetColor? GetPresetColor(OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
    if (itemElement != null)
      return PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetColor(OuterShadow? openXmlElement, PresetColor? value)
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

  public static DocumentModel.Drawings.OuterShadow? CreateModelElement(OuterShadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OuterShadow();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.OuterShadow? value)
    where OpenXmlElementType : OuterShadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetDistance(openXmlElement, value?.Distance);
      SetDirection(openXmlElement, value?.Direction);
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
      SetVerticalSkew(openXmlElement, value?.VerticalSkew);
      SetAlignment(openXmlElement, value?.Alignment);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
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