namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public static class StrokeChildTypeConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.StrokeChildType openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  private static Boolean? GetOn(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DXVmlO.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  private static String? GetWeight(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Weight?.Value;
  }
  
  private static void SetWeight(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Weight = new StringValue { Value = value };
    else
      openXmlElement.Weight = null;
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  private static String? GetColor(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  private static String? GetColor2(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  private static void SetColor2(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color2 = new StringValue { Value = value };
    else
      openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  private static String? GetOpacity(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  private static void SetOpacity(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity = new StringValue { Value = value };
    else
      openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  private static DMVml.StrokeLineStyleKind? GetLineStyle(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMVml.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }
  
  private static void SetLineStyle(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeLineStyleKind? value)
  {
    openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMVml.StrokeLineStyleKind>(value);
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  private static Decimal? GetMiterLimit(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement.MiterLimit?.Value;
  }
  
  private static void SetMiterLimit(DXVmlO.StrokeChildType openXmlElement, Decimal? value)
  {
    openXmlElement.MiterLimit = value;
  }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  private static DMVml.StrokeJoinStyleKind? GetJoinStyle(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMVml.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }
  
  private static void SetJoinStyle(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeJoinStyleKind? value)
  {
    openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMVml.StrokeJoinStyleKind>(value);
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  private static DMVml.StrokeEndCapKind? GetEndCap(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMVml.StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }
  
  private static void SetEndCap(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeEndCapKind? value)
  {
    openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMVml.StrokeEndCapKind>(value);
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  private static String? GetDashStyle(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.DashStyle?.Value;
  }
  
  private static void SetDashStyle(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DashStyle = new StringValue { Value = value };
    else
      openXmlElement.DashStyle = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static void SetInsetPen(DXVmlO.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  private static DMVml.FillKind? GetFillType(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMVml.FillKind>(openXmlElement?.FillType?.Value);
  }
  
  private static void SetFillType(DXVmlO.StrokeChildType openXmlElement, DMVml.FillKind? value)
  {
    openXmlElement.FillType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMVml.FillKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  private static String? GetSource(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  private static void SetSource(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Source = new StringValue { Value = value };
    else
      openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  private static DMVml.ImageAspectKind? GetImageAspect(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }
  
  private static void SetImageAspect(DXVmlO.StrokeChildType openXmlElement, DMVml.ImageAspectKind? value)
  {
    openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  private static String? GetImageSize(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.ImageSize?.Value;
  }
  
  private static void SetImageSize(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageSize = new StringValue { Value = value };
    else
      openXmlElement.ImageSize = null;
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  private static Boolean? GetImageAlignShape(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.ImageAlignShape?.Value;
  }
  
  private static void SetImageAlignShape(DXVmlO.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ImageAlignShape = value;
    else
      openXmlElement.ImageAlignShape = null;
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  private static DMVml.StrokeArrowKind? GetStartArrow(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }
  
  private static void SetStartArrow(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeArrowKind? value)
  {
    openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  private static DMVml.StrokeArrowWidthKind? GetStartArrowWidth(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }
  
  private static void SetStartArrowWidth(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeArrowWidthKind? value)
  {
    openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  private static DMVml.StrokeArrowLengthKind? GetStartArrowLength(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }
  
  private static void SetStartArrowLength(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeArrowLengthKind? value)
  {
    openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  private static DMVml.StrokeArrowKind? GetEndArrow(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }
  
  private static void SetEndArrow(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeArrowKind? value)
  {
    openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  private static DMVml.StrokeArrowWidthKind? GetEndArrowWidth(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }
  
  private static void SetEndArrowWidth(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeArrowWidthKind? value)
  {
    openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  private static DMVml.StrokeArrowLengthKind? GetEndArrowLength(DXVmlO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }
  
  private static void SetEndArrowLength(DXVmlO.StrokeChildType openXmlElement, DMVml.StrokeArrowLengthKind? value)
  {
    openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  private static String? GetHref(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static void SetHref(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  private static String? GetAlternateImageReference(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }
  
  private static void SetAlternateImageReference(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlternateImageReference = new StringValue { Value = value };
    else
      openXmlElement.AlternateImageReference = null;
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  private static String? GetTitle(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DXVmlO.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXVmlO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static void SetForceDash(DXVmlO.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  public static DMVml.StrokeChildType? CreateModelElement(DXVmlO.StrokeChildType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.StrokeChildType();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.StrokeChildType? value)
    where OpenXmlElementType: DXVmlO.StrokeChildType, new()
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
