namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping.
/// </summary>
public static class TextWrapConverter
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  private static DMWVml.WrapKind? GetType(DXVmlW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DMWVml.WrapKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXVmlW.TextWrap openXmlElement, DMWVml.WrapKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DMWVml.WrapKind>(value);
  }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  private static DMWVml.WrapSideKind? GetSide(DXVmlW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DMWVml.WrapSideKind>(openXmlElement?.Side?.Value);
  }
  
  private static void SetSide(DXVmlW.TextWrap openXmlElement, DMWVml.WrapSideKind? value)
  {
    openXmlElement.Side = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DMWVml.WrapSideKind>(value);
  }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  private static DMWVml.HorizontalAnchorKind? GetAnchorX(DXVmlW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DMWVml.HorizontalAnchorKind>(openXmlElement?.AnchorX?.Value);
  }
  
  private static void SetAnchorX(DXVmlW.TextWrap openXmlElement, DMWVml.HorizontalAnchorKind? value)
  {
    openXmlElement.AnchorX = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DMWVml.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  private static DMWVml.VerticalAnchorKind? GetAnchorY(DXVmlW.TextWrap openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DMWVml.VerticalAnchorKind>(openXmlElement?.AnchorY?.Value);
  }
  
  private static void SetAnchorY(DXVmlW.TextWrap openXmlElement, DMWVml.VerticalAnchorKind? value)
  {
    openXmlElement.AnchorY = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DMWVml.VerticalAnchorKind>(value);
  }
  
  public static DMWVml.TextWrap? CreateModelElement(DXVmlW.TextWrap? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWVml.TextWrap();
      value.Type = GetType(openXmlElement);
      value.Side = GetSide(openXmlElement);
      value.AnchorX = GetAnchorX(openXmlElement);
      value.AnchorY = GetAnchorY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWVml.TextWrap? value)
    where OpenXmlElementType: DXVmlW.TextWrap, new()
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
