namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Suggested Filtering for List of Document Styles.
/// </summary>
public static class StylePaneFormatFilterConverter
{
  /// <summary>
  /// val
  /// </summary>
  private static UInt16? GetVal(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    if (openXmlElement.Val?.Value != null)
      return UInt16.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.Val = ((UInt16)value).ToString("X4");
      else
        openXmlElement.Val = null;
  }
  
  /// <summary>
  /// allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetAllStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.AllStyles?.Value;
  }
  
  private static void SetAllStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AllStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.AllStyles = null;
  }
  
  /// <summary>
  /// customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetCustomStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.CustomStyles?.Value;
  }
  
  private static void SetCustomStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CustomStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.CustomStyles = null;
  }
  
  /// <summary>
  /// latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLatentStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.LatentStyles?.Value;
  }
  
  private static void SetLatentStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LatentStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LatentStyles = null;
  }
  
  /// <summary>
  /// stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetStylesInUse(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.StylesInUse?.Value;
  }
  
  private static void SetStylesInUse(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.StylesInUse = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.StylesInUse = null;
  }
  
  /// <summary>
  /// headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetHeadingStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.HeadingStyles?.Value;
  }
  
  private static void SetHeadingStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HeadingStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.HeadingStyles = null;
  }
  
  /// <summary>
  /// numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNumberingStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.NumberingStyles?.Value;
  }
  
  private static void SetNumberingStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NumberingStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.NumberingStyles = null;
  }
  
  /// <summary>
  /// tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetTableStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.TableStyles?.Value;
  }
  
  private static void SetTableStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.TableStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.TableStyles = null;
  }
  
  /// <summary>
  /// directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnRuns(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnRuns?.Value;
  }
  
  private static void SetDirectFormattingOnRuns(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DirectFormattingOnRuns = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DirectFormattingOnRuns = null;
  }
  
  /// <summary>
  /// directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnParagraphs(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnParagraphs?.Value;
  }
  
  private static void SetDirectFormattingOnParagraphs(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DirectFormattingOnParagraphs = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DirectFormattingOnParagraphs = null;
  }
  
  /// <summary>
  /// directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnNumbering(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnNumbering?.Value;
  }
  
  private static void SetDirectFormattingOnNumbering(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DirectFormattingOnNumbering = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DirectFormattingOnNumbering = null;
  }
  
  /// <summary>
  /// directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetDirectFormattingOnTables(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnTables?.Value;
  }
  
  private static void SetDirectFormattingOnTables(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DirectFormattingOnTables = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DirectFormattingOnTables = null;
  }
  
  /// <summary>
  /// clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetClearFormatting(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.ClearFormatting?.Value;
  }
  
  private static void SetClearFormatting(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ClearFormatting = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.ClearFormatting = null;
  }
  
  /// <summary>
  /// top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetTop3HeadingStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.Top3HeadingStyles?.Value;
  }
  
  private static void SetTop3HeadingStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Top3HeadingStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Top3HeadingStyles = null;
  }
  
  /// <summary>
  /// visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisibleStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.VisibleStyles?.Value;
  }
  
  private static void SetVisibleStyles(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VisibleStyles = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.VisibleStyles = null;
  }
  
  /// <summary>
  /// alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetAlternateStyleNames(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement)
  {
    return openXmlElement?.AlternateStyleNames?.Value;
  }
  
  private static void SetAlternateStyleNames(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AlternateStyleNames = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.AlternateStyleNames = null;
  }
  
  public static DocumentModel.Wordprocessing.StylePaneFormatFilter? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.StylePaneFormatFilter();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.StylePaneFormatFilter? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter, new()
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
