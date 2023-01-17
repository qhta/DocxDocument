namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public static class StrokeChildTypeConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  private static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  private static String? GetWeight(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Weight?.Value;
  }
  
  private static void SetWeight(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Weight = new StringValue { Value = value };
    else
      openXmlElement.Weight = null;
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  private static String? GetColor(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  private static String? GetColor2(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  private static void SetColor2(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color2 = new StringValue { Value = value };
    else
      openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  private static String? GetOpacity(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  private static void SetOpacity(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity = new StringValue { Value = value };
    else
      openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  private static DocumentModel.Vml.StrokeLineStyleKind? GetLineStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DocumentModel.Vml.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }
  
  private static void SetLineStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeLineStyleKind? value)
  {
    openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DocumentModel.Vml.StrokeLineStyleKind>(value);
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  private static Decimal? GetMiterLimit(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement.MiterLimit?.Value;
  }
  
  private static void SetMiterLimit(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, Decimal? value)
  {
    openXmlElement.MiterLimit = value;
  }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  private static DocumentModel.Vml.StrokeJoinStyleKind? GetJoinStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DocumentModel.Vml.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }
  
  private static void SetJoinStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeJoinStyleKind? value)
  {
    openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DocumentModel.Vml.StrokeJoinStyleKind>(value);
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  private static DocumentModel.Vml.StrokeEndCapKind? GetEndCap(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DocumentModel.Vml.StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }
  
  private static void SetEndCap(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeEndCapKind? value)
  {
    openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DocumentModel.Vml.StrokeEndCapKind>(value);
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  private static String? GetDashStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.DashStyle?.Value;
  }
  
  private static void SetDashStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DashStyle = new StringValue { Value = value };
    else
      openXmlElement.DashStyle = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetPen(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.InsetPen?.Value;
  }
  
  private static void SetInsetPen(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InsetPen = value;
    else
      openXmlElement.InsetPen = null;
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  private static DocumentModel.Vml.FillKind? GetFillType(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(openXmlElement?.FillType?.Value);
  }
  
  private static void SetFillType(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.FillKind? value)
  {
    openXmlElement.FillType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  private static String? GetSource(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  private static void SetSource(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Source = new StringValue { Value = value };
    else
      openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  private static DocumentModel.Vml.ImageAspectKind? GetImageAspect(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }
  
  private static void SetImageAspect(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.ImageAspectKind? value)
  {
    openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  private static String? GetImageSize(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.ImageSize?.Value;
  }
  
  private static void SetImageSize(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageSize = new StringValue { Value = value };
    else
      openXmlElement.ImageSize = null;
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  private static Boolean? GetImageAlignShape(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.ImageAlignShape?.Value;
  }
  
  private static void SetImageAlignShape(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ImageAlignShape = value;
    else
      openXmlElement.ImageAlignShape = null;
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowKind? GetStartArrow(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }
  
  private static void SetStartArrow(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeArrowKind? value)
  {
    openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowWidthKind? GetStartArrowWidth(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }
  
  private static void SetStartArrowWidth(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeArrowWidthKind? value)
  {
    openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowLengthKind? GetStartArrowLength(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }
  
  private static void SetStartArrowLength(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeArrowLengthKind? value)
  {
    openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowKind? GetEndArrow(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }
  
  private static void SetEndArrow(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeArrowKind? value)
  {
    openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowWidthKind? GetEndArrowWidth(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }
  
  private static void SetEndArrowWidth(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeArrowWidthKind? value)
  {
    openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowLengthKind? GetEndArrowLength(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }
  
  private static void SetEndArrowLength(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, DocumentModel.Vml.StrokeArrowLengthKind? value)
  {
    openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  private static String? GetHref(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static void SetHref(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  private static String? GetAlternateImageReference(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }
  
  private static void SetAlternateImageReference(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlternateImageReference = new StringValue { Value = value };
    else
      openXmlElement.AlternateImageReference = null;
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  private static String? GetTitle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static void SetForceDash(DocumentFormat.OpenXml.Vml.Office.StrokeChildType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  public static DocumentModel.Vml.StrokeChildType? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.StrokeChildType, new()
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
