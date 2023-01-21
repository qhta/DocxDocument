namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Suggested Filtering for List of Document Styles.
/// </summary>
public static class StylePaneFormatFilterConverter
{
  /// <summary>
  /// val
  /// </summary>
  private static UInt16? GetVal(DXW.StylePaneFormatFilter openXmlElement)
  {
    if (openXmlElement.Val?.Value != null)
      return UInt16.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetVal(DXW.StylePaneFormatFilter openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.Val = ((UInt16)value).ToString("X4");
      else
        openXmlElement.Val = null;
  }
  
  /// <summary>
  /// allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetAllStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.AllStyles?.Value;
  }
  
  private static void SetAllStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.AllStyles = null;
  }
  
  /// <summary>
  /// customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetCustomStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.CustomStyles?.Value;
  }
  
  private static void SetCustomStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CustomStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CustomStyles = null;
  }
  
  /// <summary>
  /// latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLatentStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.LatentStyles?.Value;
  }
  
  private static void SetLatentStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LatentStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LatentStyles = null;
  }
  
  /// <summary>
  /// stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetStylesInUse(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.StylesInUse?.Value;
  }
  
  private static void SetStylesInUse(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.StylesInUse = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.StylesInUse = null;
  }
  
  /// <summary>
  /// headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetHeadingStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.HeadingStyles?.Value;
  }
  
  private static void SetHeadingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HeadingStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.HeadingStyles = null;
  }
  
  /// <summary>
  /// numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNumberingStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.NumberingStyles?.Value;
  }
  
  private static void SetNumberingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NumberingStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.NumberingStyles = null;
  }
  
  /// <summary>
  /// tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetTableStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.TableStyles?.Value;
  }
  
  private static void SetTableStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TableStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.TableStyles = null;
  }
  
  /// <summary>
  /// directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnRuns(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnRuns?.Value;
  }
  
  private static void SetDirectFormattingOnRuns(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DirectFormattingOnRuns = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DirectFormattingOnRuns = null;
  }
  
  /// <summary>
  /// directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnParagraphs(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnParagraphs?.Value;
  }
  
  private static void SetDirectFormattingOnParagraphs(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DirectFormattingOnParagraphs = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DirectFormattingOnParagraphs = null;
  }
  
  /// <summary>
  /// directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnNumbering(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnNumbering?.Value;
  }
  
  private static void SetDirectFormattingOnNumbering(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DirectFormattingOnNumbering = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DirectFormattingOnNumbering = null;
  }
  
  /// <summary>
  /// directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnTables(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnTables?.Value;
  }
  
  private static void SetDirectFormattingOnTables(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DirectFormattingOnTables = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DirectFormattingOnTables = null;
  }
  
  /// <summary>
  /// clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetClearFormatting(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.ClearFormatting?.Value;
  }
  
  private static void SetClearFormatting(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClearFormatting = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.ClearFormatting = null;
  }
  
  /// <summary>
  /// top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetTop3HeadingStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.Top3HeadingStyles?.Value;
  }
  
  private static void SetTop3HeadingStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Top3HeadingStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Top3HeadingStyles = null;
  }
  
  /// <summary>
  /// visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisibleStyles(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.VisibleStyles?.Value;
  }
  
  private static void SetVisibleStyles(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VisibleStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.VisibleStyles = null;
  }
  
  /// <summary>
  /// alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetAlternateStyleNames(DXW.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.AlternateStyleNames?.Value;
  }
  
  private static void SetAlternateStyleNames(DXW.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlternateStyleNames = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.AlternateStyleNames = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.StylePaneFormatFilter? value)
    where OpenXmlElementType: DXW.StylePaneFormatFilter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
