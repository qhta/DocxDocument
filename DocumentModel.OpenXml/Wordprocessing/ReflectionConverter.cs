using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using Reflection = DocumentFormat.OpenXml.Office2010.Word.Reflection;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Reflection Class.
/// </summary>
public static class ReflectionConverter
{
  /// <summary>
  ///   blurRad, this property is only available in Office 2010 and later.
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
  ///   stA, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetStartingOpacity(Reflection? openXmlElement)
  {
    return openXmlElement?.StartingOpacity?.Value;
  }

  public static void SetStartingOpacity(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.StartingOpacity = value;
  }

  /// <summary>
  ///   stPos, this property is only available in Office 2010 and later.
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
  ///   endA, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetEndingOpacity(Reflection? openXmlElement)
  {
    return openXmlElement?.EndingOpacity?.Value;
  }

  public static void SetEndingOpacity(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.EndingOpacity = value;
  }

  /// <summary>
  ///   endPos, this property is only available in Office 2010 and later.
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
  ///   dist, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetDistanceFromText(Reflection? openXmlElement)
  {
    return openXmlElement?.DistanceFromText?.Value;
  }

  public static void SetDistanceFromText(Reflection? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromText = value;
  }

  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetDirectionAngle(Reflection? openXmlElement)
  {
    return openXmlElement?.DirectionAngle?.Value;
  }

  public static void SetDirectionAngle(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DirectionAngle = value;
  }

  /// <summary>
  ///   fadeDir, this property is only available in Office 2010 and later.
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
  ///   sx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalScalingFactor(Reflection? openXmlElement)
  {
    return openXmlElement?.HorizontalScalingFactor?.Value;
  }

  public static void SetHorizontalScalingFactor(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalScalingFactor = value;
  }

  /// <summary>
  ///   sy, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalScalingFactor(Reflection? openXmlElement)
  {
    return openXmlElement?.VerticalScalingFactor?.Value;
  }

  public static void SetVerticalScalingFactor(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalScalingFactor = value;
  }

  /// <summary>
  ///   kx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalSkewAngle(Reflection? openXmlElement)
  {
    return openXmlElement?.HorizontalSkewAngle?.Value;
  }

  public static void SetHorizontalSkewAngle(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkewAngle = value;
  }

  /// <summary>
  ///   ky, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalSkewAngle(Reflection? openXmlElement)
  {
    return openXmlElement?.VerticalSkewAngle?.Value;
  }

  public static void SetVerticalSkewAngle(Reflection? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkewAngle = value;
  }

  /// <summary>
  ///   algn, this property is only available in Office 2010 and later.
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

  public static DocumentModel.Wordprocessing.Reflection? CreateModelElement(Reflection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Reflection();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.StartingOpacity = GetStartingOpacity(openXmlElement);
      value.StartPosition = GetStartPosition(openXmlElement);
      value.EndingOpacity = GetEndingOpacity(openXmlElement);
      value.EndPosition = GetEndPosition(openXmlElement);
      value.DistanceFromText = GetDistanceFromText(openXmlElement);
      value.DirectionAngle = GetDirectionAngle(openXmlElement);
      value.FadeDirection = GetFadeDirection(openXmlElement);
      value.HorizontalScalingFactor = GetHorizontalScalingFactor(openXmlElement);
      value.VerticalScalingFactor = GetVerticalScalingFactor(openXmlElement);
      value.HorizontalSkewAngle = GetHorizontalSkewAngle(openXmlElement);
      value.VerticalSkewAngle = GetVerticalSkewAngle(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Reflection? value)
    where OpenXmlElementType : Reflection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetStartingOpacity(openXmlElement, value?.StartingOpacity);
      SetStartPosition(openXmlElement, value?.StartPosition);
      SetEndingOpacity(openXmlElement, value?.EndingOpacity);
      SetEndPosition(openXmlElement, value?.EndPosition);
      SetDistanceFromText(openXmlElement, value?.DistanceFromText);
      SetDirectionAngle(openXmlElement, value?.DirectionAngle);
      SetFadeDirection(openXmlElement, value?.FadeDirection);
      SetHorizontalScalingFactor(openXmlElement, value?.HorizontalScalingFactor);
      SetVerticalScalingFactor(openXmlElement, value?.VerticalScalingFactor);
      SetHorizontalSkewAngle(openXmlElement, value?.HorizontalSkewAngle);
      SetVerticalSkewAngle(openXmlElement, value?.VerticalSkewAngle);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}