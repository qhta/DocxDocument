namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ConditionalFormatStyle Class.
/// </summary>
public static class ConditionalFormatStyleConverter
{
  /// <summary>
  /// Conditional Formatting Bit Mask
  /// </summary>
  private static String? GetVal(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXW.ConditionalFormatStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Val?.Value == value;
  }
  
  private static void SetVal(DXW.ConditionalFormatStyle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRow(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.FirstRow?.Value;
  }
  
  private static bool CmpFirstRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FirstRow?.Value == value;
  }
  
  private static void SetFirstRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstRow = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstRow = null;
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRow(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.LastRow?.Value;
  }
  
  private static bool CmpLastRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LastRow?.Value == value;
  }
  
  private static void SetLastRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastRow = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastRow = null;
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.FirstColumn?.Value;
  }
  
  private static bool CmpFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FirstColumn?.Value == value;
  }
  
  private static void SetFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstColumn = null;
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.LastColumn?.Value;
  }
  
  private static bool CmpLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LastColumn?.Value == value;
  }
  
  private static void SetLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastColumn = null;
  }
  
  /// <summary>
  /// oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetOddVerticalBand(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.OddVerticalBand?.Value;
  }
  
  private static bool CmpOddVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OddVerticalBand?.Value == value;
  }
  
  private static void SetOddVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OddVerticalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.OddVerticalBand = null;
  }
  
  /// <summary>
  /// evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEvenVerticalBand(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.EvenVerticalBand?.Value;
  }
  
  private static bool CmpEvenVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.EvenVerticalBand?.Value == value;
  }
  
  private static void SetEvenVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EvenVerticalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.EvenVerticalBand = null;
  }
  
  /// <summary>
  /// oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetOddHorizontalBand(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.OddHorizontalBand?.Value;
  }
  
  private static bool CmpOddHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OddHorizontalBand?.Value == value;
  }
  
  private static void SetOddHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.OddHorizontalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.OddHorizontalBand = null;
  }
  
  /// <summary>
  /// evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEvenHorizontalBand(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.EvenHorizontalBand?.Value;
  }
  
  private static bool CmpEvenHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.EvenHorizontalBand?.Value == value;
  }
  
  private static void SetEvenHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.EvenHorizontalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.EvenHorizontalBand = null;
  }
  
  /// <summary>
  /// firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.FirstRowFirstColumn?.Value;
  }
  
  private static bool CmpFirstRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FirstRowFirstColumn?.Value == value;
  }
  
  private static void SetFirstRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstRowFirstColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstRowFirstColumn = null;
  }
  
  /// <summary>
  /// firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRowLastColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.FirstRowLastColumn?.Value;
  }
  
  private static bool CmpFirstRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.FirstRowLastColumn?.Value == value;
  }
  
  private static void SetFirstRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstRowLastColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstRowLastColumn = null;
  }
  
  /// <summary>
  /// lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.LastRowFirstColumn?.Value;
  }
  
  private static bool CmpLastRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LastRowFirstColumn?.Value == value;
  }
  
  private static void SetLastRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastRowFirstColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastRowFirstColumn = null;
  }
  
  /// <summary>
  /// lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRowLastColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return openXmlElement?.LastRowLastColumn?.Value;
  }
  
  private static bool CmpLastRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LastRowLastColumn?.Value == value;
  }
  
  private static void SetLastRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastRowLastColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastRowLastColumn = null;
  }
  
  public static DMW.ConditionalFormatStyle? CreateModelElement(DXW.ConditionalFormatStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ConditionalFormatStyle();
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
  
  public static bool CompareModelElement(DXW.ConditionalFormatStyle? openXmlElement, DMW.ConditionalFormatStyle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpFirstRow(openXmlElement, value.FirstRow, diffs, objName))
        ok = false;
      if (!CmpLastRow(openXmlElement, value.LastRow, diffs, objName))
        ok = false;
      if (!CmpFirstColumn(openXmlElement, value.FirstColumn, diffs, objName))
        ok = false;
      if (!CmpLastColumn(openXmlElement, value.LastColumn, diffs, objName))
        ok = false;
      if (!CmpOddVerticalBand(openXmlElement, value.OddVerticalBand, diffs, objName))
        ok = false;
      if (!CmpEvenVerticalBand(openXmlElement, value.EvenVerticalBand, diffs, objName))
        ok = false;
      if (!CmpOddHorizontalBand(openXmlElement, value.OddHorizontalBand, diffs, objName))
        ok = false;
      if (!CmpEvenHorizontalBand(openXmlElement, value.EvenHorizontalBand, diffs, objName))
        ok = false;
      if (!CmpFirstRowFirstColumn(openXmlElement, value.FirstRowFirstColumn, diffs, objName))
        ok = false;
      if (!CmpFirstRowLastColumn(openXmlElement, value.FirstRowLastColumn, diffs, objName))
        ok = false;
      if (!CmpLastRowFirstColumn(openXmlElement, value.LastRowFirstColumn, diffs, objName))
        ok = false;
      if (!CmpLastRowLastColumn(openXmlElement, value.LastRowLastColumn, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ConditionalFormatStyle? value)
    where OpenXmlElementType: DXW.ConditionalFormatStyle, new()
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
