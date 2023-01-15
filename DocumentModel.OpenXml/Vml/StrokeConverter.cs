using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentModel.Vml;
using Stroke = DocumentFormat.OpenXml.Vml.Stroke;
using StrokeChildType = DocumentModel.Vml.StrokeChildType;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the Stroke Class.
/// </summary>
public static class StrokeConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(Stroke? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  public static Boolean? GetOn(Stroke? openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }

  public static void SetOn(Stroke? openXmlElement, Boolean? value)
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
  public static String? GetWeight(Stroke? openXmlElement)
  {
    return openXmlElement?.Weight?.Value;
  }

  public static void SetWeight(Stroke? openXmlElement, String? value)
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
  public static String? GetColor(Stroke? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }

  public static void SetColor(Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }

  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  public static String? GetOpacity(Stroke? openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }

  public static void SetOpacity(Stroke? openXmlElement, String? value)
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
  public static StrokeLineStyleKind? GetLineStyle(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeLineStyleValues, StrokeLineStyleKind>(openXmlElement?.LineStyle?.Value);
  }

  public static void SetLineStyle(Stroke? openXmlElement, StrokeLineStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineStyle = EnumValueConverter.CreateEnumValue<StrokeLineStyleValues, StrokeLineStyleKind>(value);
  }

  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  public static String? GetMiterlimit(Stroke? openXmlElement)
  {
    return openXmlElement?.Miterlimit?.Value;
  }

  public static void SetMiterlimit(Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Miterlimit = new StringValue { Value = value };
      else
        openXmlElement.Miterlimit = null;
  }

  /// <summary>
  ///   Line End Join Style
  /// </summary>
  public static StrokeJoinStyleKind? GetJoinStyle(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeJoinStyleValues, StrokeJoinStyleKind>(openXmlElement?.JoinStyle?.Value);
  }

  public static void SetJoinStyle(Stroke? openXmlElement, StrokeJoinStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.JoinStyle = EnumValueConverter.CreateEnumValue<StrokeJoinStyleValues, StrokeJoinStyleKind>(value);
  }

  /// <summary>
  ///   Line End Cap
  /// </summary>
  public static StrokeEndCapKind? GetEndCap(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeEndCapValues, StrokeEndCapKind>(openXmlElement?.EndCap?.Value);
  }

  public static void SetEndCap(Stroke? openXmlElement, StrokeEndCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndCap = EnumValueConverter.CreateEnumValue<StrokeEndCapValues, StrokeEndCapKind>(value);
  }

  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  public static String? GetDashStyle(Stroke? openXmlElement)
  {
    return openXmlElement?.DashStyle?.Value;
  }

  public static void SetDashStyle(Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DashStyle = new StringValue { Value = value };
      else
        openXmlElement.DashStyle = null;
  }

  /// <summary>
  ///   Stroke Image Style
  /// </summary>
  public static StrokeFillKind? GetFillType(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeFillTypeValues, StrokeFillKind>(openXmlElement?.FillType?.Value);
  }

  public static void SetFillType(Stroke? openXmlElement, StrokeFillKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FillType = EnumValueConverter.CreateEnumValue<StrokeFillTypeValues, StrokeFillKind>(value);
  }

  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  public static String? GetSource(Stroke? openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }

  public static void SetSource(Stroke? openXmlElement, String? value)
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
  public static ImageAspectKind? GetImageAspect(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<ImageAspectValues, ImageAspectKind>(openXmlElement?.ImageAspect?.Value);
  }

  public static void SetImageAspect(Stroke? openXmlElement, ImageAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ImageAspect = EnumValueConverter.CreateEnumValue<ImageAspectValues, ImageAspectKind>(value);
  }

  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  public static String? GetImageSize(Stroke? openXmlElement)
  {
    return openXmlElement?.ImageSize?.Value;
  }

  public static void SetImageSize(Stroke? openXmlElement, String? value)
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
  public static Boolean? GetImageAlignShape(Stroke? openXmlElement)
  {
    return openXmlElement?.ImageAlignShape?.Value;
  }

  public static void SetImageAlignShape(Stroke? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ImageAlignShape = value;
      else
        openXmlElement.ImageAlignShape = null;
  }

  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  public static String? GetColor2(Stroke? openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }

  public static void SetColor2(Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color2 = new StringValue { Value = value };
      else
        openXmlElement.Color2 = null;
  }

  /// <summary>
  ///   Line Start Arrowhead
  /// </summary>
  public static StrokeArrowKind? GetStartArrow(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowValues, StrokeArrowKind>(openXmlElement?.StartArrow?.Value);
  }

  public static void SetStartArrow(Stroke? openXmlElement, StrokeArrowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrow = EnumValueConverter.CreateEnumValue<StrokeArrowValues, StrokeArrowKind>(value);
  }

  /// <summary>
  ///   Line Start Arrowhead Width
  /// </summary>
  public static StrokeArrowWidthKind? GetStartArrowWidth(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowWidthValues, StrokeArrowWidthKind>(openXmlElement?.StartArrowWidth?.Value);
  }

  public static void SetStartArrowWidth(Stroke? openXmlElement, StrokeArrowWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrowWidth = EnumValueConverter.CreateEnumValue<StrokeArrowWidthValues, StrokeArrowWidthKind>(value);
  }

  /// <summary>
  ///   Line Start Arrowhead Length
  /// </summary>
  public static StrokeArrowLengthKind? GetStartArrowLength(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowLengthValues, StrokeArrowLengthKind>(openXmlElement?.StartArrowLength?.Value);
  }

  public static void SetStartArrowLength(Stroke? openXmlElement, StrokeArrowLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartArrowLength = EnumValueConverter.CreateEnumValue<StrokeArrowLengthValues, StrokeArrowLengthKind>(value);
  }

  /// <summary>
  ///   Line End Arrowhead
  /// </summary>
  public static StrokeArrowKind? GetEndArrow(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowValues, StrokeArrowKind>(openXmlElement?.EndArrow?.Value);
  }

  public static void SetEndArrow(Stroke? openXmlElement, StrokeArrowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrow = EnumValueConverter.CreateEnumValue<StrokeArrowValues, StrokeArrowKind>(value);
  }

  /// <summary>
  ///   Line End Arrowhead Width
  /// </summary>
  public static StrokeArrowWidthKind? GetEndArrowWidth(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowWidthValues, StrokeArrowWidthKind>(openXmlElement?.EndArrowWidth?.Value);
  }

  public static void SetEndArrowWidth(Stroke? openXmlElement, StrokeArrowWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrowWidth = EnumValueConverter.CreateEnumValue<StrokeArrowWidthValues, StrokeArrowWidthKind>(value);
  }

  /// <summary>
  ///   Line End Arrowhead Length
  /// </summary>
  public static StrokeArrowLengthKind? GetEndArrowLength(Stroke? openXmlElement)
  {
    return EnumValueConverter.GetValue<StrokeArrowLengthValues, StrokeArrowLengthKind>(openXmlElement?.EndArrowLength?.Value);
  }

  public static void SetEndArrowLength(Stroke? openXmlElement, StrokeArrowLengthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndArrowLength = EnumValueConverter.CreateEnumValue<StrokeArrowLengthValues, StrokeArrowLengthKind>(value);
  }

  /// <summary>
  ///   Original Image Reference
  /// </summary>
  public static String? GetHref(Stroke? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }

  public static void SetHref(Stroke? openXmlElement, String? value)
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
  public static String? GetAlternateImageReference(Stroke? openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }

  public static void SetAlternateImageReference(Stroke? openXmlElement, String? value)
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
  public static String? GetTitle(Stroke? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }

  public static void SetTitle(Stroke? openXmlElement, String? value)
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
  public static Boolean? GetForceDash(Stroke? openXmlElement)
  {
    return openXmlElement?.ForceDash?.Value;
  }

  public static void SetForceDash(Stroke? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ForceDash = value;
      else
        openXmlElement.ForceDash = null;
  }

  /// <summary>
  ///   Relationship
  /// </summary>
  public static String? GetRelationshipId(Stroke? openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }

  public static void SetRelationshipId(Stroke? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelationshipId = new StringValue { Value = value };
      else
        openXmlElement.RelationshipId = null;
  }

  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  public static Boolean? GetInsetpen(Stroke? openXmlElement)
  {
    return openXmlElement?.Insetpen?.Value;
  }

  public static void SetInsetpen(Stroke? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Insetpen = value;
      else
        openXmlElement.Insetpen = null;
  }

  /// <summary>
  ///   LeftStroke.
  /// </summary>
  public static StrokeChildType? GetLeftStroke(Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftStroke>();
    if (itemElement != null)
      return StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLeftStroke(Stroke? openXmlElement, StrokeChildType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrokeChildTypeConverter.CreateOpenXmlElement<LeftStroke>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TopStroke.
  /// </summary>
  public static StrokeChildType? GetTopStroke(Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopStroke>();
    if (itemElement != null)
      return StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopStroke(Stroke? openXmlElement, StrokeChildType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrokeChildTypeConverter.CreateOpenXmlElement<TopStroke>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RightStroke.
  /// </summary>
  public static StrokeChildType? GetRightStroke(Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightStroke>();
    if (itemElement != null)
      return StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRightStroke(Stroke? openXmlElement, StrokeChildType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrokeChildTypeConverter.CreateOpenXmlElement<RightStroke>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   BottomStroke.
  /// </summary>
  public static StrokeChildType? GetBottomStroke(Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomStroke>();
    if (itemElement != null)
      return StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomStroke(Stroke? openXmlElement, StrokeChildType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BottomStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrokeChildTypeConverter.CreateOpenXmlElement<BottomStroke>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ColumnStroke.
  /// </summary>
  public static StrokeChildType? GetColumnStroke(Stroke? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ColumnStroke>();
    if (itemElement != null)
      return StrokeChildTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColumnStroke(Stroke? openXmlElement, StrokeChildType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ColumnStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrokeChildTypeConverter.CreateOpenXmlElement<ColumnStroke>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.Stroke? CreateModelElement(Stroke? openXmlElement)
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
    where OpenXmlElementType : Stroke, new()
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