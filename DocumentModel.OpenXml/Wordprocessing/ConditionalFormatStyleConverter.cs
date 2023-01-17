namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ConditionalFormatStyle Class.
/// </summary>
public static class ConditionalFormatStyleConverter
{
  /// <summary>
  /// Conditional Formatting Bit Mask
  /// </summary>
  private static String? GetVal(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRow(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.FirstRow?.Value;
  }
  
  private static void SetFirstRow(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstRow = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstRow = null;
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRow(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.LastRow?.Value;
  }
  
  private static void SetLastRow(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastRow = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastRow = null;
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.FirstColumn?.Value;
  }
  
  private static void SetFirstColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstColumn = null;
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.LastColumn?.Value;
  }
  
  private static void SetLastColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastColumn = null;
  }
  
  /// <summary>
  /// oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetOddVerticalBand(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.OddVerticalBand?.Value;
  }
  
  private static void SetOddVerticalBand(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OddVerticalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.OddVerticalBand = null;
  }
  
  /// <summary>
  /// evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEvenVerticalBand(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.EvenVerticalBand?.Value;
  }
  
  private static void SetEvenVerticalBand(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EvenVerticalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.EvenVerticalBand = null;
  }
  
  /// <summary>
  /// oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetOddHorizontalBand(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.OddHorizontalBand?.Value;
  }
  
  private static void SetOddHorizontalBand(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OddHorizontalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.OddHorizontalBand = null;
  }
  
  /// <summary>
  /// evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEvenHorizontalBand(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.EvenHorizontalBand?.Value;
  }
  
  private static void SetEvenHorizontalBand(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EvenHorizontalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.EvenHorizontalBand = null;
  }
  
  /// <summary>
  /// firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRowFirstColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.FirstRowFirstColumn?.Value;
  }
  
  private static void SetFirstRowFirstColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstRowFirstColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstRowFirstColumn = null;
  }
  
  /// <summary>
  /// firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRowLastColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.FirstRowLastColumn?.Value;
  }
  
  private static void SetFirstRowLastColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstRowLastColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstRowLastColumn = null;
  }
  
  /// <summary>
  /// lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRowFirstColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.LastRowFirstColumn?.Value;
  }
  
  private static void SetLastRowFirstColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastRowFirstColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastRowFirstColumn = null;
  }
  
  /// <summary>
  /// lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRowLastColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.LastRowLastColumn?.Value;
  }
  
  private static void SetLastRowLastColumn(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastRowLastColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastRowLastColumn = null;
  }
  
  public static DocumentModel.Wordprocessing.ConditionalFormatStyle? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle, new()
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
