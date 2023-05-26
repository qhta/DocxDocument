namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public static class StrokeChildTypeConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMV.ExtensionHandlingBehaviorKind? GetExtension(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static bool CmpExtension(DXVO.StrokeChildType openXmlElement, DMV.ExtensionHandlingBehaviorKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value, value, diffs, objName, propName);
  }
  
  private static void SetExtension(DXVO.StrokeChildType openXmlElement, DMV.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMV.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  private static Boolean? GetOn(DXVO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVO.StrokeChildType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVO.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  private static String? GetWeight(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Weight);
  }
  
  private static bool CmpWeight(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Weight, value, diffs, objName, "Weight");
  }
  
  private static void SetWeight(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.Weight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  private static String? GetColor(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  private static String? GetColor2(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color2);
  }
  
  private static bool CmpColor2(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color2, value, diffs, objName, "Color2");
  }
  
  private static void SetColor2(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.Color2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  private static String? GetOpacity(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Opacity);
  }
  
  private static bool CmpOpacity(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Opacity, value, diffs, objName, "Opacity");
  }
  
  private static void SetOpacity(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.Opacity = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  private static DMV.StrokeLineStyleKind? GetLineStyle(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMV.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }
  
  private static bool CmpLineStyle(DXVO.StrokeChildType openXmlElement, DMV.StrokeLineStyleKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMV.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLineStyle(DXVO.StrokeChildType openXmlElement, DMV.StrokeLineStyleKind? value)
  {
    openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMV.StrokeLineStyleKind>(value);
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  private static Decimal? GetMiterLimit(DXVO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.MiterLimit?.Value;
  }
  
  private static bool CmpMiterLimit(DXVO.StrokeChildType openXmlElement, Decimal? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.MiterLimit?.Value == value) return true;
    diffs?.Add(objName, "MiterLimit", openXmlElement?.MiterLimit?.Value, value);
    return false;
  }
  
  private static void SetMiterLimit(DXVO.StrokeChildType openXmlElement, Decimal? value)
  {
    openXmlElement.MiterLimit = value;
  }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  private static DMV.StrokeJoinStyleKind? GetJoinStyle(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMV.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }
  
  private static bool CmpJoinStyle(DXVO.StrokeChildType openXmlElement, DMV.StrokeJoinStyleKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMV.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value, value, diffs, objName, propName);
  }
  
  private static void SetJoinStyle(DXVO.StrokeChildType openXmlElement, DMV.StrokeJoinStyleKind? value)
  {
    openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMV.StrokeJoinStyleKind>(value);
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  private static DMV.StrokeEndCapKind? GetEndCap(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMV.StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }
  
  private static bool CmpEndCap(DXVO.StrokeChildType openXmlElement, DMV.StrokeEndCapKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMV.StrokeEndCapKind>(openXmlElement?.EndCap?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEndCap(DXVO.StrokeChildType openXmlElement, DMV.StrokeEndCapKind? value)
  {
    openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMV.StrokeEndCapKind>(value);
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  private static String? GetDashStyle(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DashStyle);
  }
  
  private static bool CmpDashStyle(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DashStyle, value, diffs, objName, "DashStyle");
  }
  
  private static void SetDashStyle(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.DashStyle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DXVO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static bool CmpInsetPen(DXVO.StrokeChildType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.InsetPen?.Value == value) return true;
    diffs?.Add(objName, "InsetPen", openXmlElement?.InsetPen?.Value, value);
    return false;
  }
  
  private static void SetInsetPen(DXVO.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  private static DMV.FillTypeKind? GetFillType(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMV.FillTypeKind>(openXmlElement?.FillType?.Value);
  }
  
  private static bool CmpFillType(DXVO.StrokeChildType openXmlElement, DMV.FillTypeKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMV.FillTypeKind>(openXmlElement?.FillType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFillType(DXVO.StrokeChildType openXmlElement, DMV.FillTypeKind? value)
  {
    openXmlElement.FillType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DMV.FillTypeKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  private static String? GetSource(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Source);
  }
  
  private static bool CmpSource(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Source, value, diffs, objName, "Source");
  }
  
  private static void SetSource(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.Source = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  private static DMV.ImageAspectKind? GetImageAspect(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }
  
  private static bool CmpImageAspect(DXVO.StrokeChildType openXmlElement, DMV.ImageAspectKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(openXmlElement?.ImageAspect?.Value, value, diffs, objName, propName);
  }
  
  private static void SetImageAspect(DXVO.StrokeChildType openXmlElement, DMV.ImageAspectKind? value)
  {
    openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  private static String? GetImageSize(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageSize);
  }
  
  private static bool CmpImageSize(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageSize, value, diffs, objName, "ImageSize");
  }
  
  private static void SetImageSize(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.ImageSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  private static Boolean? GetImageAlignShape(DXVO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.ImageAlignShape?.Value;
  }
  
  private static bool CmpImageAlignShape(DXVO.StrokeChildType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ImageAlignShape?.Value == value) return true;
    diffs?.Add(objName, "ImageAlignShape", openXmlElement?.ImageAlignShape?.Value, value);
    return false;
  }
  
  private static void SetImageAlignShape(DXVO.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ImageAlignShape = value;
    else
      openXmlElement.ImageAlignShape = null;
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  private static DMV.StrokeArrowKind? GetStartArrow(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }
  
  private static bool CmpStartArrow(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(openXmlElement?.StartArrow?.Value, value, diffs, objName, propName);
  }
  
  private static void SetStartArrow(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowKind? value)
  {
    openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  private static DMV.StrokeArrowWidthKind? GetStartArrowWidth(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }
  
  private static bool CmpStartArrowWidth(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowWidthKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value, value, diffs, objName, propName);
  }
  
  private static void SetStartArrowWidth(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowWidthKind? value)
  {
    openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  private static DMV.StrokeArrowLengthKind? GetStartArrowLength(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }
  
  private static bool CmpStartArrowLength(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowLengthKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value, value, diffs, objName, propName);
  }
  
  private static void SetStartArrowLength(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowLengthKind? value)
  {
    openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  private static DMV.StrokeArrowKind? GetEndArrow(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }
  
  private static bool CmpEndArrow(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(openXmlElement?.EndArrow?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEndArrow(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowKind? value)
  {
    openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  private static DMV.StrokeArrowWidthKind? GetEndArrowWidth(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }
  
  private static bool CmpEndArrowWidth(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowWidthKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEndArrowWidth(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowWidthKind? value)
  {
    openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  private static DMV.StrokeArrowLengthKind? GetEndArrowLength(DXVO.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }
  
  private static bool CmpEndArrowLength(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowLengthKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value, value, diffs, objName, propName);
  }
  
  private static void SetEndArrowLength(DXVO.StrokeChildType openXmlElement, DMV.StrokeArrowLengthKind? value)
  {
    openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  private static String? GetHref(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  private static String? GetAlternateImageReference(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlternateImageReference);
  }
  
  private static bool CmpAlternateImageReference(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlternateImageReference, value, diffs, objName, "AlternateImageReference");
  }
  
  private static void SetAlternateImageReference(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.AlternateImageReference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  private static String? GetTitle(DXVO.StrokeChildType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXVO.StrokeChildType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXVO.StrokeChildType openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXVO.StrokeChildType openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static bool CmpForceDash(DXVO.StrokeChildType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ForceDash?.Value == value) return true;
    diffs?.Add(objName, "ForceDash", openXmlElement?.ForceDash?.Value, value);
    return false;
  }
  
  private static void SetForceDash(DXVO.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  public static DocumentModel.Vml.StrokeChildType? CreateModelElement(DXVO.StrokeChildType? openXmlElement)
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
  
  public static bool CompareModelElement(DXVO.StrokeChildType? openXmlElement, DMV.StrokeChildType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension(openXmlElement, value.Extension, diffs, objName, propName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName, propName))
        ok = false;
      if (!CmpWeight(openXmlElement, value.Weight, diffs, objName, propName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName, propName))
        ok = false;
      if (!CmpColor2(openXmlElement, value.Color2, diffs, objName, propName))
        ok = false;
      if (!CmpOpacity(openXmlElement, value.Opacity, diffs, objName, propName))
        ok = false;
      if (!CmpLineStyle(openXmlElement, value.LineStyle, diffs, objName, propName))
        ok = false;
      if (!CmpMiterLimit(openXmlElement, value.MiterLimit, diffs, objName, propName))
        ok = false;
      if (!CmpJoinStyle(openXmlElement, value.JoinStyle, diffs, objName, propName))
        ok = false;
      if (!CmpEndCap(openXmlElement, value.EndCap, diffs, objName, propName))
        ok = false;
      if (!CmpDashStyle(openXmlElement, value.DashStyle, diffs, objName, propName))
        ok = false;
      if (!CmpInsetPen(openXmlElement, value.InsetPen, diffs, objName, propName))
        ok = false;
      if (!CmpFillType(openXmlElement, value.FillType, diffs, objName, propName))
        ok = false;
      if (!CmpSource(openXmlElement, value.Source, diffs, objName, propName))
        ok = false;
      if (!CmpImageAspect(openXmlElement, value.ImageAspect, diffs, objName, propName))
        ok = false;
      if (!CmpImageSize(openXmlElement, value.ImageSize, diffs, objName, propName))
        ok = false;
      if (!CmpImageAlignShape(openXmlElement, value.ImageAlignShape, diffs, objName, propName))
        ok = false;
      if (!CmpStartArrow(openXmlElement, value.StartArrow, diffs, objName, propName))
        ok = false;
      if (!CmpStartArrowWidth(openXmlElement, value.StartArrowWidth, diffs, objName, propName))
        ok = false;
      if (!CmpStartArrowLength(openXmlElement, value.StartArrowLength, diffs, objName, propName))
        ok = false;
      if (!CmpEndArrow(openXmlElement, value.EndArrow, diffs, objName, propName))
        ok = false;
      if (!CmpEndArrowWidth(openXmlElement, value.EndArrowWidth, diffs, objName, propName))
        ok = false;
      if (!CmpEndArrowLength(openXmlElement, value.EndArrowLength, diffs, objName, propName))
        ok = false;
      if (!CmpHref(openXmlElement, value.Href, diffs, objName, propName))
        ok = false;
      if (!CmpAlternateImageReference(openXmlElement, value.AlternateImageReference, diffs, objName, propName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName, propName))
        ok = false;
      if (!CmpForceDash(openXmlElement, value.ForceDash, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.StrokeChildType value)
    where OpenXmlElementType: DXVO.StrokeChildType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVO.StrokeChildType openXmlElement, DMV.StrokeChildType value)
  {
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
  }
}
