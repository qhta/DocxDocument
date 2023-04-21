namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Stroke Class.
/// </summary>
public static class StrokeConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  private static Boolean? GetOn(DXV.Stroke openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXV.Stroke openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXV.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  private static String? GetWeight(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Weight);
  }
  
  private static bool CmpWeight(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Weight, value, diffs, objName, "Weight");
  }
  
  private static void SetWeight(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Weight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  private static String? GetColor(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  private static String? GetOpacity(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Opacity);
  }
  
  private static bool CmpOpacity(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Opacity, value, diffs, objName, "Opacity");
  }
  
  private static void SetOpacity(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Opacity = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  private static DMV.StrokeLineStyleKind? GetLineStyle(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMV.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }
  
  private static bool CmpLineStyle(DXV.Stroke openXmlElement, DMV.StrokeLineStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMV.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value, value, diffs, objName);
  }
  
  private static void SetLineStyle(DXV.Stroke openXmlElement, DMV.StrokeLineStyleKind? value)
  {
    openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMV.StrokeLineStyleKind>(value);
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  private static String? GetMiterlimit(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Miterlimit);
  }
  
  private static bool CmpMiterlimit(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Miterlimit, value, diffs, objName, "Miterlimit");
  }
  
  private static void SetMiterlimit(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Miterlimit = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Line End Join Style
  /// </summary>
  private static DMV.StrokeJoinStyleKind? GetJoinStyle(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMV.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }
  
  private static bool CmpJoinStyle(DXV.Stroke openXmlElement, DMV.StrokeJoinStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMV.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value, value, diffs, objName);
  }
  
  private static void SetJoinStyle(DXV.Stroke openXmlElement, DMV.StrokeJoinStyleKind? value)
  {
    openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMV.StrokeJoinStyleKind>(value);
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  private static DMV.StrokeEndCapKind? GetEndCap(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMV.StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }
  
  private static bool CmpEndCap(DXV.Stroke openXmlElement, DMV.StrokeEndCapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMV.StrokeEndCapKind>(openXmlElement?.EndCap?.Value, value, diffs, objName);
  }
  
  private static void SetEndCap(DXV.Stroke openXmlElement, DMV.StrokeEndCapKind? value)
  {
    openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMV.StrokeEndCapKind>(value);
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  private static String? GetDashStyle(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DashStyle);
  }
  
  private static bool CmpDashStyle(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DashStyle, value, diffs, objName, "DashStyle");
  }
  
  private static void SetDashStyle(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.DashStyle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  private static DMV.StrokeFillKind? GetFillType(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DMV.StrokeFillKind>(openXmlElement?.FillType?.Value);
  }
  
  private static bool CmpFillType(DXV.Stroke openXmlElement, DMV.StrokeFillKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DMV.StrokeFillKind>(openXmlElement?.FillType?.Value, value, diffs, objName);
  }
  
  private static void SetFillType(DXV.Stroke openXmlElement, DMV.StrokeFillKind? value)
  {
    openXmlElement.FillType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DMV.StrokeFillKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  private static String? GetSource(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Source);
  }
  
  private static bool CmpSource(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Source, value, diffs, objName, "Source");
  }
  
  private static void SetSource(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Source = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  private static DMV.ImageAspectKind? GetImageAspect(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }
  
  private static bool CmpImageAspect(DXV.Stroke openXmlElement, DMV.ImageAspectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(openXmlElement?.ImageAspect?.Value, value, diffs, objName);
  }
  
  private static void SetImageAspect(DXV.Stroke openXmlElement, DMV.ImageAspectKind? value)
  {
    openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMV.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  private static String? GetImageSize(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageSize);
  }
  
  private static bool CmpImageSize(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageSize, value, diffs, objName, "ImageSize");
  }
  
  private static void SetImageSize(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.ImageSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  private static Boolean? GetImageAlignShape(DXV.Stroke openXmlElement)
  {
    return openXmlElement?.ImageAlignShape?.Value;
  }
  
  private static bool CmpImageAlignShape(DXV.Stroke openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ImageAlignShape?.Value == value) return true;
    diffs?.Add(objName, "ImageAlignShape", openXmlElement?.ImageAlignShape?.Value, value);
    return false;
  }
  
  private static void SetImageAlignShape(DXV.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ImageAlignShape = value;
    else
      openXmlElement.ImageAlignShape = null;
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  private static String? GetColor2(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color2);
  }
  
  private static bool CmpColor2(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color2, value, diffs, objName, "Color2");
  }
  
  private static void SetColor2(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Color2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  private static DMV.StrokeArrowKind? GetStartArrow(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }
  
  private static bool CmpStartArrow(DXV.Stroke openXmlElement, DMV.StrokeArrowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(openXmlElement?.StartArrow?.Value, value, diffs, objName);
  }
  
  private static void SetStartArrow(DXV.Stroke openXmlElement, DMV.StrokeArrowKind? value)
  {
    openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  private static DMV.StrokeArrowWidthKind? GetStartArrowWidth(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }
  
  private static bool CmpStartArrowWidth(DXV.Stroke openXmlElement, DMV.StrokeArrowWidthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value, value, diffs, objName);
  }
  
  private static void SetStartArrowWidth(DXV.Stroke openXmlElement, DMV.StrokeArrowWidthKind? value)
  {
    openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  private static DMV.StrokeArrowLengthKind? GetStartArrowLength(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }
  
  private static bool CmpStartArrowLength(DXV.Stroke openXmlElement, DMV.StrokeArrowLengthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value, value, diffs, objName);
  }
  
  private static void SetStartArrowLength(DXV.Stroke openXmlElement, DMV.StrokeArrowLengthKind? value)
  {
    openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  private static DMV.StrokeArrowKind? GetEndArrow(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }
  
  private static bool CmpEndArrow(DXV.Stroke openXmlElement, DMV.StrokeArrowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(openXmlElement?.EndArrow?.Value, value, diffs, objName);
  }
  
  private static void SetEndArrow(DXV.Stroke openXmlElement, DMV.StrokeArrowKind? value)
  {
    openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMV.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  private static DMV.StrokeArrowWidthKind? GetEndArrowWidth(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }
  
  private static bool CmpEndArrowWidth(DXV.Stroke openXmlElement, DMV.StrokeArrowWidthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value, value, diffs, objName);
  }
  
  private static void SetEndArrowWidth(DXV.Stroke openXmlElement, DMV.StrokeArrowWidthKind? value)
  {
    openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMV.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  private static DMV.StrokeArrowLengthKind? GetEndArrowLength(DXV.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }
  
  private static bool CmpEndArrowLength(DXV.Stroke openXmlElement, DMV.StrokeArrowLengthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value, value, diffs, objName);
  }
  
  private static void SetEndArrowLength(DXV.Stroke openXmlElement, DMV.StrokeArrowLengthKind? value)
  {
    openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMV.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  private static String? GetHref(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  private static String? GetAlternateImageReference(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlternateImageReference);
  }
  
  private static bool CmpAlternateImageReference(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlternateImageReference, value, diffs, objName, "AlternateImageReference");
  }
  
  private static void SetAlternateImageReference(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.AlternateImageReference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  private static String? GetTitle(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXV.Stroke openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static bool CmpForceDash(DXV.Stroke openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ForceDash?.Value == value) return true;
    diffs?.Add(objName, "ForceDash", openXmlElement?.ForceDash?.Value, value);
    return false;
  }
  
  private static void SetForceDash(DXV.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  private static String? GetRelationshipId(DXV.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelationshipId);
  }
  
  private static bool CmpRelationshipId(DXV.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelationshipId, value, diffs, objName, "RelationshipId");
  }
  
  private static void SetRelationshipId(DXV.Stroke openXmlElement, String? value)
  {
    openXmlElement.RelationshipId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetpen(DXV.Stroke openXmlElement)
  {
    return openXmlElement?.Insetpen?.Value;
  }
  
  private static bool CmpInsetpen(DXV.Stroke openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Insetpen?.Value == value) return true;
    diffs?.Add(objName, "Insetpen", openXmlElement?.Insetpen?.Value, value);
    return false;
  }
  
  private static void SetInsetpen(DXV.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Insetpen = value;
    else
      openXmlElement.Insetpen = null;
  }
  
  /// <summary>
  /// LeftStroke.
  /// </summary>
  private static DMV.StrokeChildType? GetLeftStroke(DXV.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.LeftStroke>();
    if (element != null)
      return DMXV.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXV.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.LeftStroke>(), value, diffs, objName);
  }
  
  private static void SetLeftStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.LeftStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.StrokeChildTypeConverter.CreateOpenXmlElement<DXVO.LeftStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TopStroke.
  /// </summary>
  private static DMV.StrokeChildType? GetTopStroke(DXV.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.TopStroke>();
    if (element != null)
      return DMXV.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXV.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.TopStroke>(), value, diffs, objName);
  }
  
  private static void SetTopStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.TopStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.StrokeChildTypeConverter.CreateOpenXmlElement<DXVO.TopStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RightStroke.
  /// </summary>
  private static DMV.StrokeChildType? GetRightStroke(DXV.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.RightStroke>();
    if (element != null)
      return DMXV.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXV.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.RightStroke>(), value, diffs, objName);
  }
  
  private static void SetRightStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.RightStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.StrokeChildTypeConverter.CreateOpenXmlElement<DXVO.RightStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BottomStroke.
  /// </summary>
  private static DMV.StrokeChildType? GetBottomStroke(DXV.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.BottomStroke>();
    if (element != null)
      return DMXV.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXV.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.BottomStroke>(), value, diffs, objName);
  }
  
  private static void SetBottomStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.BottomStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.StrokeChildTypeConverter.CreateOpenXmlElement<DXVO.BottomStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColumnStroke.
  /// </summary>
  private static DMV.StrokeChildType? GetColumnStroke(DXV.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVO.ColumnStroke>();
    if (element != null)
      return DMXV.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColumnStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXV.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVO.ColumnStroke>(), value, diffs, objName);
  }
  
  private static void SetColumnStroke(DXV.Stroke openXmlElement, DMV.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVO.ColumnStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXV.StrokeChildTypeConverter.CreateOpenXmlElement<DXVO.ColumnStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Stroke? CreateModelElement(DXV.Stroke? openXmlElement)
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
  
  public static bool CompareModelElement(DXV.Stroke? openXmlElement, DMV.Stroke? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpOn(openXmlElement, value.On, diffs, objName))
        ok = false;
      if (!CmpWeight(openXmlElement, value.Weight, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpOpacity(openXmlElement, value.Opacity, diffs, objName))
        ok = false;
      if (!CmpLineStyle(openXmlElement, value.LineStyle, diffs, objName))
        ok = false;
      if (!CmpMiterlimit(openXmlElement, value.Miterlimit, diffs, objName))
        ok = false;
      if (!CmpJoinStyle(openXmlElement, value.JoinStyle, diffs, objName))
        ok = false;
      if (!CmpEndCap(openXmlElement, value.EndCap, diffs, objName))
        ok = false;
      if (!CmpDashStyle(openXmlElement, value.DashStyle, diffs, objName))
        ok = false;
      if (!CmpFillType(openXmlElement, value.FillType, diffs, objName))
        ok = false;
      if (!CmpSource(openXmlElement, value.Source, diffs, objName))
        ok = false;
      if (!CmpImageAspect(openXmlElement, value.ImageAspect, diffs, objName))
        ok = false;
      if (!CmpImageSize(openXmlElement, value.ImageSize, diffs, objName))
        ok = false;
      if (!CmpImageAlignShape(openXmlElement, value.ImageAlignShape, diffs, objName))
        ok = false;
      if (!CmpColor2(openXmlElement, value.Color2, diffs, objName))
        ok = false;
      if (!CmpStartArrow(openXmlElement, value.StartArrow, diffs, objName))
        ok = false;
      if (!CmpStartArrowWidth(openXmlElement, value.StartArrowWidth, diffs, objName))
        ok = false;
      if (!CmpStartArrowLength(openXmlElement, value.StartArrowLength, diffs, objName))
        ok = false;
      if (!CmpEndArrow(openXmlElement, value.EndArrow, diffs, objName))
        ok = false;
      if (!CmpEndArrowWidth(openXmlElement, value.EndArrowWidth, diffs, objName))
        ok = false;
      if (!CmpEndArrowLength(openXmlElement, value.EndArrowLength, diffs, objName))
        ok = false;
      if (!CmpHref(openXmlElement, value.Href, diffs, objName))
        ok = false;
      if (!CmpAlternateImageReference(openXmlElement, value.AlternateImageReference, diffs, objName))
        ok = false;
      if (!CmpTitle(openXmlElement, value.Title, diffs, objName))
        ok = false;
      if (!CmpForceDash(openXmlElement, value.ForceDash, diffs, objName))
        ok = false;
      if (!CmpRelationshipId(openXmlElement, value.RelationshipId, diffs, objName))
        ok = false;
      if (!CmpInsetpen(openXmlElement, value.Insetpen, diffs, objName))
        ok = false;
      if (!CmpLeftStroke(openXmlElement, value.LeftStroke, diffs, objName))
        ok = false;
      if (!CmpTopStroke(openXmlElement, value.TopStroke, diffs, objName))
        ok = false;
      if (!CmpRightStroke(openXmlElement, value.RightStroke, diffs, objName))
        ok = false;
      if (!CmpBottomStroke(openXmlElement, value.BottomStroke, diffs, objName))
        ok = false;
      if (!CmpColumnStroke(openXmlElement, value.ColumnStroke, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMV.Stroke value)
    where OpenXmlElementType: DXV.Stroke, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXV.Stroke openXmlElement, DMV.Stroke value)
  {
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
  }
}
