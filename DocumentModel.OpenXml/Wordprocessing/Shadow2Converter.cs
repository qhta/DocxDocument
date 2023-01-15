using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using RgbColorModelHex = DocumentModel.Wordprocessing.RgbColorModelHex;
using SchemeColor = DocumentModel.Wordprocessing.SchemeColor;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Shadow Class.
/// </summary>
public static class Shadow2Converter
{
  /// <summary>
  ///   blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetBlurRadius(Shadow? openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }

  public static void SetBlurRadius(Shadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlurRadius = value;
  }

  /// <summary>
  ///   dist, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetDistanceFromText(Shadow? openXmlElement)
  {
    return openXmlElement?.DistanceFromText?.Value;
  }

  public static void SetDistanceFromText(Shadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromText = value;
  }

  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetDirectionAngle(Shadow? openXmlElement)
  {
    return openXmlElement?.DirectionAngle?.Value;
  }

  public static void SetDirectionAngle(Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DirectionAngle = value;
  }

  /// <summary>
  ///   sx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalScalingFactor(Shadow? openXmlElement)
  {
    return openXmlElement?.HorizontalScalingFactor?.Value;
  }

  public static void SetHorizontalScalingFactor(Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalScalingFactor = value;
  }

  /// <summary>
  ///   sy, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalScalingFactor(Shadow? openXmlElement)
  {
    return openXmlElement?.VerticalScalingFactor?.Value;
  }

  public static void SetVerticalScalingFactor(Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalScalingFactor = value;
  }

  /// <summary>
  ///   kx, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetHorizontalSkewAngle(Shadow? openXmlElement)
  {
    return openXmlElement?.HorizontalSkewAngle?.Value;
  }

  public static void SetHorizontalSkewAngle(Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkewAngle = value;
  }

  /// <summary>
  ///   ky, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetVerticalSkewAngle(Shadow? openXmlElement)
  {
    return openXmlElement?.VerticalSkewAngle?.Value;
  }

  public static void SetVerticalSkewAngle(Shadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkewAngle = value;
  }

  /// <summary>
  ///   algn, this property is only available in Office 2010 and later.
  /// </summary>
  public static RectangleAlignmentKind? GetAlignment(Shadow? openXmlElement)
  {
    return EnumValueConverter.GetValue<RectangleAlignmentValues, RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(Shadow? openXmlElement, RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<RectangleAlignmentValues, RectangleAlignmentKind>(value);
  }

  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  public static RgbColorModelHex? GetRgbColorModelHex(Shadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
    if (itemElement != null)
      return RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelHex(Shadow? openXmlElement, RgbColorModelHex? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SchemeColor.
  /// </summary>
  public static SchemeColor? GetSchemeColor(Shadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
    if (itemElement != null)
      return SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSchemeColor(Shadow? openXmlElement, SchemeColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SchemeColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SchemeColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shadow2? CreateModelElement(Shadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Shadow2();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.DistanceFromText = GetDistanceFromText(openXmlElement);
      value.DirectionAngle = GetDirectionAngle(openXmlElement);
      value.HorizontalScalingFactor = GetHorizontalScalingFactor(openXmlElement);
      value.VerticalScalingFactor = GetVerticalScalingFactor(openXmlElement);
      value.HorizontalSkewAngle = GetHorizontalSkewAngle(openXmlElement);
      value.VerticalSkewAngle = GetVerticalSkewAngle(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Shadow2? value)
    where OpenXmlElementType : Shadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetDistanceFromText(openXmlElement, value?.DistanceFromText);
      SetDirectionAngle(openXmlElement, value?.DirectionAngle);
      SetHorizontalScalingFactor(openXmlElement, value?.HorizontalScalingFactor);
      SetVerticalScalingFactor(openXmlElement, value?.VerticalScalingFactor);
      SetHorizontalSkewAngle(openXmlElement, value?.HorizontalSkewAngle);
      SetVerticalSkewAngle(openXmlElement, value?.VerticalSkewAngle);
      SetAlignment(openXmlElement, value?.Alignment);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      return openXmlElement;
    }
    return default;
  }
}