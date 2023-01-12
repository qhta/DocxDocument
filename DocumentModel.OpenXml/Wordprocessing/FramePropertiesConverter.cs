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
    return openXmlElement?.Lines?.Value;
  }
  
  public static void SetLines(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Lines = value;
  }
  
  /// <summary>
  /// Frame Width
  /// </summary>
  public static String? GetWidth(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Width = new StringValue { Value = value };
      else
        openXmlElement.Width = null;
  }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  public static UInt32? GetHeight(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Vertical Frame Padding
  /// </summary>
  public static String? GetVerticalSpace(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return openXmlElement?.VerticalSpace?.Value;
  }
  
  public static void SetVerticalSpace(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VerticalSpace = new StringValue { Value = value };
      else
        openXmlElement.VerticalSpace = null;
  }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  public static String? GetHorizontalSpace(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    return openXmlElement?.HorizontalSpace?.Value;
  }
  
  public static void SetHorizontalSpace(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalSpace = new StringValue { Value = value };
      else
        openXmlElement.HorizontalSpace = null;
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
    return openXmlElement?.X?.Value;
  }
  
  public static void SetX(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.X = new StringValue { Value = value };
      else
        openXmlElement.X = null;
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
    return openXmlElement?.Y?.Value;
  }
  
  public static void SetY(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Y = new StringValue { Value = value };
      else
        openXmlElement.Y = null;
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
    return openXmlElement?.AnchorLock?.Value;
  }
  
  public static void SetAnchorLock(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AnchorLock = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.AnchorLock = null;
  }
  
  public static DocumentModel.Wordprocessing.FrameProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FrameProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FrameProperties();
      value.DropCap = GetDropCap(openXmlElement);
      value.Lines = GetLines(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.VerticalSpace = GetVerticalSpace(openXmlElement);
      value.HorizontalSpace = GetHorizontalSpace(openXmlElement);
      value.Wrap = GetWrap(openXmlElement);
      value.HorizontalPosition = GetHorizontalPosition(openXmlElement);
      value.VerticalPosition = GetVerticalPosition(openXmlElement);
      value.X = GetX(openXmlElement);
      value.XAlign = GetXAlign(openXmlElement);
      value.Y = GetY(openXmlElement);
      value.YAlign = GetYAlign(openXmlElement);
      value.HeightType = GetHeightType(openXmlElement);
      value.AnchorLock = GetAnchorLock(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FrameProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FrameProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDropCap(openXmlElement, value?.DropCap);
      SetLines(openXmlElement, value?.Lines);
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetVerticalSpace(openXmlElement, value?.VerticalSpace);
      SetHorizontalSpace(openXmlElement, value?.HorizontalSpace);
      SetWrap(openXmlElement, value?.Wrap);
      SetHorizontalPosition(openXmlElement, value?.HorizontalPosition);
      SetVerticalPosition(openXmlElement, value?.VerticalPosition);
      SetX(openXmlElement, value?.X);
      SetXAlign(openXmlElement, value?.XAlign);
      SetY(openXmlElement, value?.Y);
      SetYAlign(openXmlElement, value?.YAlign);
      SetHeightType(openXmlElement, value?.HeightType);
      SetAnchorLock(openXmlElement, value?.AnchorLock);
      return openXmlElement;
    }
    return default;
  }
}
