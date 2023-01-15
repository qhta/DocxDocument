using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentModel.Wordprocessing.Vml;
using TextWrap = DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap;

namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
///   Text Wrapping.
/// </summary>
public static class TextWrapConverter
{
  /// <summary>
  ///   Wrapping type
  /// </summary>
  public static WrapKind? GetType(TextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<WrapValues, WrapKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(TextWrap? openXmlElement, WrapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<WrapValues, WrapKind>(value);
  }

  /// <summary>
  ///   Wrapping side
  /// </summary>
  public static WrapSideKind? GetSide(TextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<WrapSideValues, WrapSideKind>(openXmlElement?.Side?.Value);
  }

  public static void SetSide(TextWrap? openXmlElement, WrapSideKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Side = EnumValueConverter.CreateEnumValue<WrapSideValues, WrapSideKind>(value);
  }

  /// <summary>
  ///   Horizontal Positioning Base
  /// </summary>
  public static HorizontalAnchorKind? GetAnchorX(TextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalAnchorValues, HorizontalAnchorKind>(openXmlElement?.AnchorX?.Value);
  }

  public static void SetAnchorX(TextWrap? openXmlElement, HorizontalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AnchorX = EnumValueConverter.CreateEnumValue<HorizontalAnchorValues, HorizontalAnchorKind>(value);
  }

  /// <summary>
  ///   Vertical Positioning Base
  /// </summary>
  public static VerticalAnchorKind? GetAnchorY(TextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<VerticalAnchorValues, VerticalAnchorKind>(openXmlElement?.AnchorY?.Value);
  }

  public static void SetAnchorY(TextWrap? openXmlElement, VerticalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AnchorY = EnumValueConverter.CreateEnumValue<VerticalAnchorValues, VerticalAnchorKind>(value);
  }

  public static DocumentModel.Wordprocessing.Vml.TextWrap? CreateModelElement(TextWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Vml.TextWrap();
      value.Type = GetType(openXmlElement);
      value.Side = GetSide(openXmlElement);
      value.AnchorX = GetAnchorX(openXmlElement);
      value.AnchorY = GetAnchorY(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Vml.TextWrap? value)
    where OpenXmlElementType : TextWrap, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetSide(openXmlElement, value?.Side);
      SetAnchorX(openXmlElement, value?.AnchorX);
      SetAnchorY(openXmlElement, value?.AnchorY);
      return openXmlElement;
    }
    return default;
  }
}