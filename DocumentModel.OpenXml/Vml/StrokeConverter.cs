namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Stroke Class.
/// </summary>
public static class StrokeConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public static String? GetWeight(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetWeight(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public static String? GetOpacity(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOpacity(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  public static DocumentModel.Vml.StrokeLineStyleKind? GetLineStyle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DocumentModel.Vml.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }
  
  public static void SetLineStyle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeLineStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DocumentModel.Vml.StrokeLineStyleKind>(value);
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  public static String? GetMiterlimit(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetMiterlimit(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Line End Join Style
  /// </summary>
  public static DocumentModel.Vml.StrokeJoinStyleKind? GetJoinStyle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DocumentModel.Vml.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }
  
  public static void SetJoinStyle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeJoinStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DocumentModel.Vml.StrokeJoinStyleKind>(value);
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  public static DocumentModel.Vml.StrokeEndCapKind? GetEndCap(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DocumentModel.Vml.StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }
  
  public static void SetEndCap(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeEndCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DocumentModel.Vml.StrokeEndCapKind>(value);
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  public static String? GetDashStyle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetDashStyle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  public static DocumentModel.Vml.StrokeFillKind? GetFillType(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DocumentModel.Vml.StrokeFillKind>(openXmlElement?.FillType?.Value);
  }
  
  public static void SetFillType(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeFillKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FillType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DocumentModel.Vml.StrokeFillKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  public static String? GetSource(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSource(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  public static DocumentModel.Vml.ImageAspectKind? GetImageAspect(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }
  
  public static void SetImageAspect(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.ImageAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  public static String? GetImageSize(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetImageSize(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  public static Boolean? GetImageAlignShape(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetImageAlignShape(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  public static String? GetColor2(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetColor2(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowKind? GetStartArrow(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }
  
  public static void SetStartArrow(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeArrowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowWidthKind? GetStartArrowWidth(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }
  
  public static void SetStartArrowWidth(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeArrowWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowLengthKind? GetStartArrowLength(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }
  
  public static void SetStartArrowLength(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeArrowLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowKind? GetEndArrow(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }
  
  public static void SetEndArrow(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeArrowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowWidthKind? GetEndArrowWidth(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }
  
  public static void SetEndArrowWidth(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeArrowWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  public static DocumentModel.Vml.StrokeArrowLengthKind? GetEndArrowLength(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }
  
  public static void SetEndArrowLength(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeArrowLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  public static String? GetHref(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetHref(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  public static String? GetAlternateImageReference(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAlternateImageReference(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  public static Boolean? GetForceDash(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetForceDash(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public static String? GetRelationshipId(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetRelationshipId(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public static Boolean? GetInsetpen(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInsetpen(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// LeftStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetLeftStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLeftStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// TopStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetTopStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTopStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// RightStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetRightStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRightStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// BottomStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetBottomStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBottomStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ColumnStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetColumnStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
