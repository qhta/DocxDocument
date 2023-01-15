using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the ConditionalFormatStyle Class.
/// </summary>
public static class ConditionalFormatStyleConverter
{
  /// <summary>
  ///   Conditional Formatting Bit Mask
  /// </summary>
  public static String? GetVal(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(ConditionalFormatStyle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  /// <summary>
  ///   firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetFirstRow(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.FirstRow?.Value;
  }

  public static void SetFirstRow(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FirstRow = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FirstRow = null;
  }

  /// <summary>
  ///   lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetLastRow(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.LastRow?.Value;
  }

  public static void SetLastRow(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastRow = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LastRow = null;
  }

  /// <summary>
  ///   firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetFirstColumn(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.FirstColumn?.Value;
  }

  public static void SetFirstColumn(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FirstColumn = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FirstColumn = null;
  }

  /// <summary>
  ///   lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetLastColumn(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.LastColumn?.Value;
  }

  public static void SetLastColumn(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastColumn = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LastColumn = null;
  }

  /// <summary>
  ///   oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetOddVerticalBand(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.OddVerticalBand?.Value;
  }

  public static void SetOddVerticalBand(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OddVerticalBand = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.OddVerticalBand = null;
  }

  /// <summary>
  ///   evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEvenVerticalBand(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.EvenVerticalBand?.Value;
  }

  public static void SetEvenVerticalBand(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EvenVerticalBand = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.EvenVerticalBand = null;
  }

  /// <summary>
  ///   oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetOddHorizontalBand(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.OddHorizontalBand?.Value;
  }

  public static void SetOddHorizontalBand(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OddHorizontalBand = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.OddHorizontalBand = null;
  }

  /// <summary>
  ///   evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEvenHorizontalBand(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.EvenHorizontalBand?.Value;
  }

  public static void SetEvenHorizontalBand(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EvenHorizontalBand = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.EvenHorizontalBand = null;
  }

  /// <summary>
  ///   firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetFirstRowFirstColumn(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.FirstRowFirstColumn?.Value;
  }

  public static void SetFirstRowFirstColumn(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FirstRowFirstColumn = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FirstRowFirstColumn = null;
  }

  /// <summary>
  ///   firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetFirstRowLastColumn(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.FirstRowLastColumn?.Value;
  }

  public static void SetFirstRowLastColumn(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FirstRowLastColumn = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FirstRowLastColumn = null;
  }

  /// <summary>
  ///   lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetLastRowFirstColumn(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.LastRowFirstColumn?.Value;
  }

  public static void SetLastRowFirstColumn(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastRowFirstColumn = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LastRowFirstColumn = null;
  }

  /// <summary>
  ///   lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetLastRowLastColumn(ConditionalFormatStyle? openXmlElement)
  {
    return openXmlElement?.LastRowLastColumn?.Value;
  }

  public static void SetLastRowLastColumn(ConditionalFormatStyle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastRowLastColumn = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LastRowLastColumn = null;
  }

  public static DocumentModel.Wordprocessing.ConditionalFormatStyle? CreateModelElement(ConditionalFormatStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ConditionalFormatStyle();
      value.Val = GetVal(openXmlElement);
      value.FirstRow = GetFirstRow(openXmlElement);
      value.LastRow = GetLastRow(openXmlElement);
      value.FirstColumn = GetFirstColumn(openXmlElement);
      value.LastColumn = GetLastColumn(openXmlElement);
      value.OddVerticalBand = GetOddVerticalBand(openXmlElement);
      value.EvenVerticalBand = GetEvenVerticalBand(openXmlElement);
      value.OddHorizontalBand = GetOddHorizontalBand(openXmlElement);
      value.EvenHorizontalBand = GetEvenHorizontalBand(openXmlElement);
      value.FirstRowFirstColumn = GetFirstRowFirstColumn(openXmlElement);
      value.FirstRowLastColumn = GetFirstRowLastColumn(openXmlElement);
      value.LastRowFirstColumn = GetLastRowFirstColumn(openXmlElement);
      value.LastRowLastColumn = GetLastRowLastColumn(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.ConditionalFormatStyle? value)
    where OpenXmlElementType : ConditionalFormatStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetFirstRow(openXmlElement, value?.FirstRow);
      SetLastRow(openXmlElement, value?.LastRow);
      SetFirstColumn(openXmlElement, value?.FirstColumn);
      SetLastColumn(openXmlElement, value?.LastColumn);
      SetOddVerticalBand(openXmlElement, value?.OddVerticalBand);
      SetEvenVerticalBand(openXmlElement, value?.EvenVerticalBand);
      SetOddHorizontalBand(openXmlElement, value?.OddHorizontalBand);
      SetEvenHorizontalBand(openXmlElement, value?.EvenHorizontalBand);
      SetFirstRowFirstColumn(openXmlElement, value?.FirstRowFirstColumn);
      SetFirstRowLastColumn(openXmlElement, value?.FirstRowLastColumn);
      SetLastRowFirstColumn(openXmlElement, value?.LastRowFirstColumn);
      SetLastRowLastColumn(openXmlElement, value?.LastRowLastColumn);
      return openXmlElement;
    }
    return default;
  }
}