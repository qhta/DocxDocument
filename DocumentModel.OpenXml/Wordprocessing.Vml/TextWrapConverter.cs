namespace DocumentModel.OpenXml.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping.
/// </summary>
public static class TextWrapConverter
{
  /// <summary>
  /// Wrapping type
  /// </summary>
  public static DocumentModel.Wordprocessing.Vml.WrapKind? GetType(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DocumentModel.Wordprocessing.Vml.WrapKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? openXmlElement, DocumentModel.Wordprocessing.Vml.WrapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues, DocumentModel.Wordprocessing.Vml.WrapKind>(value);
  }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  public static DocumentModel.Wordprocessing.Vml.WrapSideKind? GetSide(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DocumentModel.Wordprocessing.Vml.WrapSideKind>(openXmlElement?.Side?.Value);
  }
  
  public static void SetSide(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? openXmlElement, DocumentModel.Wordprocessing.Vml.WrapSideKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Side = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues, DocumentModel.Wordprocessing.Vml.WrapSideKind>(value);
  }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  public static DocumentModel.Wordprocessing.Vml.HorizontalAnchorKind? GetAnchorX(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DocumentModel.Wordprocessing.Vml.HorizontalAnchorKind>(openXmlElement?.AnchorX?.Value);
  }
  
  public static void SetAnchorX(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? openXmlElement, DocumentModel.Wordprocessing.Vml.HorizontalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AnchorX = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues, DocumentModel.Wordprocessing.Vml.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  public static DocumentModel.Wordprocessing.Vml.VerticalAnchorKind? GetAnchorY(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DocumentModel.Wordprocessing.Vml.VerticalAnchorKind>(openXmlElement?.AnchorY?.Value);
  }
  
  public static void SetAnchorY(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? openXmlElement, DocumentModel.Wordprocessing.Vml.VerticalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AnchorY = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues, DocumentModel.Wordprocessing.Vml.VerticalAnchorKind>(value);
  }
  
}
