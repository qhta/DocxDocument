using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Suggested Filtering for List of Document Styles.
/// </summary>
public static class StylePaneFormatFilterConverter
{
  /// <summary>
  ///   val
  /// </summary>
  public static Byte[]? GetVal(StylePaneFormatFilter? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return Convert.FromHexString(openXmlElement.Val.Value);
    return null;
  }

  public static void SetVal(StylePaneFormatFilter? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Val = Convert.ToHexString(value);
      else
        openXmlElement.Val = null;
    }
  }

  /// <summary>
  ///   allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetAllStyles(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.AllStyles?.Value;
  }

  public static void SetAllStyles(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AllStyles = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.AllStyles = null;
  }

  /// <summary>
  ///   customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetCustomStyles(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.CustomStyles?.Value;
  }

  public static void SetCustomStyles(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CustomStyles = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.CustomStyles = null;
  }

  /// <summary>
  ///   latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetLatentStyles(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.LatentStyles?.Value;
  }

  public static void SetLatentStyles(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LatentStyles = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LatentStyles = null;
  }

  /// <summary>
  ///   stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetStylesInUse(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.StylesInUse?.Value;
  }

  public static void SetStylesInUse(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StylesInUse = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.StylesInUse = null;
  }

  /// <summary>
  ///   headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetHeadingStyles(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.HeadingStyles?.Value;
  }

  public static void SetHeadingStyles(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HeadingStyles = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.HeadingStyles = null;
  }

  /// <summary>
  ///   numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetNumberingStyles(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.NumberingStyles?.Value;
  }

  public static void SetNumberingStyles(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NumberingStyles = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.NumberingStyles = null;
  }

  /// <summary>
  ///   tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetTableStyles(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.TableStyles?.Value;
  }

  public static void SetTableStyles(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.TableStyles = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.TableStyles = null;
  }

  /// <summary>
  ///   directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetDirectFormattingOnRuns(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnRuns?.Value;
  }

  public static void SetDirectFormattingOnRuns(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DirectFormattingOnRuns = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DirectFormattingOnRuns = null;
  }

  /// <summary>
  ///   directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetDirectFormattingOnParagraphs(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnParagraphs?.Value;
  }

  public static void SetDirectFormattingOnParagraphs(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DirectFormattingOnParagraphs = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DirectFormattingOnParagraphs = null;
  }

  /// <summary>
  ///   directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetDirectFormattingOnNumbering(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnNumbering?.Value;
  }

  public static void SetDirectFormattingOnNumbering(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DirectFormattingOnNumbering = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DirectFormattingOnNumbering = null;
  }

  /// <summary>
  ///   directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetDirectFormattingOnTables(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.DirectFormattingOnTables?.Value;
  }

  public static void SetDirectFormattingOnTables(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DirectFormattingOnTables = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DirectFormattingOnTables = null;
  }

  /// <summary>
  ///   clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetClearFormatting(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.ClearFormatting?.Value;
  }

  public static void SetClearFormatting(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ClearFormatting = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.ClearFormatting = null;
  }

  /// <summary>
  ///   top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetTop3HeadingStyles(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.Top3HeadingStyles?.Value;
  }

  public static void SetTop3HeadingStyles(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Top3HeadingStyles = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Top3HeadingStyles = null;
  }

  /// <summary>
  ///   visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisibleStyles(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.VisibleStyles?.Value;
  }

  public static void SetVisibleStyles(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.VisibleStyles = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.VisibleStyles = null;
  }

  /// <summary>
  ///   alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetAlternateStyleNames(StylePaneFormatFilter? openXmlElement)
  {
    return openXmlElement?.AlternateStyleNames?.Value;
  }

  public static void SetAlternateStyleNames(StylePaneFormatFilter? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.AlternateStyleNames = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.AlternateStyleNames = null;
  }

  public static DocumentModel.Wordprocessing.StylePaneFormatFilter? CreateModelElement(StylePaneFormatFilter? openXmlElement)
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
    where OpenXmlElementType : StylePaneFormatFilter, new()
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