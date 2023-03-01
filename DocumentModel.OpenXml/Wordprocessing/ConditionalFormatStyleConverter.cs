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
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXW.ConditionalFormatStyle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Val");
  }
  
  private static void SetVal(DXW.ConditionalFormatStyle openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRow(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FirstRow);
  }
  
  private static bool CmpFirstRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FirstRow, value, diffs, objName, "FirstRow");
  }
  
  private static void SetFirstRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.FirstRow = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRow(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LastRow);
  }
  
  private static bool CmpLastRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LastRow, value, diffs, objName, "LastRow");
  }
  
  private static void SetLastRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.LastRow = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FirstColumn);
  }
  
  private static bool CmpFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FirstColumn, value, diffs, objName, "FirstColumn");
  }
  
  private static void SetFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.FirstColumn = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LastColumn);
  }
  
  private static bool CmpLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LastColumn, value, diffs, objName, "LastColumn");
  }
  
  private static void SetLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.LastColumn = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetOddVerticalBand(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.OddVerticalBand);
  }
  
  private static bool CmpOddVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.OddVerticalBand, value, diffs, objName, "OddVerticalBand");
  }
  
  private static void SetOddVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.OddVerticalBand = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEvenVerticalBand(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.EvenVerticalBand);
  }
  
  private static bool CmpEvenVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.EvenVerticalBand, value, diffs, objName, "EvenVerticalBand");
  }
  
  private static void SetEvenVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.EvenVerticalBand = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetOddHorizontalBand(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.OddHorizontalBand);
  }
  
  private static bool CmpOddHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.OddHorizontalBand, value, diffs, objName, "OddHorizontalBand");
  }
  
  private static void SetOddHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.OddHorizontalBand = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEvenHorizontalBand(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.EvenHorizontalBand);
  }
  
  private static bool CmpEvenHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.EvenHorizontalBand, value, diffs, objName, "EvenHorizontalBand");
  }
  
  private static void SetEvenHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.EvenHorizontalBand = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FirstRowFirstColumn);
  }
  
  private static bool CmpFirstRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FirstRowFirstColumn, value, diffs, objName, "FirstRowFirstColumn");
  }
  
  private static void SetFirstRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.FirstRowFirstColumn = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRowLastColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FirstRowLastColumn);
  }
  
  private static bool CmpFirstRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FirstRowLastColumn, value, diffs, objName, "FirstRowLastColumn");
  }
  
  private static void SetFirstRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.FirstRowLastColumn = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LastRowFirstColumn);
  }
  
  private static bool CmpLastRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LastRowFirstColumn, value, diffs, objName, "LastRowFirstColumn");
  }
  
  private static void SetLastRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.LastRowFirstColumn = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRowLastColumn(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LastRowLastColumn);
  }
  
  private static bool CmpLastRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LastRowLastColumn, value, diffs, objName, "LastRowLastColumn");
  }
  
  private static void SetLastRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.LastRowLastColumn = BooleanValueConverter.CreateOnOffValue(value);
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ConditionalFormatStyle value)
    where OpenXmlElementType: DXW.ConditionalFormatStyle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ConditionalFormatStyle openXmlElement, DMW.ConditionalFormatStyle value)
  {
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
  }
}
