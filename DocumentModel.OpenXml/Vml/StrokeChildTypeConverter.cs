namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the StrokeChildType Class.
/// </summary>
public static class StrokeChildTypeConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public static String? GetWeight(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Weight?.Value;
  }
  
  public static void SetWeight(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Weight = new StringValue { Value = value };
      else
        openXmlElement.Weight = null;
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  public static String? GetColor2(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  public static void SetColor2(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color2 = new StringValue { Value = value };
      else
        openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public static String? GetOpacity(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  public static void SetOpacity(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Opacity = new StringValue { Value = value };
      else
        openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public static DocumentModel.Vml.StrokeLineStyleKind? GetLineStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DocumentModel.Vml.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }
  
  public static void SetLineStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeLineStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DocumentModel.Vml.StrokeLineStyleKind>(value);
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  public static Decimal? GetMiterLimit(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.MiterLimit?.Value;
  }
  
  public static void SetMiterLimit(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, Decimal? value)
  {
    if (openXmlElement != null)
      openXmlElement.MiterLimit = value;
  }
  
  /// <summary>
  /// Line End Join Style)
  /// </summary>
  public static DocumentModel.Vml.StrokeJoinStyleKind? GetJoinStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DocumentModel.Vml.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }
  
  public static void SetJoinStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeJoinStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DocumentModel.Vml.StrokeJoinStyleKind>(value);
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public static DocumentModel.Vml.StrokeEndCapKind? GetEndCap(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DocumentModel.Vml.StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }
  
  public static void SetEndCap(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeEndCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DocumentModel.Vml.StrokeEndCapKind>(value);
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  public static String? GetDashStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.DashStyle?.Value;
  }
  
  public static void SetDashStyle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DashStyle = new StringValue { Value = value };
      else
        openXmlElement.DashStyle = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public static Boolean? GetInsetPen(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetInsetPen(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public static DocumentModel.Vml.FillKind? GetFillType(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(openXmlElement?.FillType?.Value);
  }
  
  public static void SetFillType(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.FillKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FillType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues, DocumentModel.Vml.FillKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  public static String? GetSource(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  public static void SetSource(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Source = new StringValue { Value = value };
      else
        openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public static DocumentModel.Vml.ImageAspectKind? GetImageAspect(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }
  
  public static void SetImageAspect(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.ImageAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  public static String? GetImageSize(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.ImageSize?.Value;
  }
  
  public static void SetImageSize(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageSize = new StringValue { Value = value };
      else
        openXmlElement.ImageSize = null;
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  public static Boolean? GetImageAlignShape(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetImageAlignShape(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowKind? GetStartArrow(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }
  
  public static void SetStartArrow(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeArrowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowWidthKind? GetStartArrowWidth(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }
  
  public static void SetStartArrowWidth(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeArrowWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowLengthKind? GetStartArrowLength(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }
  
  public static void SetStartArrowLength(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeArrowLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowKind? GetEndArrow(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }
  
  public static void SetEndArrow(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeArrowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowWidthKind? GetEndArrowWidth(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }
  
  public static void SetEndArrowWidth(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeArrowWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowLengthKind? GetEndArrowLength(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }
  
  public static void SetEndArrowLength(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, DocumentModel.Vml.StrokeArrowLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  public static String? GetHref(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  public static void SetHref(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Href = new StringValue { Value = value };
      else
        openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  public static String? GetAlternateImageReference(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }
  
  public static void SetAlternateImageReference(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlternateImageReference = new StringValue { Value = value };
      else
        openXmlElement.AlternateImageReference = null;
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public static Boolean? GetForceDash(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetForceDash(DocumentFormat.OpenXml.Vml.Office.StrokeChildType? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
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
