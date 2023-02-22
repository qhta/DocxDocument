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
  
  private static bool CmpDropCap(DXW.FrameProperties openXmlElement, DMW.DropCapLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DropCapLocationValues, DMW.DropCapLocationKind>(openXmlElement?.DropCap?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.Lines?.Value;
  }
  
  private static bool CmpLines(DXW.FrameProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Lines?.Value == value) return true;
    diffs?.Add(objName, "Lines", openXmlElement?.Lines?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.Width);
  }
  
  private static bool CmpWidth(DXW.FrameProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Width, value, diffs, objName, "Width");
  }
  
  private static void SetWidth(DXW.FrameProperties openXmlElement, String? value)
  {
    openXmlElement.Width = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  private static UInt32? GetHeight(DXW.FrameProperties openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXW.FrameProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
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
    return StringValueConverter.GetValue(openXmlElement?.VerticalSpace);
  }
  
  private static bool CmpVerticalSpace(DXW.FrameProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.VerticalSpace, value, diffs, objName, "VerticalSpace");
  }
  
  private static void SetVerticalSpace(DXW.FrameProperties openXmlElement, String? value)
  {
    openXmlElement.VerticalSpace = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  private static String? GetHorizontalSpace(DXW.FrameProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.HorizontalSpace);
  }
  
  private static bool CmpHorizontalSpace(DXW.FrameProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.HorizontalSpace, value, diffs, objName, "HorizontalSpace");
  }
  
  private static void SetHorizontalSpace(DXW.FrameProperties openXmlElement, String? value)
  {
    openXmlElement.HorizontalSpace = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  private static DMW.TextWrappingKind? GetWrap(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextWrappingValues, DMW.TextWrappingKind>(openXmlElement?.Wrap?.Value);
  }
  
  private static bool CmpWrap(DXW.FrameProperties openXmlElement, DMW.TextWrappingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextWrappingValues, DMW.TextWrappingKind>(openXmlElement?.Wrap?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpHorizontalPosition(DXW.FrameProperties openXmlElement, DMW.HorizontalAnchorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DMW.HorizontalAnchorKind>(openXmlElement?.HorizontalPosition?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpVerticalPosition(DXW.FrameProperties openXmlElement, DMW.VerticalAnchorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DMW.VerticalAnchorKind>(openXmlElement?.VerticalPosition?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return StringValueConverter.GetValue(openXmlElement?.X);
  }
  
  private static bool CmpX(DXW.FrameProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.X, value, diffs, objName, "X");
  }
  
  private static void SetX(DXW.FrameProperties openXmlElement, String? value)
  {
    openXmlElement.X = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  private static DMW.HorizontalAlignmentKind? GetXAlign(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(openXmlElement?.XAlign?.Value);
  }
  
  private static bool CmpXAlign(DXW.FrameProperties openXmlElement, DMW.HorizontalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(openXmlElement?.XAlign?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return StringValueConverter.GetValue(openXmlElement?.Y);
  }
  
  private static bool CmpY(DXW.FrameProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Y, value, diffs, objName, "Y");
  }
  
  private static void SetY(DXW.FrameProperties openXmlElement, String? value)
  {
    openXmlElement.Y = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  private static DMW.VerticalAlignmentKind? GetYAlign(DXW.FrameProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(openXmlElement?.YAlign?.Value);
  }
  
  private static bool CmpYAlign(DXW.FrameProperties openXmlElement, DMW.VerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(openXmlElement?.YAlign?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpHeightType(DXW.FrameProperties openXmlElement, DMW.HeightRuleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DMW.HeightRuleKind>(openXmlElement?.HeightType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return BooleanValueConverter.GetValue(openXmlElement?.AnchorLock);
  }
  
  private static bool CmpAnchorLock(DXW.FrameProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.AnchorLock, value, diffs, objName, "AnchorLock");
  }
  
  private static void SetAnchorLock(DXW.FrameProperties openXmlElement, Boolean? value)
  {
    openXmlElement.AnchorLock = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DocumentModel.Wordprocessing.FrameProperties? CreateModelElement(DXW.FrameProperties? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.FrameProperties? openXmlElement, DMW.FrameProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDropCap(openXmlElement, value.DropCap, diffs, objName))
        ok = false;
      if (!CmpLines(openXmlElement, value.Lines, diffs, objName))
        ok = false;
      if (!CmpWidth(openXmlElement, value.Width, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpVerticalSpace(openXmlElement, value.VerticalSpace, diffs, objName))
        ok = false;
      if (!CmpHorizontalSpace(openXmlElement, value.HorizontalSpace, diffs, objName))
        ok = false;
      if (!CmpWrap(openXmlElement, value.Wrap, diffs, objName))
        ok = false;
      if (!CmpHorizontalPosition(openXmlElement, value.HorizontalPosition, diffs, objName))
        ok = false;
      if (!CmpVerticalPosition(openXmlElement, value.VerticalPosition, diffs, objName))
        ok = false;
      if (!CmpX(openXmlElement, value.X, diffs, objName))
        ok = false;
      if (!CmpXAlign(openXmlElement, value.XAlign, diffs, objName))
        ok = false;
      if (!CmpY(openXmlElement, value.Y, diffs, objName))
        ok = false;
      if (!CmpYAlign(openXmlElement, value.YAlign, diffs, objName))
        ok = false;
      if (!CmpHeightType(openXmlElement, value.HeightType, diffs, objName))
        ok = false;
      if (!CmpAnchorLock(openXmlElement, value.AnchorLock, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FrameProperties value)
    where OpenXmlElementType: DXW.FrameProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FrameProperties openXmlElement, DMW.FrameProperties value)
  {
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
    }
  }
