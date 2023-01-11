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
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  public static String? GetWeight(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return openXmlElement?.Weight?.Value;
  }
  
  public static void SetWeight(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
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
  public static String? GetColor(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  public static String? GetOpacity(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  public static void SetOpacity(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
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
    return openXmlElement?.Miterlimit?.Value;
  }
  
  public static void SetMiterlimit(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Miterlimit = new StringValue { Value = value };
      else
        openXmlElement.Miterlimit = null;
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
    return openXmlElement?.DashStyle?.Value;
  }
  
  public static void SetDashStyle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DashStyle = new StringValue { Value = value };
      else
        openXmlElement.DashStyle = null;
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
    return openXmlElement?.Source?.Value;
  }
  
  public static void SetSource(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
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
    return openXmlElement?.ImageSize?.Value;
  }
  
  public static void SetImageSize(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
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
  public static Boolean? GetImageAlignShape(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetImageAlignShape(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  public static String? GetColor2(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  public static void SetColor2(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color2 = new StringValue { Value = value };
      else
        openXmlElement.Color2 = null;
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
    return openXmlElement?.Href?.Value;
  }
  
  public static void SetHref(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
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
  public static String? GetAlternateImageReference(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }
  
  public static void SetAlternateImageReference(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
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
  public static String? GetTitle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
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
  public static Boolean? GetForceDash(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetForceDash(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  public static String? GetRelationshipId(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }
  
  public static void SetRelationshipId(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelationshipId = new StringValue { Value = value };
      else
        openXmlElement.RelationshipId = null;
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  public static Boolean? GetInsetpen(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  public static void SetInsetpen(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  /// <summary>
  /// LeftStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetLeftStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.LeftStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLeftStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// TopStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetTopStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.TopStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTopStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// RightStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetRightStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.RightStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRightStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// BottomStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetBottomStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.BottomStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBottomStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ColumnStroke.
  /// </summary>
  public static DocumentModel.Vml.StrokeChildType? GetColumnStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColumnStroke(DocumentFormat.OpenXml.Vml.Stroke? openXmlElement, DocumentModel.Vml.StrokeChildType? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
