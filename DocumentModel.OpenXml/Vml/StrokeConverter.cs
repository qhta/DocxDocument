namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Stroke Class.
/// </summary>
public static class StrokeConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Toggle
  /// </summary>
  private static Boolean? GetOn(DXVml.Stroke openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static bool CmpOn(DXVml.Stroke openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.On?.Value == value) return true;
    diffs?.Add(objName, "On", openXmlElement?.On?.Value, value);
    return false;
  }
  
  private static void SetOn(DXVml.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Stroke Weight
  /// </summary>
  private static String? GetWeight(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Weight);
  }
  
  private static bool CmpWeight(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Weight, value, diffs, objName, "Weight");
  }
  
  private static void SetWeight(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Weight = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Color
  /// </summary>
  private static String? GetColor(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Opacity
  /// </summary>
  private static String? GetOpacity(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Opacity);
  }
  
  private static bool CmpOpacity(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Opacity, value, diffs, objName, "Opacity");
  }
  
  private static void SetOpacity(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Opacity = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Line Style
  /// </summary>
  private static DMVml.StrokeLineStyleKind? GetLineStyle(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMVml.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }
  
  private static bool CmpLineStyle(DXVml.Stroke openXmlElement, DMVml.StrokeLineStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMVml.StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value, value, diffs, objName);
  }
  
  private static void SetLineStyle(DXVml.Stroke openXmlElement, DMVml.StrokeLineStyleKind? value)
  {
    openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues, DMVml.StrokeLineStyleKind>(value);
  }
  
  /// <summary>
  /// Miter Joint Limit
  /// </summary>
  private static String? GetMiterlimit(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Miterlimit);
  }
  
  private static bool CmpMiterlimit(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Miterlimit, value, diffs, objName, "Miterlimit");
  }
  
  private static void SetMiterlimit(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Miterlimit = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Line End Join Style
  /// </summary>
  private static DMVml.StrokeJoinStyleKind? GetJoinStyle(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMVml.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }
  
  private static bool CmpJoinStyle(DXVml.Stroke openXmlElement, DMVml.StrokeJoinStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMVml.StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value, value, diffs, objName);
  }
  
  private static void SetJoinStyle(DXVml.Stroke openXmlElement, DMVml.StrokeJoinStyleKind? value)
  {
    openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues, DMVml.StrokeJoinStyleKind>(value);
  }
  
  /// <summary>
  /// Line End Cap
  /// </summary>
  private static DMVml.StrokeEndCapKind? GetEndCap(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMVml.StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }
  
  private static bool CmpEndCap(DXVml.Stroke openXmlElement, DMVml.StrokeEndCapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMVml.StrokeEndCapKind>(openXmlElement?.EndCap?.Value, value, diffs, objName);
  }
  
  private static void SetEndCap(DXVml.Stroke openXmlElement, DMVml.StrokeEndCapKind? value)
  {
    openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues, DMVml.StrokeEndCapKind>(value);
  }
  
  /// <summary>
  /// Stroke Dash Pattern
  /// </summary>
  private static String? GetDashStyle(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DashStyle);
  }
  
  private static bool CmpDashStyle(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DashStyle, value, diffs, objName, "DashStyle");
  }
  
  private static void SetDashStyle(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.DashStyle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Image Style
  /// </summary>
  private static DMVml.StrokeFillKind? GetFillType(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DMVml.StrokeFillKind>(openXmlElement?.FillType?.Value);
  }
  
  private static bool CmpFillType(DXVml.Stroke openXmlElement, DMVml.StrokeFillKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DMVml.StrokeFillKind>(openXmlElement?.FillType?.Value, value, diffs, objName);
  }
  
  private static void SetFillType(DXVml.Stroke openXmlElement, DMVml.StrokeFillKind? value)
  {
    openXmlElement.FillType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues, DMVml.StrokeFillKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Location
  /// </summary>
  private static String? GetSource(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Source);
  }
  
  private static bool CmpSource(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Source, value, diffs, objName, "Source");
  }
  
  private static void SetSource(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Source = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Image Aspect Ratio
  /// </summary>
  private static DMVml.ImageAspectKind? GetImageAspect(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }
  
  private static bool CmpImageAspect(DXVml.Stroke openXmlElement, DMVml.ImageAspectKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(openXmlElement?.ImageAspect?.Value, value, diffs, objName);
  }
  
  private static void SetImageAspect(DXVml.Stroke openXmlElement, DMVml.ImageAspectKind? value)
  {
    openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues, DMVml.ImageAspectKind>(value);
  }
  
  /// <summary>
  /// Stroke Image Size
  /// </summary>
  private static String? GetImageSize(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageSize);
  }
  
  private static bool CmpImageSize(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageSize, value, diffs, objName, "ImageSize");
  }
  
  private static void SetImageSize(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.ImageSize = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stoke Image Alignment
  /// </summary>
  private static Boolean? GetImageAlignShape(DXVml.Stroke openXmlElement)
  {
    return openXmlElement?.ImageAlignShape?.Value;
  }
  
  private static bool CmpImageAlignShape(DXVml.Stroke openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ImageAlignShape?.Value == value) return true;
    diffs?.Add(objName, "ImageAlignShape", openXmlElement?.ImageAlignShape?.Value, value);
    return false;
  }
  
  private static void SetImageAlignShape(DXVml.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ImageAlignShape = value;
    else
      openXmlElement.ImageAlignShape = null;
  }
  
  /// <summary>
  /// Stroke Alternate Pattern Color
  /// </summary>
  private static String? GetColor2(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color2);
  }
  
  private static bool CmpColor2(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color2, value, diffs, objName, "Color2");
  }
  
  private static void SetColor2(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Color2 = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead
  /// </summary>
  private static DMVml.StrokeArrowKind? GetStartArrow(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }
  
  private static bool CmpStartArrow(DXVml.Stroke openXmlElement, DMVml.StrokeArrowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(openXmlElement?.StartArrow?.Value, value, diffs, objName);
  }
  
  private static void SetStartArrow(DXVml.Stroke openXmlElement, DMVml.StrokeArrowKind? value)
  {
    openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Width
  /// </summary>
  private static DMVml.StrokeArrowWidthKind? GetStartArrowWidth(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }
  
  private static bool CmpStartArrowWidth(DXVml.Stroke openXmlElement, DMVml.StrokeArrowWidthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value, value, diffs, objName);
  }
  
  private static void SetStartArrowWidth(DXVml.Stroke openXmlElement, DMVml.StrokeArrowWidthKind? value)
  {
    openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line Start Arrowhead Length
  /// </summary>
  private static DMVml.StrokeArrowLengthKind? GetStartArrowLength(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }
  
  private static bool CmpStartArrowLength(DXVml.Stroke openXmlElement, DMVml.StrokeArrowLengthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value, value, diffs, objName);
  }
  
  private static void SetStartArrowLength(DXVml.Stroke openXmlElement, DMVml.StrokeArrowLengthKind? value)
  {
    openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead
  /// </summary>
  private static DMVml.StrokeArrowKind? GetEndArrow(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }
  
  private static bool CmpEndArrow(DXVml.Stroke openXmlElement, DMVml.StrokeArrowKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(openXmlElement?.EndArrow?.Value, value, diffs, objName);
  }
  
  private static void SetEndArrow(DXVml.Stroke openXmlElement, DMVml.StrokeArrowKind? value)
  {
    openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues, DMVml.StrokeArrowKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Width
  /// </summary>
  private static DMVml.StrokeArrowWidthKind? GetEndArrowWidth(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }
  
  private static bool CmpEndArrowWidth(DXVml.Stroke openXmlElement, DMVml.StrokeArrowWidthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value, value, diffs, objName);
  }
  
  private static void SetEndArrowWidth(DXVml.Stroke openXmlElement, DMVml.StrokeArrowWidthKind? value)
  {
    openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues, DMVml.StrokeArrowWidthKind>(value);
  }
  
  /// <summary>
  /// Line End Arrowhead Length
  /// </summary>
  private static DMVml.StrokeArrowLengthKind? GetEndArrowLength(DXVml.Stroke openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }
  
  private static bool CmpEndArrowLength(DXVml.Stroke openXmlElement, DMVml.StrokeArrowLengthKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value, value, diffs, objName);
  }
  
  private static void SetEndArrowLength(DXVml.Stroke openXmlElement, DMVml.StrokeArrowLengthKind? value)
  {
    openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues, DMVml.StrokeArrowLengthKind>(value);
  }
  
  /// <summary>
  /// Original Image Reference
  /// </summary>
  private static String? GetHref(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Href);
  }
  
  private static bool CmpHref(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Href, value, diffs, objName, "Href");
  }
  
  private static void SetHref(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Href = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Alternate Image Reference
  /// </summary>
  private static String? GetAlternateImageReference(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.AlternateImageReference);
  }
  
  private static bool CmpAlternateImageReference(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.AlternateImageReference, value, diffs, objName, "AlternateImageReference");
  }
  
  private static void SetAlternateImageReference(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.AlternateImageReference = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Stroke Title
  /// </summary>
  private static String? GetTitle(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Title);
  }
  
  private static bool CmpTitle(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Title, value, diffs, objName, "Title");
  }
  
  private static void SetTitle(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.Title = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Force Dashed Outline
  /// </summary>
  private static Boolean? GetForceDash(DXVml.Stroke openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }
  
  private static bool CmpForceDash(DXVml.Stroke openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ForceDash?.Value == value) return true;
    diffs?.Add(objName, "ForceDash", openXmlElement?.ForceDash?.Value, value);
    return false;
  }
  
  private static void SetForceDash(DXVml.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ForceDash = value;
    else
      openXmlElement.ForceDash = null;
  }
  
  /// <summary>
  /// Relationship
  /// </summary>
  private static String? GetRelationshipId(DXVml.Stroke openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.RelationshipId);
  }
  
  private static bool CmpRelationshipId(DXVml.Stroke openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.RelationshipId, value, diffs, objName, "RelationshipId");
  }
  
  private static void SetRelationshipId(DXVml.Stroke openXmlElement, String? value)
  {
    openXmlElement.RelationshipId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Inset Border From Path
  /// </summary>
  private static Boolean? GetInsetpen(DXVml.Stroke openXmlElement)
  {
    return openXmlElement?.Insetpen?.Value;
  }
  
  private static bool CmpInsetpen(DXVml.Stroke openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Insetpen?.Value == value) return true;
    diffs?.Add(objName, "Insetpen", openXmlElement?.Insetpen?.Value, value);
    return false;
  }
  
  private static void SetInsetpen(DXVml.Stroke openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Insetpen = value;
    else
      openXmlElement.Insetpen = null;
  }
  
  /// <summary>
  /// LeftStroke.
  /// </summary>
  private static DMVml.StrokeChildType? GetLeftStroke(DXVml.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.LeftStroke>();
    if (element != null)
      return DMXVml.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLeftStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.LeftStroke>(), value, diffs, objName);
  }
  
  private static void SetLeftStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.LeftStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.StrokeChildTypeConverter.CreateOpenXmlElement<DXVmlO.LeftStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TopStroke.
  /// </summary>
  private static DMVml.StrokeChildType? GetTopStroke(DXVml.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.TopStroke>();
    if (element != null)
      return DMXVml.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.TopStroke>(), value, diffs, objName);
  }
  
  private static void SetTopStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.TopStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.StrokeChildTypeConverter.CreateOpenXmlElement<DXVmlO.TopStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RightStroke.
  /// </summary>
  private static DMVml.StrokeChildType? GetRightStroke(DXVml.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.RightStroke>();
    if (element != null)
      return DMXVml.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRightStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.RightStroke>(), value, diffs, objName);
  }
  
  private static void SetRightStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.RightStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.StrokeChildTypeConverter.CreateOpenXmlElement<DXVmlO.RightStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BottomStroke.
  /// </summary>
  private static DMVml.StrokeChildType? GetBottomStroke(DXVml.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.BottomStroke>();
    if (element != null)
      return DMXVml.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.BottomStroke>(), value, diffs, objName);
  }
  
  private static void SetBottomStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.BottomStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.StrokeChildTypeConverter.CreateOpenXmlElement<DXVmlO.BottomStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ColumnStroke.
  /// </summary>
  private static DMVml.StrokeChildType? GetColumnStroke(DXVml.Stroke openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVmlO.ColumnStroke>();
    if (element != null)
      return DMXVml.StrokeChildTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColumnStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value, DiffList? diffs, string? objName)
  {
    return DMXVml.StrokeChildTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVmlO.ColumnStroke>(), value, diffs, objName);
  }
  
  private static void SetColumnStroke(DXVml.Stroke openXmlElement, DMVml.StrokeChildType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVmlO.ColumnStroke>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.StrokeChildTypeConverter.CreateOpenXmlElement<DXVmlO.ColumnStroke>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Vml.Stroke? CreateModelElement(DXVml.Stroke? openXmlElement)
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
  
  public static bool CompareModelElement(DXVml.Stroke? openXmlElement, DMVml.Stroke? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMVml.Stroke value)
    where OpenXmlElementType: DXVml.Stroke, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXVml.Stroke openXmlElement, DMVml.Stroke value)
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
