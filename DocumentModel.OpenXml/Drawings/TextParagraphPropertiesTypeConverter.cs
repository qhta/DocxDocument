namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public static class TextParagraphPropertiesTypeConverter
{
  /// <summary>
  /// Left Margin
  /// </summary>
  private static Int32? GetLeftMargin(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement.LeftMargin?.Value;
  }
  
  private static bool CmpLeftMargin(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.LeftMargin?.Value == value;
  }
  
  private static void SetLeftMargin(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.LeftMargin = value;
  }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  private static Int32? GetRightMargin(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement.RightMargin?.Value;
  }
  
  private static bool CmpRightMargin(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.RightMargin?.Value == value;
  }
  
  private static void SetRightMargin(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.RightMargin = value;
  }
  
  /// <summary>
  /// Level
  /// </summary>
  private static Int32? GetLevel(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement.Level?.Value;
  }
  
  private static bool CmpLevel(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Level?.Value == value;
  }
  
  private static void SetLevel(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Level = value;
  }
  
  /// <summary>
  /// Indent
  /// </summary>
  private static Int32? GetIndent(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement.Indent?.Value;
  }
  
  private static bool CmpIndent(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Indent?.Value == value;
  }
  
  private static void SetIndent(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Indent = value;
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  private static DMDraws.TextAlignmentKind? GetAlignment(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues, DMDraws.TextAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.TextAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues, DMDraws.TextAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlignment(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.TextAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues, DMDraws.TextAlignmentKind>(value);
  }
  
  /// <summary>
  /// Default Tab Size
  /// </summary>
  private static Int32? GetDefaultTabSize(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement.DefaultTabSize?.Value;
  }
  
  private static bool CmpDefaultTabSize(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.DefaultTabSize?.Value == value;
  }
  
  private static void SetDefaultTabSize(DXDraw.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.DefaultTabSize = value;
  }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  private static Boolean? GetRightToLeft(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.RightToLeft?.Value;
  }
  
  private static bool CmpRightToLeft(DXDraw.TextParagraphPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RightToLeft?.Value == value;
  }
  
  private static void SetRightToLeft(DXDraw.TextParagraphPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RightToLeft = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RightToLeft = null;
  }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  private static Boolean? GetEastAsianLineBreak(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.EastAsianLineBreak?.Value;
  }
  
  private static bool CmpEastAsianLineBreak(DXDraw.TextParagraphPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.EastAsianLineBreak?.Value == value;
  }
  
  private static void SetEastAsianLineBreak(DXDraw.TextParagraphPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EastAsianLineBreak = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.EastAsianLineBreak = null;
  }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  private static DMDraws.TextFontAlignmentKind? GetFontAlignment(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues, DMDraws.TextFontAlignmentKind>(openXmlElement?.FontAlignment?.Value);
  }
  
  private static bool CmpFontAlignment(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.TextFontAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues, DMDraws.TextFontAlignmentKind>(openXmlElement?.FontAlignment?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontAlignment(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.TextFontAlignmentKind? value)
  {
    openXmlElement.FontAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues, DMDraws.TextFontAlignmentKind>(value);
  }
  
  /// <summary>
  /// Latin Line Break
  /// </summary>
  private static Boolean? GetLatinLineBreak(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.LatinLineBreak?.Value;
  }
  
  private static bool CmpLatinLineBreak(DXDraw.TextParagraphPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LatinLineBreak?.Value == value;
  }
  
  private static void SetLatinLineBreak(DXDraw.TextParagraphPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LatinLineBreak = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LatinLineBreak = null;
  }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  private static Boolean? GetHeight(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXDraw.TextParagraphPropertiesType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Height?.Value == value;
  }
  
  private static void SetHeight(DXDraw.TextParagraphPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Height = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Height = null;
  }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  private static DMDraws.LineSpacing? GetLineSpacing(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return DMXDraws.LineSpacingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.LineSpacing>());
  }
  
  private static bool CmpLineSpacing(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.LineSpacing? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineSpacingConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.LineSpacing>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineSpacing(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.LineSpacing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LineSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineSpacingConverter.CreateOpenXmlElement<DXDraw.LineSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  private static DMDraws.SpaceBefore? GetSpaceBefore(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return DMXDraws.SpaceBeforeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SpaceBefore>());
  }
  
  private static bool CmpSpaceBefore(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.SpaceBefore? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SpaceBeforeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SpaceBefore>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSpaceBefore(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.SpaceBefore? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SpaceBefore>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SpaceBeforeConverter.CreateOpenXmlElement<DXDraw.SpaceBefore>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Space After.
  /// </summary>
  private static DMDraws.SpaceAfter? GetSpaceAfter(DXDraw.TextParagraphPropertiesType openXmlElement)
  {
    return DMXDraws.SpaceAfterConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SpaceAfter>());
  }
  
  private static bool CmpSpaceAfter(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.SpaceAfter? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SpaceAfterConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SpaceAfter>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSpaceAfter(DXDraw.TextParagraphPropertiesType openXmlElement, DMDraws.SpaceAfter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SpaceAfter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SpaceAfterConverter.CreateOpenXmlElement<DXDraw.SpaceAfter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.TextParagraphPropertiesType? CreateModelElement(DXDraw.TextParagraphPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.TextParagraphPropertiesType();
      value.LeftMargin = GetLeftMargin(openXmlElement);
      value.RightMargin = GetRightMargin(openXmlElement);
      value.Level = GetLevel(openXmlElement);
      value.Indent = GetIndent(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.DefaultTabSize = GetDefaultTabSize(openXmlElement);
      value.RightToLeft = GetRightToLeft(openXmlElement);
      value.EastAsianLineBreak = GetEastAsianLineBreak(openXmlElement);
      value.FontAlignment = GetFontAlignment(openXmlElement);
      value.LatinLineBreak = GetLatinLineBreak(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.LineSpacing = GetLineSpacing(openXmlElement);
      value.SpaceBefore = GetSpaceBefore(openXmlElement);
      value.SpaceAfter = GetSpaceAfter(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.TextParagraphPropertiesType? openXmlElement, DMDraws.TextParagraphPropertiesType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeftMargin(openXmlElement, value.LeftMargin, diffs, objName))
        ok = false;
      if (!CmpRightMargin(openXmlElement, value.RightMargin, diffs, objName))
        ok = false;
      if (!CmpLevel(openXmlElement, value.Level, diffs, objName))
        ok = false;
      if (!CmpIndent(openXmlElement, value.Indent, diffs, objName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName))
        ok = false;
      if (!CmpDefaultTabSize(openXmlElement, value.DefaultTabSize, diffs, objName))
        ok = false;
      if (!CmpRightToLeft(openXmlElement, value.RightToLeft, diffs, objName))
        ok = false;
      if (!CmpEastAsianLineBreak(openXmlElement, value.EastAsianLineBreak, diffs, objName))
        ok = false;
      if (!CmpFontAlignment(openXmlElement, value.FontAlignment, diffs, objName))
        ok = false;
      if (!CmpLatinLineBreak(openXmlElement, value.LatinLineBreak, diffs, objName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName))
        ok = false;
      if (!CmpLineSpacing(openXmlElement, value.LineSpacing, diffs, objName))
        ok = false;
      if (!CmpSpaceBefore(openXmlElement, value.SpaceBefore, diffs, objName))
        ok = false;
      if (!CmpSpaceAfter(openXmlElement, value.SpaceAfter, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TextParagraphPropertiesType? value)
    where OpenXmlElementType: DXDraw.TextParagraphPropertiesType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeftMargin(openXmlElement, value?.LeftMargin);
      SetRightMargin(openXmlElement, value?.RightMargin);
      SetLevel(openXmlElement, value?.Level);
      SetIndent(openXmlElement, value?.Indent);
      SetAlignment(openXmlElement, value?.Alignment);
      SetDefaultTabSize(openXmlElement, value?.DefaultTabSize);
      SetRightToLeft(openXmlElement, value?.RightToLeft);
      SetEastAsianLineBreak(openXmlElement, value?.EastAsianLineBreak);
      SetFontAlignment(openXmlElement, value?.FontAlignment);
      SetLatinLineBreak(openXmlElement, value?.LatinLineBreak);
      SetHeight(openXmlElement, value?.Height);
      SetLineSpacing(openXmlElement, value?.LineSpacing);
      SetSpaceBefore(openXmlElement, value?.SpaceBefore);
      SetSpaceAfter(openXmlElement, value?.SpaceAfter);
      return openXmlElement;
    }
    return default;
  }
}
