using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using Reflection = DocumentFormat.OpenXml.Drawing.Reflection;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Reflection Effect.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  ///   Blur Radius
  /// </summary>
  public static Int64? GetBlurRadius(Reflection? openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }

  public static void SetBlurRadius(Reflection? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlurRadius = value;
  }

  /// <summary>
  ///   Start Opacity
  /// </summary>
  public static Int32? GetStartOpacity(Reflection? openXmlElement)
  {
    return openXmlElement?.StartOpacity?.Value;
  }

  public static void SetStartOpacity(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartOpacity = value;
  }

  /// <summary>
  ///   Start Position
  /// </summary>
  public static Int32? GetStartPosition(Reflection? openXmlElement)
  {
    return openXmlElement?.StartPosition?.Value;
  }

  public static void SetStartPosition(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartPosition = value;
  }

  /// <summary>
  ///   End Alpha
  /// </summary>
  public static Int32? GetEndAlpha(Reflection? openXmlElement)
  {
    return openXmlElement?.EndAlpha?.Value;
  }

  public static void SetEndAlpha(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndAlpha = value;
  }

  /// <summary>
  ///   End Position
  /// </summary>
  public static Int32? GetEndPosition(Reflection? openXmlElement)
  {
    return openXmlElement?.EndPosition?.Value;
  }

  public static void SetEndPosition(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndPosition = value;
  }

  /// <summary>
  ///   Distance
  /// </summary>
  public static Int64? GetDistance(Reflection? openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }

  public static void SetDistance(Reflection? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Distance = value;
  }

  /// <summary>
  ///   Direction
  /// </summary>
  public static Int32? GetDirection(Reflection? openXmlElement)
  {
    return openXmlElement?.Direction?.Value;
  }

  public static void SetDirection(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Direction = value;
  }

  /// <summary>
  ///   Fade Direction
  /// </summary>
  public static Int32? GetFadeDirection(Reflection? openXmlElement)
  {
    return openXmlElement?.FadeDirection?.Value;
  }

  public static void SetFadeDirection(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FadeDirection = value;
  }

  /// <summary>
  ///   Horizontal Ratio
  /// </summary>
  public static Int32? GetHorizontalRatio(Reflection? openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }

  public static void SetHorizontalRatio(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalRatio = value;
  }

  /// <summary>
  ///   Vertical Ratio
  /// </summary>
  public static Int32? GetVerticalRatio(Reflection? openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }

  public static void SetVerticalRatio(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalRatio = value;
  }

  /// <summary>
  ///   Horizontal Skew
  /// </summary>
  public static Int32? GetHorizontalSkew(Reflection? openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }

  public static void SetHorizontalSkew(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkew = value;
  }

  /// <summary>
  ///   Vertical Skew
  /// </summary>
  public static Int32? GetVerticalSkew(Reflection? openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }

  public static void SetVerticalSkew(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkew = value;
  }

  /// <summary>
  ///   Shadow Alignment
  /// </summary>
  public static RectangleAlignmentKind? GetAlignment(Reflection? openXmlElement)
  {
    return EnumValueConverter.GetValue<RectangleAlignmentValues, RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(Reflection? openXmlElement, RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<RectangleAlignmentValues, RectangleAlignmentKind>(value);
  }

  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(Reflection? openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }

  public static void SetRotateWithShape(Reflection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RotateWithShape = null;
  }

  public static DocumentModel.Drawings.Reflection? CreateModelElement(Reflection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Reflection();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.StartOpacity = GetStartOpacity(openXmlElement);
      value.StartPosition = GetStartPosition(openXmlElement);
      value.EndAlpha = GetEndAlpha(openXmlElement);
      value.EndPosition = GetEndPosition(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.FadeDirection = GetFadeDirection(openXmlElement);
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Reflection? value)
    where OpenXmlElementType : Reflection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetStartOpacity(openXmlElement, value?.StartOpacity);
      SetStartPosition(openXmlElement, value?.StartPosition);
      SetEndAlpha(openXmlElement, value?.EndAlpha);
      SetEndPosition(openXmlElement, value?.EndPosition);
      SetDistance(openXmlElement, value?.Distance);
      SetDirection(openXmlElement, value?.Direction);
      SetFadeDirection(openXmlElement, value?.FadeDirection);
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
      SetVerticalSkew(openXmlElement, value?.VerticalSkew);
      SetAlignment(openXmlElement, value?.Alignment);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      return openXmlElement;
    }
    return default;
  }
}