namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public static class FramePropertiesConverter
{
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  private static DMW.DropCapLocationKind? GetDropCap(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues, DMW.DropCapLocationKind>(openXmlElement?.DropCap?.Value);
  }
  
  private static void SetDropCap(DXW.FrameProperties openXmlElement, DMW.DropCapLocationKind? value)
  {
    openXmlElement.DropCap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues, DMW.DropCapLocationKind>(value);
  }
  
  /// <summary>
  /// Drop Cap Vertical Height in Lines
  /// </summary>
  private static Int32? GetLines(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement.Lines?.Value;
  }
  
  private static void SetLines(DXW.FrameProperties openXmlElement, Int32? value)
  {
    openXmlElement.Lines = value;
  }
  
  /// <summary>
  /// Frame Width
  /// </summary>
  private static String? GetWidth(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static void SetWidth(DXW.FrameProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Width = new StringValue { Value = value };
    else
      openXmlElement.Width = null;
  }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  private static UInt32? GetHeight(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement.Height?.Value;
  }
  
  private static void SetHeight(DXW.FrameProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Height = value;
  }
  
  /// <summary>
  /// Vertical Frame Padding
  /// </summary>
  private static String? GetVerticalSpace(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement?.VerticalSpace?.Value;
  }
  
  private static void SetVerticalSpace(DXW.FrameProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.VerticalSpace = new StringValue { Value = value };
    else
      openXmlElement.VerticalSpace = null;
  }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  private static String? GetHorizontalSpace(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement?.HorizontalSpace?.Value;
  }
  
  private static void SetHorizontalSpace(DXW.FrameProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.HorizontalSpace = new StringValue { Value = value };
    else
      openXmlElement.HorizontalSpace = null;
  }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  private static DMW.TextWrappingKind? GetWrap(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextWrappingValues, DMW.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  private static void SetWrap(DXW.FrameProperties openXmlElement, DMW.TextWrappingKind? value)
  {
    openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TextWrappingValues, DMW.TextWrappingKind>(value);
  }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  private static DMW.HorizontalAnchorKind? GetHorizontalPosition(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DMW.HorizontalAnchorKind>(openXmlElement?.HorizontalPosition?.Value);
  }
  
  private static void SetHorizontalPosition(DXW.FrameProperties openXmlElement, DMW.HorizontalAnchorKind? value)
  {
    openXmlElement.HorizontalPosition = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DMW.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  private static DMW.VerticalAnchorKind? GetVerticalPosition(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DMW.VerticalAnchorKind>(openXmlElement?.VerticalPosition?.Value);
  }
  
  private static void SetVerticalPosition(DXW.FrameProperties openXmlElement, DMW.VerticalAnchorKind? value)
  {
    openXmlElement.VerticalPosition = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DMW.VerticalAnchorKind>(value);
  }
  
  /// <summary>
  /// Absolute Horizontal Position
  /// </summary>
  private static String? GetX(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  private static void SetX(DXW.FrameProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.X = new StringValue { Value = value };
    else
      openXmlElement.X = null;
  }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  private static DMW.HorizontalAlignmentKind? GetXAlign(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(openXmlElement?.XAlign?.Value);
  }
  
  private static void SetXAlign(DXW.FrameProperties openXmlElement, DMW.HorizontalAlignmentKind? value)
  {
    openXmlElement.XAlign = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Vertical Position
  /// </summary>
  private static String? GetY(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  private static void SetY(DXW.FrameProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Y = new StringValue { Value = value };
    else
      openXmlElement.Y = null;
  }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  private static DMW.VerticalAlignmentKind? GetYAlign(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(openXmlElement?.YAlign?.Value);
  }
  
  private static void SetYAlign(DXW.FrameProperties openXmlElement, DMW.VerticalAlignmentKind? value)
  {
    openXmlElement.YAlign = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  private static DMW.HeightRuleKind? GetHeightType(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DMW.HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }
  
  private static void SetHeightType(DXW.FrameProperties openXmlElement, DMW.HeightRuleKind? value)
  {
    openXmlElement.HeightType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DMW.HeightRuleKind>(value);
  }
  
  /// <summary>
  /// Lock Frame Anchor to Paragraph
  /// </summary>
  private static Boolean? GetAnchorLock(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement?.AnchorLock?.Value;
  }
  
  private static void SetAnchorLock(DXW.FrameProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AnchorLock = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.AnchorLock = null;
  }
  
  public static DMW.FrameProperties? CreateModelElement(DXW.FrameProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FrameProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FrameProperties? value)
    where OpenXmlElementType: DXW.FrameProperties, new()
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
