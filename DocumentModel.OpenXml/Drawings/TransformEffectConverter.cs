using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Transform Effect.
/// </summary>
public static class TransformEffectConverter
{
  /// <summary>
  ///   Horizontal Ratio
  /// </summary>
  public static Int32? GetHorizontalRatio(TransformEffect? openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }

  public static void SetHorizontalRatio(TransformEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalRatio = value;
  }

  /// <summary>
  ///   Vertical Ratio
  /// </summary>
  public static Int32? GetVerticalRatio(TransformEffect? openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }

  public static void SetVerticalRatio(TransformEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalRatio = value;
  }

  /// <summary>
  ///   Horizontal Skew
  /// </summary>
  public static Int32? GetHorizontalSkew(TransformEffect? openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }

  public static void SetHorizontalSkew(TransformEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkew = value;
  }

  /// <summary>
  ///   Vertical Skew
  /// </summary>
  public static Int32? GetVerticalSkew(TransformEffect? openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }

  public static void SetVerticalSkew(TransformEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkew = value;
  }

  /// <summary>
  ///   Horizontal Shift
  /// </summary>
  public static Int64? GetHorizontalShift(TransformEffect? openXmlElement)
  {
    return openXmlElement?.HorizontalShift?.Value;
  }

  public static void SetHorizontalShift(TransformEffect? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalShift = value;
  }

  /// <summary>
  ///   Vertical Shift
  /// </summary>
  public static Int64? GetVerticalShift(TransformEffect? openXmlElement)
  {
    return openXmlElement?.VerticalShift?.Value;
  }

  public static void SetVerticalShift(TransformEffect? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalShift = value;
  }

  public static DocumentModel.Drawings.TransformEffect? CreateModelElement(TransformEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TransformEffect();
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.HorizontalShift = GetHorizontalShift(openXmlElement);
      value.VerticalShift = GetVerticalShift(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TransformEffect? value)
    where OpenXmlElementType : TransformEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
      SetVerticalSkew(openXmlElement, value?.VerticalSkew);
      SetHorizontalShift(openXmlElement, value?.HorizontalShift);
      SetVerticalShift(openXmlElement, value?.VerticalShift);
      return openXmlElement;
    }
    return default;
  }
}