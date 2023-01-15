using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FrameProperties = DocumentFormat.OpenXml.Wordprocessing.FrameProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FrameProperties Class.
/// </summary>
public static class FramePropertiesConverter
{
  /// <summary>
  ///   Drop Cap Frame
  /// </summary>
  public static DropCapLocationKind? GetDropCap(FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DropCapLocationValues, DropCapLocationKind>(openXmlElement?.DropCap?.Value);
  }

  public static void SetDropCap(FrameProperties? openXmlElement, DropCapLocationKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DropCap = EnumValueConverter.CreateEnumValue<DropCapLocationValues, DropCapLocationKind>(value);
  }

  /// <summary>
  ///   Drop Cap Vertical Height in Lines
  /// </summary>
  public static Int32? GetLines(FrameProperties? openXmlElement)
  {
    return openXmlElement?.Lines?.Value;
  }

  public static void SetLines(FrameProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Lines = value;
  }

  /// <summary>
  ///   Frame Width
  /// </summary>
  public static String? GetWidth(FrameProperties? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Width = new StringValue { Value = value };
      else
        openXmlElement.Width = null;
  }

  /// <summary>
  ///   Frame Height
  /// </summary>
  public static UInt32? GetHeight(FrameProperties? openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }

  public static void SetHeight(FrameProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Height = value;
  }

  /// <summary>
  ///   Vertical Frame Padding
  /// </summary>
  public static String? GetVerticalSpace(FrameProperties? openXmlElement)
  {
    return openXmlElement?.VerticalSpace?.Value;
  }

  public static void SetVerticalSpace(FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VerticalSpace = new StringValue { Value = value };
      else
        openXmlElement.VerticalSpace = null;
  }

  /// <summary>
  ///   Horizontal Frame Padding
  /// </summary>
  public static String? GetHorizontalSpace(FrameProperties? openXmlElement)
  {
    return openXmlElement?.HorizontalSpace?.Value;
  }

  public static void SetHorizontalSpace(FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HorizontalSpace = new StringValue { Value = value };
      else
        openXmlElement.HorizontalSpace = null;
  }

  /// <summary>
  ///   Text Wrapping Around Frame
  /// </summary>
  public static TextWrappingKind? GetWrap(FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<TextWrappingValues, TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }

  public static void SetWrap(FrameProperties? openXmlElement, TextWrappingKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Wrap = EnumValueConverter.CreateEnumValue<TextWrappingValues, TextWrappingKind>(value);
  }

  /// <summary>
  ///   Frame Horizontal Positioning Base
  /// </summary>
  public static HorizontalAnchorKind? GetHorizontalPosition(FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalAnchorValues, HorizontalAnchorKind>(openXmlElement?.HorizontalPosition?.Value);
  }

  public static void SetHorizontalPosition(FrameProperties? openXmlElement, HorizontalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalPosition = EnumValueConverter.CreateEnumValue<HorizontalAnchorValues, HorizontalAnchorKind>(value);
  }

  /// <summary>
  ///   Frame Vertical Positioning Base
  /// </summary>
  public static VerticalAnchorKind? GetVerticalPosition(FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<VerticalAnchorValues, VerticalAnchorKind>(openXmlElement?.VerticalPosition?.Value);
  }

  public static void SetVerticalPosition(FrameProperties? openXmlElement, VerticalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalPosition = EnumValueConverter.CreateEnumValue<VerticalAnchorValues, VerticalAnchorKind>(value);
  }

  /// <summary>
  ///   Absolute Horizontal Position
  /// </summary>
  public static String? GetX(FrameProperties? openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }

  public static void SetX(FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.X = new StringValue { Value = value };
      else
        openXmlElement.X = null;
  }

  /// <summary>
  ///   Relative Horizontal Position
  /// </summary>
  public static HorizontalAlignmentKind? GetXAlign(FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<HorizontalAlignmentValues, HorizontalAlignmentKind>(openXmlElement?.XAlign?.Value);
  }

  public static void SetXAlign(FrameProperties? openXmlElement, HorizontalAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.XAlign = EnumValueConverter.CreateEnumValue<HorizontalAlignmentValues, HorizontalAlignmentKind>(value);
  }

  /// <summary>
  ///   Absolute Vertical Position
  /// </summary>
  public static String? GetY(FrameProperties? openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }

  public static void SetY(FrameProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Y = new StringValue { Value = value };
      else
        openXmlElement.Y = null;
  }

  /// <summary>
  ///   Relative Vertical Position
  /// </summary>
  public static VerticalAlignmentKind? GetYAlign(FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<VerticalAlignmentValues, VerticalAlignmentKind>(openXmlElement?.YAlign?.Value);
  }

  public static void SetYAlign(FrameProperties? openXmlElement, VerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.YAlign = EnumValueConverter.CreateEnumValue<VerticalAlignmentValues, VerticalAlignmentKind>(value);
  }

  /// <summary>
  ///   Frame Height Type
  /// </summary>
  public static HeightRuleKind? GetHeightType(FrameProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<HeightRuleValues, HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }

  public static void SetHeightType(FrameProperties? openXmlElement, HeightRuleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HeightType = EnumValueConverter.CreateEnumValue<HeightRuleValues, HeightRuleKind>(value);
  }

  /// <summary>
  ///   Lock Frame Anchor to Paragraph
  /// </summary>
  public static Boolean? GetAnchorLock(FrameProperties? openXmlElement)
  {
    return openXmlElement?.AnchorLock?.Value;
  }

  public static void SetAnchorLock(FrameProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AnchorLock = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.AnchorLock = null;
  }

  public static DocumentModel.Wordprocessing.FrameProperties? CreateModelElement(FrameProperties? openXmlElement)
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
    where OpenXmlElementType : FrameProperties, new()
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