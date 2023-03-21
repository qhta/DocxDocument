namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Suggested Filtering for List of Document Styles.
/// </summary>
public static class StylePaneFormatFilterConverter
{
  /// <summary>
  /// val
  /// </summary>
  private static DM.HexChar? GetVal(DXW.StylePaneFormatFilter openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.Val.Value);
    return null;
  }
  
  private static bool CmpVal(DXW.StylePaneFormatFilter openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.Val.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.Val?.Value == null && value is null) return true;
    diffs?.Add(objName, "Normal", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXW.StylePaneFormatFilter openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.Val = value.ToString();
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetAllStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.AllStyles);
  }
  
  private static bool CmpAllStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.AllStyles, value, diffs, objName, "AllStyles");
  }
  
  private static void SetAllStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.AllStyles = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetCustomStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.CustomStyles);
  }
  
  private static bool CmpCustomStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.CustomStyles, value, diffs, objName, "CustomStyles");
  }
  
  private static void SetCustomStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.CustomStyles = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLatentStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LatentStyles);
  }
  
  private static bool CmpLatentStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LatentStyles, value, diffs, objName, "LatentStyles");
  }
  
  private static void SetLatentStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.LatentStyles = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetStylesInUse(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.StylesInUse);
  }
  
  private static bool CmpStylesInUse(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.StylesInUse, value, diffs, objName, "StylesInUse");
  }
  
  private static void SetStylesInUse(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.StylesInUse = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetHeadingStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.HeadingStyles);
  }
  
  private static bool CmpHeadingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.HeadingStyles, value, diffs, objName, "HeadingStyles");
  }
  
  private static void SetHeadingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.HeadingStyles = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNumberingStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.NumberingStyles);
  }
  
  private static bool CmpNumberingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.NumberingStyles, value, diffs, objName, "NumberingStyles");
  }
  
  private static void SetNumberingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.NumberingStyles = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetTableStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.TableStyles);
  }
  
  private static bool CmpTableStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.TableStyles, value, diffs, objName, "TableStyles");
  }
  
  private static void SetTableStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.TableStyles = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnRuns(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DirectFormattingOnRuns);
  }
  
  private static bool CmpDirectFormattingOnRuns(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DirectFormattingOnRuns, value, diffs, objName, "DirectFormattingOnRuns");
  }
  
  private static void SetDirectFormattingOnRuns(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.DirectFormattingOnRuns = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnParagraphs(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DirectFormattingOnParagraphs);
  }
  
  private static bool CmpDirectFormattingOnParagraphs(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DirectFormattingOnParagraphs, value, diffs, objName, "DirectFormattingOnParagraphs");
  }
  
  private static void SetDirectFormattingOnParagraphs(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.DirectFormattingOnParagraphs = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnNumbering(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DirectFormattingOnNumbering);
  }
  
  private static bool CmpDirectFormattingOnNumbering(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DirectFormattingOnNumbering, value, diffs, objName, "DirectFormattingOnNumbering");
  }
  
  private static void SetDirectFormattingOnNumbering(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.DirectFormattingOnNumbering = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnTables(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.DirectFormattingOnTables);
  }
  
  private static bool CmpDirectFormattingOnTables(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.DirectFormattingOnTables, value, diffs, objName, "DirectFormattingOnTables");
  }
  
  private static void SetDirectFormattingOnTables(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.DirectFormattingOnTables = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetClearFormatting(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.ClearFormatting);
  }
  
  private static bool CmpClearFormatting(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.ClearFormatting, value, diffs, objName, "ClearFormatting");
  }
  
  private static void SetClearFormatting(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.ClearFormatting = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetTop3HeadingStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Top3HeadingStyles);
  }
  
  private static bool CmpTop3HeadingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Top3HeadingStyles, value, diffs, objName, "Top3HeadingStyles");
  }
  
  private static void SetTop3HeadingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.Top3HeadingStyles = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisibleStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.VisibleStyles);
  }
  
  private static bool CmpVisibleStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.VisibleStyles, value, diffs, objName, "VisibleStyles");
  }
  
  private static void SetVisibleStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.VisibleStyles = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetAlternateStyleNames(DXW.StylePaneFormatFilter openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.AlternateStyleNames);
  }
  
  private static bool CmpAlternateStyleNames(DXW.StylePaneFormatFilter openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.AlternateStyleNames, value, diffs, objName, "AlternateStyleNames");
  }
  
  private static void SetAlternateStyleNames(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    openXmlElement.AlternateStyleNames = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.StylePaneFormatFilter? CreateModelElement(DXW.StylePaneFormatFilter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StylePaneFormatFilter();
      value.Val = GetVal(openXmlElement);
      value.AllStyles = GetAllStyles(openXmlElement);
      value.CustomStyles = GetCustomStyles(openXmlElement);
      value.LatentStyles = GetLatentStyles(openXmlElement);
      value.StylesInUse = GetStylesInUse(openXmlElement);
      value.HeadingStyles = GetHeadingStyles(openXmlElement);
      value.NumberingStyles = GetNumberingStyles(openXmlElement);
      value.TableStyles = GetTableStyles(openXmlElement);
      value.DirectFormattingOnRuns = GetDirectFormattingOnRuns(openXmlElement);
      value.DirectFormattingOnParagraphs = GetDirectFormattingOnParagraphs(openXmlElement);
      value.DirectFormattingOnNumbering = GetDirectFormattingOnNumbering(openXmlElement);
      value.DirectFormattingOnTables = GetDirectFormattingOnTables(openXmlElement);
      value.ClearFormatting = GetClearFormatting(openXmlElement);
      value.Top3HeadingStyles = GetTop3HeadingStyles(openXmlElement);
      value.VisibleStyles = GetVisibleStyles(openXmlElement);
      value.AlternateStyleNames = GetAlternateStyleNames(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StylePaneFormatFilter? openXmlElement, DMW.StylePaneFormatFilter? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpAllStyles(openXmlElement, value.AllStyles, diffs, objName))
        ok = false;
      if (!CmpCustomStyles(openXmlElement, value.CustomStyles, diffs, objName))
        ok = false;
      if (!CmpLatentStyles(openXmlElement, value.LatentStyles, diffs, objName))
        ok = false;
      if (!CmpStylesInUse(openXmlElement, value.StylesInUse, diffs, objName))
        ok = false;
      if (!CmpHeadingStyles(openXmlElement, value.HeadingStyles, diffs, objName))
        ok = false;
      if (!CmpNumberingStyles(openXmlElement, value.NumberingStyles, diffs, objName))
        ok = false;
      if (!CmpTableStyles(openXmlElement, value.TableStyles, diffs, objName))
        ok = false;
      if (!CmpDirectFormattingOnRuns(openXmlElement, value.DirectFormattingOnRuns, diffs, objName))
        ok = false;
      if (!CmpDirectFormattingOnParagraphs(openXmlElement, value.DirectFormattingOnParagraphs, diffs, objName))
        ok = false;
      if (!CmpDirectFormattingOnNumbering(openXmlElement, value.DirectFormattingOnNumbering, diffs, objName))
        ok = false;
      if (!CmpDirectFormattingOnTables(openXmlElement, value.DirectFormattingOnTables, diffs, objName))
        ok = false;
      if (!CmpClearFormatting(openXmlElement, value.ClearFormatting, diffs, objName))
        ok = false;
      if (!CmpTop3HeadingStyles(openXmlElement, value.Top3HeadingStyles, diffs, objName))
        ok = false;
      if (!CmpVisibleStyles(openXmlElement, value.VisibleStyles, diffs, objName))
        ok = false;
      if (!CmpAlternateStyleNames(openXmlElement, value.AlternateStyleNames, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StylePaneFormatFilter value)
    where OpenXmlElementType: DXW.StylePaneFormatFilter, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.StylePaneFormatFilter openXmlElement, DMW.StylePaneFormatFilter value)
  {
    SetVal(openXmlElement, value?.Val);
    SetAllStyles(openXmlElement, value?.AllStyles);
    SetCustomStyles(openXmlElement, value?.CustomStyles);
    SetLatentStyles(openXmlElement, value?.LatentStyles);
    SetStylesInUse(openXmlElement, value?.StylesInUse);
    SetHeadingStyles(openXmlElement, value?.HeadingStyles);
    SetNumberingStyles(openXmlElement, value?.NumberingStyles);
    SetTableStyles(openXmlElement, value?.TableStyles);
    SetDirectFormattingOnRuns(openXmlElement, value?.DirectFormattingOnRuns);
    SetDirectFormattingOnParagraphs(openXmlElement, value?.DirectFormattingOnParagraphs);
    SetDirectFormattingOnNumbering(openXmlElement, value?.DirectFormattingOnNumbering);
    SetDirectFormattingOnTables(openXmlElement, value?.DirectFormattingOnTables);
    SetClearFormatting(openXmlElement, value?.ClearFormatting);
    SetTop3HeadingStyles(openXmlElement, value?.Top3HeadingStyles);
    SetVisibleStyles(openXmlElement, value?.VisibleStyles);
    SetAlternateStyleNames(openXmlElement, value?.AlternateStyleNames);
  }
}
