namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public static class FramePropertiesConverter
{
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  public static DocumentModel.Wordprocessing.DropCapLocationKind? GetDropCap(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues, DocumentModel.Wordprocessing.DropCapLocationKind>(openXmlElement?.DropCap?.Value);
  }
  
  public static void SetDropCap(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, DocumentModel.Wordprocessing.DropCapLocationKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DropCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues, DocumentModel.Wordprocessing.DropCapLocationKind>(value);
  }
  
  /// <summary>
  /// Drop Cap Vertical Height in Lines
  /// </summary>
  public static Int32? GetLines(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLines(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Frame Width
  /// </summary>
  public static String? GetWidth(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  public static UInt32? GetHeight(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Vertical Frame Padding
  /// </summary>
  public static String? GetVerticalSpace(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetVerticalSpace(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  public static String? GetHorizontalSpace(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetHorizontalSpace(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  public static DocumentModel.Wordprocessing.TextWrappingKind? GetWrap(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextWrappingValues, DocumentModel.Wordprocessing.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  public static void SetWrap(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, DocumentModel.Wordprocessing.TextWrappingKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TextWrappingValues, DocumentModel.Wordprocessing.TextWrappingKind>(value);
  }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  public static DocumentModel.Wordprocessing.HorizontalAnchorKind? GetHorizontalPosition(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DocumentModel.Wordprocessing.HorizontalAnchorKind>(openXmlElement?.HorizontalPosition?.Value);
  }
  
  public static void SetHorizontalPosition(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, DocumentModel.Wordprocessing.HorizontalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalPosition = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DocumentModel.Wordprocessing.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  public static DocumentModel.Wordprocessing.VerticalAnchorKind? GetVerticalPosition(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DocumentModel.Wordprocessing.VerticalAnchorKind>(openXmlElement?.VerticalPosition?.Value);
  }
  
  public static void SetVerticalPosition(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalPosition = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DocumentModel.Wordprocessing.VerticalAnchorKind>(value);
  }
  
  /// <summary>
  /// Absolute Horizontal Position
  /// </summary>
  public static String? GetX(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetX(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  public static DocumentModel.Wordprocessing.HorizontalAlignmentKind? GetXAlign(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DocumentModel.Wordprocessing.HorizontalAlignmentKind>(openXmlElement?.XAlign?.Value);
  }
  
  public static void SetXAlign(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, DocumentModel.Wordprocessing.HorizontalAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.XAlign = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DocumentModel.Wordprocessing.HorizontalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Vertical Position
  /// </summary>
  public static String? GetY(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetY(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  public static DocumentModel.Wordprocessing.VerticalAlignmentKind? GetYAlign(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DocumentModel.Wordprocessing.VerticalAlignmentKind>(openXmlElement?.YAlign?.Value);
  }
  
  public static void SetYAlign(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.YAlign = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DocumentModel.Wordprocessing.VerticalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  public static DocumentModel.Wordprocessing.HeightRuleKind? GetHeightType(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DocumentModel.Wordprocessing.HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }
  
  public static void SetHeightType(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, DocumentModel.Wordprocessing.HeightRuleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HeightType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DocumentModel.Wordprocessing.HeightRuleKind>(value);
  }
  
  /// <summary>
  /// Lock Frame Anchor to Paragraph
  /// </summary>
  public static Boolean? GetAnchorLock(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAnchorLock(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
