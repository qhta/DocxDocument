namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Stroke Class.
/// </summary>
public static class StrokeConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  private static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  private static String? GetWeight(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Weight?.Value;
  }
  
  private static void SetWeight(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Weight = new StringValue { Value = value };
    else
      openXmlElement.Weight = null;
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  private static String? GetColor(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  private static String? GetOpacity(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  private static void SetOpacity(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity = new StringValue { Value = value };
    else
      openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  private static DocumentModel.Vml.StrokeLineStyleKind? GetLineStyle(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DocumentModel.Vml.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }
  
  private static void SetLineStyle(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeLineStyleKind? value)
  {
    openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DocumentModel.Vml.StrokeLineStyleKind>(value);
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  private static String? GetMiterlimit(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Miterlimit?.Value;
  }
  
  private static void SetMiterlimit(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Miterlimit = new StringValue { Value = value };
    else
      openXmlElement.Miterlimit = null;
  }
  
  /// <summary>
  /// Line End Join Style
  /// </summary>
  private static DocumentModel.Vml.StrokeJoinStyleKind? GetJoinStyle(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DocumentModel.Vml.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }
  
  private static void SetJoinStyle(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeJoinStyleKind? value)
  {
    openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DocumentModel.Vml.StrokeJoinStyleKind>(value);
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  private static DocumentModel.Vml.StrokeEndCapKind? GetEndCap(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DocumentModel.Vml.StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }
  
  private static void SetEndCap(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeEndCapKind? value)
  {
    openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DocumentModel.Vml.StrokeEndCapKind>(value);
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  private static String? GetDashStyle(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.DashStyle?.Value;
  }
  
  private static void SetDashStyle(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DashStyle = new StringValue { Value = value };
    else
      openXmlElement.DashStyle = null;
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  private static DocumentModel.Vml.StrokeFillKind? GetFillType(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DocumentModel.Vml.StrokeFillKind>(openXmlElement?.FillType?.Value);
  }
  
  private static void SetFillType(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeFillKind? value)
  {
    openXmlElement.FillType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DocumentModel.Vml.StrokeFillKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  private static String? GetSource(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }
  
  private static void SetSource(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Source = new StringValue { Value = value };
    else
      openXmlElement.Source = null;
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  private static DocumentModel.Vml.ImageAspectKind? GetImageAspect(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }
  
  private static void SetImageAspect(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.ImageAspectKind? value)
  {
    openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DocumentModel.Vml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  private static String? GetImageSize(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.ImageSize?.Value;
  }
  
  private static void SetImageSize(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageSize = new StringValue { Value = value };
    else
      openXmlElement.ImageSize = null;
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  private static Boolean? GetImageAlignShape(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.ImageAlignShape?.Value;
  }
  
  private static void SetImageAlignShape(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ImageAlignShape = value;
    else
      openXmlElement.ImageAlignShape = null;
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  private static String? GetColor2(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  private static void SetColor2(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color2 = new StringValue { Value = value };
    else
      openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowKind? GetStartArrow(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }
  
  private static void SetStartArrow(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeArrowKind? value)
  {
    openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowWidthKind? GetStartArrowWidth(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }
  
  private static void SetStartArrowWidth(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeArrowWidthKind? value)
  {
    openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowLengthKind? GetStartArrowLength(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }
  
  private static void SetStartArrowLength(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeArrowLengthKind? value)
  {
    openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowKind? GetEndArrow(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }
  
  private static void SetEndArrow(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeArrowKind? value)
  {
    openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DocumentModel.Vml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowWidthKind? GetEndArrowWidth(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }
  
  private static void SetEndArrowWidth(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeArrowWidthKind? value)
  {
    openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DocumentModel.Vml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  private static DocumentModel.Vml.StrokeArrowLengthKind? GetEndArrowLength(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }
  
  private static void SetEndArrowLength(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeArrowLengthKind? value)
  {
    openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DocumentModel.Vml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  private static String? GetHref(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }
  
  private static void SetHref(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Href = new StringValue { Value = value };
    else
      openXmlElement.Href = null;
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  private static String? GetAlternateImageReference(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }
  
  private static void SetAlternateImageReference(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.AlternateImageReference = new StringValue { Value = value };
    else
      openXmlElement.AlternateImageReference = null;
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  private static String? GetTitle(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static void SetForceDash(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  private static String? GetRelationshipId(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }
  
  private static void SetRelationshipId(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.RelationshipId = new StringValue { Value = value };
    else
      openXmlElement.RelationshipId = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetpen(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    return openXmlElement?.Insetpen?.Value;
  }
  
  private static void SetInsetpen(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Insetpen = value;
    else
      openXmlElement.Insetpen = null;
  }
  
  /// <summary>
  /// LeftStroke.
  /// </summary>
  private static DocumentModel.Vml.StrokeChildType? GetLeftStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LeftStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLeftStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LeftStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.LeftStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TopStroke.
  /// </summary>
  private static DocumentModel.Vml.StrokeChildType? GetTopStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.TopStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTopStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.TopStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.TopStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RightStroke.
  /// </summary>
  private static DocumentModel.Vml.StrokeChildType? GetRightStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RightStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRightStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RightStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.RightStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BottomStroke.
  /// </summary>
  private static DocumentModel.Vml.StrokeChildType? GetBottomStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.BottomStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBottomStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.BottomStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.BottomStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColumnStroke.
  /// </summary>
  private static DocumentModel.Vml.StrokeChildType? GetColumnStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColumnStroke(DocumentFormat.OpenXml.Vml.Stroke openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Stroke? CreateModelElement(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Stroke();
      value.Id = GetId(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Weight = GetWeight(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Opacity = GetOpacity(openXmlElement);
      value.LineStyle = GetLineStyle(openXmlElement);
      value.Miterlimit = GetMiterlimit(openXmlElement);
      value.JoinStyle = GetJoinStyle(openXmlElement);
      value.EndCap = GetEndCap(openXmlElement);
      value.DashStyle = GetDashStyle(openXmlElement);
      value.FillType = GetFillType(openXmlElement);
      value.Source = GetSource(openXmlElement);
      value.ImageAspect = GetImageAspect(openXmlElement);
      value.ImageSize = GetImageSize(openXmlElement);
      value.ImageAlignShape = GetImageAlignShape(openXmlElement);
      value.Color2 = GetColor2(openXmlElement);
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
      value.RelationshipId = GetRelationshipId(openXmlElement);
      value.Insetpen = GetInsetpen(openXmlElement);
      value.LeftStroke = GetLeftStroke(openXmlElement);
      value.TopStroke = GetTopStroke(openXmlElement);
      value.RightStroke = GetRightStroke(openXmlElement);
      value.BottomStroke = GetBottomStroke(openXmlElement);
      value.ColumnStroke = GetColumnStroke(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Stroke? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Stroke, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetOn(openXmlElement, value?.On);
      SetWeight(openXmlElement, value?.Weight);
      SetColor(openXmlElement, value?.Color);
      SetOpacity(openXmlElement, value?.Opacity);
      SetLineStyle(openXmlElement, value?.LineStyle);
      SetMiterlimit(openXmlElement, value?.Miterlimit);
      SetJoinStyle(openXmlElement, value?.JoinStyle);
      SetEndCap(openXmlElement, value?.EndCap);
      SetDashStyle(openXmlElement, value?.DashStyle);
      SetFillType(openXmlElement, value?.FillType);
      SetSource(openXmlElement, value?.Source);
      SetImageAspect(openXmlElement, value?.ImageAspect);
      SetImageSize(openXmlElement, value?.ImageSize);
      SetImageAlignShape(openXmlElement, value?.ImageAlignShape);
      SetColor2(openXmlElement, value?.Color2);
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
      SetRelationshipId(openXmlElement, value?.RelationshipId);
      SetInsetpen(openXmlElement, value?.Insetpen);
      SetLeftStroke(openXmlElement, value?.LeftStroke);
      SetTopStroke(openXmlElement, value?.TopStroke);
      SetRightStroke(openXmlElement, value?.RightStroke);
      SetBottomStroke(openXmlElement, value?.BottomStroke);
      SetColumnStroke(openXmlElement, value?.ColumnStroke);
      return openXmlElement;
    }
    return default;
  }
}
