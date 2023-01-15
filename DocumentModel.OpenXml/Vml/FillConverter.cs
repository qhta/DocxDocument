using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using Fill = DocumentFormat.OpenXml.Vml.Fill;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the Fill Class.
/// </summary>
public static class FillConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(Fill? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Fill Type
  /// </summary>
  public static FillKind? GetType(Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<FillTypeValues, FillKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(Fill? openXmlElement, FillKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<FillTypeValues, FillKind>(value);
  }

  /// <summary>
  ///   Fill Toggle
  /// </summary>
  public static Boolean? GetOn(Fill? openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }

  public static void SetOn(Fill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.On = value;
      else
        openXmlElement.On = null;
  }

  /// <summary>
  ///   Primary Color
  /// </summary>
  public static String? GetColor(Fill? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }

  public static void SetColor(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }

  /// <summary>
  ///   Primary Color Opacity
  /// </summary>
  public static String? GetOpacity(Fill? openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }

  public static void SetOpacity(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Opacity = new StringValue { Value = value };
      else
        openXmlElement.Opacity = null;
  }

  /// <summary>
  ///   Secondary Color
  /// </summary>
  public static String? GetColor2(Fill? openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }

  public static void SetColor2(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color2 = new StringValue { Value = value };
      else
        openXmlElement.Color2 = null;
  }

  /// <summary>
  ///   Fill Image Source
  /// </summary>
  public static String? GetSource(Fill? openXmlElement)
  {
    return openXmlElement?.Source?.Value;
  }

  public static void SetSource(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Source = new StringValue { Value = value };
      else
        openXmlElement.Source = null;
  }

  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public static String? GetHref(Fill? openXmlElement)
  {
    return openXmlElement?.Href?.Value;
  }

  public static void SetHref(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Href = new StringValue { Value = value };
      else
        openXmlElement.Href = null;
  }

  /// <summary>
  ///   Alternate Image Reference Location
  /// </summary>
  public static String? GetAlternateImageReference(Fill? openXmlElement)
  {
    return openXmlElement?.AlternateImageReference?.Value;
  }

  public static void SetAlternateImageReference(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlternateImageReference = new StringValue { Value = value };
      else
        openXmlElement.AlternateImageReference = null;
  }

  /// <summary>
  ///   Fill Image Size
  /// </summary>
  public static String? GetSize(Fill? openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }

  public static void SetSize(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Size = new StringValue { Value = value };
      else
        openXmlElement.Size = null;
  }

  /// <summary>
  ///   Fill Image Origin
  /// </summary>
  public static String? GetOrigin(Fill? openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }

  public static void SetOrigin(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Origin = new StringValue { Value = value };
      else
        openXmlElement.Origin = null;
  }

  /// <summary>
  ///   Fill Image Position
  /// </summary>
  public static String? GetPosition(Fill? openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }

  public static void SetPosition(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Position = new StringValue { Value = value };
      else
        openXmlElement.Position = null;
  }

  /// <summary>
  ///   Image Aspect Ratio
  /// </summary>
  public static ImageAspectKind? GetAspect(Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<ImageAspectValues, ImageAspectKind>(openXmlElement?.Aspect?.Value);
  }

  public static void SetAspect(Fill? openXmlElement, ImageAspectKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Aspect = EnumValueConverter.CreateEnumValue<ImageAspectValues, ImageAspectKind>(value);
  }

  /// <summary>
  ///   Intermediate Colors
  /// </summary>
  public static String? GetColors(Fill? openXmlElement)
  {
    return openXmlElement?.Colors?.Value;
  }

  public static void SetColors(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Colors = new StringValue { Value = value };
      else
        openXmlElement.Colors = null;
  }

  /// <summary>
  ///   Gradient Angle
  /// </summary>
  public static Decimal? GetAngle(Fill? openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }

  public static void SetAngle(Fill? openXmlElement, Decimal? value)
  {
    if (openXmlElement != null)
      openXmlElement.Angle = value;
  }

  /// <summary>
  ///   Align Image With Shape
  /// </summary>
  public static Boolean? GetAlignShape(Fill? openXmlElement)
  {
    return openXmlElement?.AlignShape?.Value;
  }

  public static void SetAlignShape(Fill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlignShape = value;
      else
        openXmlElement.AlignShape = null;
  }

  /// <summary>
  ///   Gradient Center
  /// </summary>
  public static String? GetFocus(Fill? openXmlElement)
  {
    return openXmlElement?.Focus?.Value;
  }

  public static void SetFocus(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Focus = new StringValue { Value = value };
      else
        openXmlElement.Focus = null;
  }

  /// <summary>
  ///   Radial Gradient Size
  /// </summary>
  public static String? GetFocusSize(Fill? openXmlElement)
  {
    return openXmlElement?.FocusSize?.Value;
  }

  public static void SetFocusSize(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FocusSize = new StringValue { Value = value };
      else
        openXmlElement.FocusSize = null;
  }

  /// <summary>
  ///   Radial Gradient Center
  /// </summary>
  public static String? GetFocusPosition(Fill? openXmlElement)
  {
    return openXmlElement?.FocusPosition?.Value;
  }

  public static void SetFocusPosition(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FocusPosition = new StringValue { Value = value };
      else
        openXmlElement.FocusPosition = null;
  }

  /// <summary>
  ///   Gradient Fill Method
  /// </summary>
  public static FillMethodKind? GetMethod(Fill? openXmlElement)
  {
    return EnumValueConverter.GetValue<FillMethodValues, FillMethodKind>(openXmlElement?.Method?.Value);
  }

  public static void SetMethod(Fill? openXmlElement, FillMethodKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Method = EnumValueConverter.CreateEnumValue<FillMethodValues, FillMethodKind>(value);
  }

  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  public static Boolean? GetDetectMouseClick(Fill? openXmlElement)
  {
    return openXmlElement?.DetectMouseClick?.Value;
  }

  public static void SetDetectMouseClick(Fill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DetectMouseClick = value;
      else
        openXmlElement.DetectMouseClick = null;
  }

  /// <summary>
  ///   Title
  /// </summary>
  public static String? GetTitle(Fill? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }

  public static void SetTitle(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }

  /// <summary>
  ///   Secondary Color Opacity
  /// </summary>
  public static String? GetOpacity2(Fill? openXmlElement)
  {
    return openXmlElement?.Opacity2?.Value;
  }

  public static void SetOpacity2(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Opacity2 = new StringValue { Value = value };
      else
        openXmlElement.Opacity2 = null;
  }

  /// <summary>
  ///   Recolor Fill as Picture
  /// </summary>
  public static Boolean? GetRecolor(Fill? openXmlElement)
  {
    return openXmlElement?.Recolor?.Value;
  }

  public static void SetRecolor(Fill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Recolor = value;
      else
        openXmlElement.Recolor = null;
  }

  /// <summary>
  ///   Rotate Fill with Shape
  /// </summary>
  public static Boolean? GetRotate(Fill? openXmlElement)
  {
    return openXmlElement?.Rotate?.Value;
  }

  public static void SetRotate(Fill? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Rotate = value;
      else
        openXmlElement.Rotate = null;
  }

  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public static String? GetRelationshipId(Fill? openXmlElement)
  {
    return openXmlElement?.RelationshipId?.Value;
  }

  public static void SetRelationshipId(Fill? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RelationshipId = new StringValue { Value = value };
      else
        openXmlElement.RelationshipId = null;
  }

  /// <summary>
  ///   FillExtendedProperties.
  /// </summary>
  public static FillExtendedProperties? GetFillExtendedProperties(Fill? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
    if (itemElement != null)
      return FillExtendedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillExtendedProperties(Fill? openXmlElement, FillExtendedProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillExtendedPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.Fill? CreateModelElement(Fill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Fill();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Opacity = GetOpacity(openXmlElement);
      value.Color2 = GetColor2(openXmlElement);
      value.Source = GetSource(openXmlElement);
      value.Href = GetHref(openXmlElement);
      value.AlternateImageReference = GetAlternateImageReference(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.Origin = GetOrigin(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.Aspect = GetAspect(openXmlElement);
      value.Colors = GetColors(openXmlElement);
      value.Angle = GetAngle(openXmlElement);
      value.AlignShape = GetAlignShape(openXmlElement);
      value.Focus = GetFocus(openXmlElement);
      value.FocusSize = GetFocusSize(openXmlElement);
      value.FocusPosition = GetFocusPosition(openXmlElement);
      value.Method = GetMethod(openXmlElement);
      value.DetectMouseClick = GetDetectMouseClick(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.Opacity2 = GetOpacity2(openXmlElement);
      value.Recolor = GetRecolor(openXmlElement);
      value.Rotate = GetRotate(openXmlElement);
      value.RelationshipId = GetRelationshipId(openXmlElement);
      value.FillExtendedProperties = GetFillExtendedProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Fill? value)
    where OpenXmlElementType : Fill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetType(openXmlElement, value?.Type);
      SetOn(openXmlElement, value?.On);
      SetColor(openXmlElement, value?.Color);
      SetOpacity(openXmlElement, value?.Opacity);
      SetColor2(openXmlElement, value?.Color2);
      SetSource(openXmlElement, value?.Source);
      SetHref(openXmlElement, value?.Href);
      SetAlternateImageReference(openXmlElement, value?.AlternateImageReference);
      SetSize(openXmlElement, value?.Size);
      SetOrigin(openXmlElement, value?.Origin);
      SetPosition(openXmlElement, value?.Position);
      SetAspect(openXmlElement, value?.Aspect);
      SetColors(openXmlElement, value?.Colors);
      SetAngle(openXmlElement, value?.Angle);
      SetAlignShape(openXmlElement, value?.AlignShape);
      SetFocus(openXmlElement, value?.Focus);
      SetFocusSize(openXmlElement, value?.FocusSize);
      SetFocusPosition(openXmlElement, value?.FocusPosition);
      SetMethod(openXmlElement, value?.Method);
      SetDetectMouseClick(openXmlElement, value?.DetectMouseClick);
      SetTitle(openXmlElement, value?.Title);
      SetOpacity2(openXmlElement, value?.Opacity2);
      SetRecolor(openXmlElement, value?.Recolor);
      SetRotate(openXmlElement, value?.Rotate);
      SetRelationshipId(openXmlElement, value?.RelationshipId);
      SetFillExtendedProperties(openXmlElement, value?.FillExtendedProperties);
      return openXmlElement;
    }
    return default;
  }
}