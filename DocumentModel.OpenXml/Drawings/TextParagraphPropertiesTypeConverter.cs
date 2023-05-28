namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextParagraphPropertiesType Class.
/// </summary>
public static class TextParagraphPropertiesTypeConverter
{
  /// <summary>
  /// Left Margin
  /// </summary>
  private static Int32? GetLeftMargin(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.LeftMargin?.Value;
  }
  
  private static bool CmpLeftMargin(DXD.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LeftMargin?.Value == value) return true;
    diffs?.Add(objName, "LeftMargin", openXmlElement?.LeftMargin?.Value, value);
    return false;
  }
  
  private static void SetLeftMargin(DXD.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.LeftMargin = value;
  }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  private static Int32? GetRightMargin(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.RightMargin?.Value;
  }
  
  private static bool CmpRightMargin(DXD.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RightMargin?.Value == value) return true;
    diffs?.Add(objName, "RightMargin", openXmlElement?.RightMargin?.Value, value);
    return false;
  }
  
  private static void SetRightMargin(DXD.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.RightMargin = value;
  }
  
  /// <summary>
  /// Level
  /// </summary>
  private static Int32? GetLevel(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.Level?.Value;
  }
  
  private static bool CmpLevel(DXD.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Level?.Value == value) return true;
    diffs?.Add(objName, "Level", openXmlElement?.Level?.Value, value);
    return false;
  }
  
  private static void SetLevel(DXD.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Level = value;
  }
  
  /// <summary>
  /// Indent
  /// </summary>
  private static Int32? GetIndent(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.Indent?.Value;
  }
  
  private static bool CmpIndent(DXD.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Indent?.Value == value) return true;
    diffs?.Add(objName, "Indent", openXmlElement?.Indent?.Value, value);
    return false;
  }
  
  private static void SetIndent(DXD.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.Indent = value;
  }
  
  /// <summary>
  /// Alignment
  /// </summary>
  private static DMD.TextAlignmentKind? GetAlignment(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues, DMD.TextAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static bool CmpAlignment(DXD.TextParagraphPropertiesType openXmlElement, DMD.TextAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues, DMD.TextAlignmentKind>(openXmlElement?.Alignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXD.TextParagraphPropertiesType openXmlElement, DMD.TextAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextAlignmentTypeValues, DMD.TextAlignmentKind>(value);
  }
  
  /// <summary>
  /// Default Tab Size
  /// </summary>
  private static Int32? GetDefaultTabSize(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.DefaultTabSize?.Value;
  }
  
  private static bool CmpDefaultTabSize(DXD.TextParagraphPropertiesType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DefaultTabSize?.Value == value) return true;
    diffs?.Add(objName, "DefaultTabSize", openXmlElement?.DefaultTabSize?.Value, value);
    return false;
  }
  
  private static void SetDefaultTabSize(DXD.TextParagraphPropertiesType openXmlElement, Int32? value)
  {
    openXmlElement.DefaultTabSize = value;
  }
  
  /// <summary>
  /// Right To Left
  /// </summary>
  private static Boolean? GetRightToLeft(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.RightToLeft?.Value;
  }
  
  private static bool CmpRightToLeft(DXD.TextParagraphPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RightToLeft?.Value == value) return true;
    diffs?.Add(objName, "RightToLeft", openXmlElement?.RightToLeft?.Value, value);
    return false;
  }
  
  private static void SetRightToLeft(DXD.TextParagraphPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RightToLeft = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RightToLeft = null;
  }
  
  /// <summary>
  /// East Asian Line Break
  /// </summary>
  private static Boolean? GetEastAsianLineBreak(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.EastAsianLineBreak?.Value;
  }
  
  private static bool CmpEastAsianLineBreak(DXD.TextParagraphPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.EastAsianLineBreak?.Value == value) return true;
    diffs?.Add(objName, "EastAsianLineBreak", openXmlElement?.EastAsianLineBreak?.Value, value);
    return false;
  }
  
  private static void SetEastAsianLineBreak(DXD.TextParagraphPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EastAsianLineBreak = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.EastAsianLineBreak = null;
  }
  
  /// <summary>
  /// Font Alignment
  /// </summary>
  private static DMD.TextFontAlignmentKind? GetFontAlignment(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues, DMD.TextFontAlignmentKind>(openXmlElement?.FontAlignment?.Value);
  }
  
  private static bool CmpFontAlignment(DXD.TextParagraphPropertiesType openXmlElement, DMD.TextFontAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues, DMD.TextFontAlignmentKind>(openXmlElement?.FontAlignment?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFontAlignment(DXD.TextParagraphPropertiesType openXmlElement, DMD.TextFontAlignmentKind? value)
  {
    openXmlElement.FontAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues, DMD.TextFontAlignmentKind>(value);
  }
  
  /// <summary>
  /// Latin Line Break
  /// </summary>
  private static Boolean? GetLatinLineBreak(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.LatinLineBreak?.Value;
  }
  
  private static bool CmpLatinLineBreak(DXD.TextParagraphPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.LatinLineBreak?.Value == value) return true;
    diffs?.Add(objName, "LatinLineBreak", openXmlElement?.LatinLineBreak?.Value, value);
    return false;
  }
  
  private static void SetLatinLineBreak(DXD.TextParagraphPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LatinLineBreak = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.LatinLineBreak = null;
  }
  
  /// <summary>
  /// Hanging Punctuation
  /// </summary>
  private static Boolean? GetHeight(DXD.TextParagraphPropertiesType openXmlElement)
  {
    return openXmlElement?.Height?.Value;
  }
  
  private static bool CmpHeight(DXD.TextParagraphPropertiesType openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Height?.Value == value) return true;
    diffs?.Add(objName, "Height", openXmlElement?.Height?.Value, value);
    return false;
  }
  
  private static void SetHeight(DXD.TextParagraphPropertiesType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Height = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Height = null;
  }
  
  /// <summary>
  /// Line Spacing.
  /// </summary>
  private static DMD.LineSpacing? GetLineSpacing(DXD.TextParagraphPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LineSpacing>();
    if (element != null)
      return DMXD.LineSpacingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineSpacing(DXD.TextParagraphPropertiesType openXmlElement, DMD.LineSpacing? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LineSpacingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LineSpacing>(), value, diffs, objName, propName);
  }
  
  private static void SetLineSpacing(DXD.TextParagraphPropertiesType openXmlElement, DMD.LineSpacing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LineSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineSpacingConverter.CreateOpenXmlElement<DXD.LineSpacing>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Space Before.
  /// </summary>
  private static DMD.SpaceBefore? GetSpaceBefore(DXD.TextParagraphPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SpaceBefore>();
    if (element != null)
      return DMXD.SpaceBeforeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSpaceBefore(DXD.TextParagraphPropertiesType openXmlElement, DMD.SpaceBefore? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SpaceBeforeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SpaceBefore>(), value, diffs, objName, propName);
  }
  
  private static void SetSpaceBefore(DXD.TextParagraphPropertiesType openXmlElement, DMD.SpaceBefore? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SpaceBefore>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SpaceBeforeConverter.CreateOpenXmlElement<DXD.SpaceBefore>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Space After.
  /// </summary>
  private static DMD.SpaceAfter? GetSpaceAfter(DXD.TextParagraphPropertiesType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SpaceAfter>();
    if (element != null)
      return DMXD.SpaceAfterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSpaceAfter(DXD.TextParagraphPropertiesType openXmlElement, DMD.SpaceAfter? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.SpaceAfterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SpaceAfter>(), value, diffs, objName, propName);
  }
  
  private static void SetSpaceAfter(DXD.TextParagraphPropertiesType openXmlElement, DMD.SpaceAfter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SpaceAfter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SpaceAfterConverter.CreateOpenXmlElement<DXD.SpaceAfter>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.TextParagraphPropertiesType? CreateModelElement(DXD.TextParagraphPropertiesType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.TextParagraphPropertiesType();
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
  
  public static bool CompareModelElement(DXD.TextParagraphPropertiesType? openXmlElement, DMD.TextParagraphPropertiesType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLeftMargin(openXmlElement, value.LeftMargin, diffs, objName, propName))
        ok = false;
      if (!CmpRightMargin(openXmlElement, value.RightMargin, diffs, objName, propName))
        ok = false;
      if (!CmpLevel(openXmlElement, value.Level, diffs, objName, propName))
        ok = false;
      if (!CmpIndent(openXmlElement, value.Indent, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, value.Alignment, diffs, objName, propName))
        ok = false;
      if (!CmpDefaultTabSize(openXmlElement, value.DefaultTabSize, diffs, objName, propName))
        ok = false;
      if (!CmpRightToLeft(openXmlElement, value.RightToLeft, diffs, objName, propName))
        ok = false;
      if (!CmpEastAsianLineBreak(openXmlElement, value.EastAsianLineBreak, diffs, objName, propName))
        ok = false;
      if (!CmpFontAlignment(openXmlElement, value.FontAlignment, diffs, objName, propName))
        ok = false;
      if (!CmpLatinLineBreak(openXmlElement, value.LatinLineBreak, diffs, objName, propName))
        ok = false;
      if (!CmpHeight(openXmlElement, value.Height, diffs, objName, propName))
        ok = false;
      if (!CmpLineSpacing(openXmlElement, value.LineSpacing, diffs, objName, propName))
        ok = false;
      if (!CmpSpaceBefore(openXmlElement, value.SpaceBefore, diffs, objName, propName))
        ok = false;
      if (!CmpSpaceAfter(openXmlElement, value.SpaceAfter, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.TextParagraphPropertiesType value)
    where OpenXmlElementType: DXD.TextParagraphPropertiesType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.TextParagraphPropertiesType openXmlElement, DMD.TextParagraphPropertiesType value)
  {
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
  }
}
