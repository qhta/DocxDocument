using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using StrokeChildType = DocumentFormat.OpenXml.Vml.Office.StrokeChildType;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the StrokeChildType Class.
/// </summary>
public static class StrokeChildTypeConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(StrokeChildType? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  public static Boolean? GetOn(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }

  public static void SetOn(StrokeChildType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.On = value;
      else
        openXmlElement.On = null;
  }

  /// <summary>
  ///   Stroke Weight
  /// </summary>
  public static String? GetWeight(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Weight?.Value;
  }

  public static void SetWeight(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Weight = new StringValue { Value = value };
      else
        openXmlElement.Weight = null;
  }

  /// <summary>
  ///   Stroke Color
  /// </summary>
  public static String? GetColor(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }

  public static void SetColor(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }

  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  public static String? GetColor2(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }

  public static void SetColor2(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color2 = new StringValue { Value = value };
      else
        openXmlElement.Color2 = null;
  }

  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  public static String? GetOpacity(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }

  public static void SetOpacity(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Opacity = new StringValue { Value = value };
      else
        openXmlElement.Opacity = null;
  }

  /// <summary>
  ///   Stroke Line Style
  /// </summary>
  public static StrokeLineStyleKind? GetLineStyle(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeLineStyleValues, StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }

  public static void SetLineStyle(StrokeChildType? openXmlElement, StrokeLineStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<StrokeLineStyleValues, StrokeLineStyleKind>(value);
  }

  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  public static Decimal? GetMiterLimit(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.MiterLimit?.Value;
  }

  public static void SetMiterLimit(StrokeChildType? openXmlElement, Decimal? value)
  {
    if (openXmlElement != null)
      openXmlElement.MiterLimit = value;
  }

  /// <summary>
  ///   Line End Join Style)
  /// </summary>
  public static StrokeJoinStyleKind? GetJoinStyle(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeJoinStyleValues, StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }

  public static void SetJoinStyle(StrokeChildType? openXmlElement, StrokeJoinStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<StrokeJoinStyleValues, StrokeJoinStyleKind>(value);
  }

  /// <summary>
  ///   Line End Cap
  /// </summary>
  public static StrokeEndCapKind? GetEndCap(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeEndCapValues, StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }

  public static void SetEndCap(StrokeChildType? openXmlElement, StrokeEndCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<StrokeEndCapValues, StrokeEndCapKind>(value);
  }

  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  public static String? GetDashStyle(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.DashStyle?.Value;
  }

  public static void SetDashStyle(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DashStyle = new StringValue { Value = value };
      else
        openXmlElement.DashStyle = null;
  }

  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  public static Boolean? GetInsetPen(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }

  public static void SetInsetPen(StrokeChildType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsetPen = value;
      else
        openXmlElement.InsetPen = null;
  }

  /// <summary>
  ///   Stroke Image Style
  /// </summary>
  public static FillKind? GetFillType(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<FillTypeValues, FillKind>(openXmlElement?.FillType?.Value);
  }

  public static void SetFillType(StrokeChildType? openXmlElement, FillKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FillType = EnumValueConverter.CreateEnumValue<FillTypeValues, FillKind>(value);
  }

  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  public static String? GetSource(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }

  public static void SetSource(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Source = new StringValue { Value = value };
      else
        openXmlElement.Source = null;
  }

  /// <summary>
  ///   Stroke Image Aspect Ratio
  /// </summary>
  public static ImageAspectKind? GetImageAspect(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<ImageAspectValues, ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }

  public static void SetImageAspect(StrokeChildType? openXmlElement, ImageAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<ImageAspectValues, ImageAspectKind>(value);
  }

  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  public static String? GetImageSize(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.ImageSize?.Value;
  }

  public static void SetImageSize(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageSize = new StringValue { Value = value };
      else
        openXmlElement.ImageSize = null;
  }

  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  public static Boolean? GetImageAlignShape(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.ImageAlignShape?.Value;
  }

  public static void SetImageAlignShape(StrokeChildType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageAlignShape = value;
      else
        openXmlElement.ImageAlignShape = null;
  }

  /// <summary>
  ///   Line Start Arrowhead
  /// </summary>
  public static StrokeArrowKind? GetStartArrow(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowValues, StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }

  public static void SetStartArrow(StrokeChildType? openXmlElement, StrokeArrowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<StrokeArrowValues, StrokeArrowKind>(value);
  }

  /// <summary>
  ///   Line Start Arrowhead Width
  /// </summary>
  public static StrokeArrowWidthKind? GetStartArrowWidth(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowWidthValues, StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }

  public static void SetStartArrowWidth(StrokeChildType? openXmlElement, StrokeArrowWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<StrokeArrowWidthValues, StrokeArrowWidthKind>(value);
  }

  /// <summary>
  ///   Line Start Arrowhead Length
  /// </summary>
  public static StrokeArrowLengthKind? GetStartArrowLength(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowLengthValues, StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }

  public static void SetStartArrowLength(StrokeChildType? openXmlElement, StrokeArrowLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<StrokeArrowLengthValues, StrokeArrowLengthKind>(value);
  }

  /// <summary>
  ///   Line End Arrowhead
  /// </summary>
  public static StrokeArrowKind? GetEndArrow(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowValues, StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }

  public static void SetEndArrow(StrokeChildType? openXmlElement, StrokeArrowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<StrokeArrowValues, StrokeArrowKind>(value);
  }

  /// <summary>
  ///   Line End Arrowhead Width
  /// </summary>
  public static StrokeArrowWidthKind? GetEndArrowWidth(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowWidthValues, StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }

  public static void SetEndArrowWidth(StrokeChildType? openXmlElement, StrokeArrowWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<StrokeArrowWidthValues, StrokeArrowWidthKind>(value);
  }

  /// <summary>
  ///   Line End Arrowhead Length
  /// </summary>
  public static StrokeArrowLengthKind? GetEndArrowLength(StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowLengthValues, StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }

  public static void SetEndArrowLength(StrokeChildType? openXmlElement, StrokeArrowLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<StrokeArrowLengthValues, StrokeArrowLengthKind>(value);
  }

  /// <summary>
  ///   Original Image Reference
  /// </summary>
  public static String? GetHref(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }

  public static void SetHref(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Href = new StringValue { Value = value };
      else
        openXmlElement.Href = null;
  }

  /// <summary>
  ///   Alternate Image Reference
  /// </summary>
  public static String? GetAlternateImageReference(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }

  public static void SetAlternateImageReference(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlternateImageReference = new StringValue { Value = value };
      else
        openXmlElement.AlternateImageReference = null;
  }

  /// <summary>
  ///   Stroke Title
  /// </summary>
  public static String? GetTitle(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }

  public static void SetTitle(StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }

  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  public static Boolean? GetForceDash(StrokeChildType? openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }

  public static void SetForceDash(StrokeChildType? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForceDash = value;
      else
        openXmlElement.ForceDash = null;
  }

  public static DocumentModel.Vml.StrokeChildType? CreateModelElement(StrokeChildType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.StrokeChildType();
      value.Extension = GetExtension(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Weight = GetWeight(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Color2 = GetColor2(openXmlElement);
      value.Opacity = GetOpacity(openXmlElement);
      value.LineStyle = GetLineStyle(openXmlElement);
      value.MiterLimit = GetMiterLimit(openXmlElement);
      value.JoinStyle = GetJoinStyle(openXmlElement);
      value.EndCap = GetEndCap(openXmlElement);
      value.DashStyle = GetDashStyle(openXmlElement);
      value.InsetPen = GetInsetPen(openXmlElement);
      value.FillType = GetFillType(openXmlElement);
      value.Source = GetSource(openXmlElement);
      value.ImageAspect = GetImageAspect(openXmlElement);
      value.ImageSize = GetImageSize(openXmlElement);
      value.ImageAlignShape = GetImageAlignShape(openXmlElement);
      value.StartArrow = GetStartArrow(openXmlElement);
      value.StartArrowWidth = GetStartArrowWidth(openXmlElement);
      value.StartArrowLength = GetStartArrowLength(openXmlElement);
      value.EndArrow = GetEndArrow(openXmlElement);
      value.EndArrowWidth = GetEndArrowWidth(openXmlElement);
      value.EndArrowLength = GetEndArrowLength(openXmlElement);
      value.Href = GetHref(openXmlElement);
      value.AlternateImageReference = GetAlternateImageReference(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.ForceDash = GetForceDash(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.StrokeChildType? value)
    where OpenXmlElementType : StrokeChildType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetOn(openXmlElement, value?.On);
      SetWeight(openXmlElement, value?.Weight);
      SetColor(openXmlElement, value?.Color);
      SetColor2(openXmlElement, value?.Color2);
      SetOpacity(openXmlElement, value?.Opacity);
      SetLineStyle(openXmlElement, value?.LineStyle);
      SetMiterLimit(openXmlElement, value?.MiterLimit);
      SetJoinStyle(openXmlElement, value?.JoinStyle);
      SetEndCap(openXmlElement, value?.EndCap);
      SetDashStyle(openXmlElement, value?.DashStyle);
      SetInsetPen(openXmlElement, value?.InsetPen);
      SetFillType(openXmlElement, value?.FillType);
      SetSource(openXmlElement, value?.Source);
      SetImageAspect(openXmlElement, value?.ImageAspect);
      SetImageSize(openXmlElement, value?.ImageSize);
      SetImageAlignShape(openXmlElement, value?.ImageAlignShape);
      SetStartArrow(openXmlElement, value?.StartArrow);
      SetStartArrowWidth(openXmlElement, value?.StartArrowWidth);
      SetStartArrowLength(openXmlElement, value?.StartArrowLength);
      SetEndArrow(openXmlElement, value?.EndArrow);
      SetEndArrowWidth(openXmlElement, value?.EndArrowWidth);
      SetEndArrowLength(openXmlElement, value?.EndArrowLength);
      SetHref(openXmlElement, value?.Href);
      SetAlternateImageReference(openXmlElement, value?.AlternateImageReference);
      SetTitle(openXmlElement, value?.Title);
      SetForceDash(openXmlElement, value?.ForceDash);
      return openXmlElement;
    }
    return default;
  }
}