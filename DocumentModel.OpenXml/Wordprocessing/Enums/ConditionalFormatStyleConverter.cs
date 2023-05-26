using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ConditionalFormatStyle Class.
/// </summary>
public static class ConditionalFormatStyleConverter
{
  /// <summary>
  /// Conditional Formatting Bit Mask
  /// </summary>
  private static ConditionalFormatFlags GetVal(DXW.ConditionalFormatStyle openXmlElement)
  {
    var str = StringValueConverter.GetValue(openXmlElement?.Val);
    if (str != null)
    {
      var val = Convert.ToInt32(str, 2);
      return (ConditionalFormatFlags)Enum.ToObject(typeof(ConditionalFormatFlags), val);
    }
    return 0;
  }
  
  private static bool CmpVal(DXW.ConditionalFormatStyle openXmlElement, ConditionalFormatFlags? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    string? str = null;
    if (value!=null)
    {
      var val = (Int32)Convert.ChangeType(value, typeof(Int32));
      str = Convert.ToString(val, 2).PadLeft(12, '0');
    }
    return StringValueConverter.CmpValue(openXmlElement?.Val, str, diffs, objName, "Value");
  }
  
  private static void SetVal(DXW.ConditionalFormatStyle openXmlElement, ConditionalFormatFlags? value)
  {
    string? str = null;
    if (value!=null)
    {
      var val = (Int32)Convert.ChangeType(value, typeof(Int32));
      str = Convert.ToString(val, 2).PadLeft(12, '0');
    }
    openXmlElement.Val = StringValueConverter.CreateStringValue(str);
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRow(DXW.ConditionalFormatStyle openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FirstRow);
  }
  
  private static bool CmpFirstRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpLastRow(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpOddVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpEvenVerticalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpOddHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpEvenHorizontalBand(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpFirstRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpFirstRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpLastRowFirstColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static bool CmpLastRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LastRowLastColumn, value, diffs, objName, "LastRowLastColumn");
  }
  
  private static void SetLastRowLastColumn(DXW.ConditionalFormatStyle openXmlElement, Boolean? value)
  {
    openXmlElement.LastRowLastColumn = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.ConditionalFormatFlags? CreateModelElement(DXW.ConditionalFormatStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      return GetVal(openXmlElement);
      //var value = new DMW.ConditionalFormatStyle();
      //value.Val = GetVal(openXmlElement);
      //value.FirstRow = GetFirstRow(openXmlElement) ?? value.FirstRow;
      //value.LastRow = GetLastRow(openXmlElement) ?? value.LastRow;
      //value.FirstColumn = GetFirstColumn(openXmlElement) ?? value.FirstColumn;
      //value.LastColumn = GetLastColumn(openXmlElement) ?? value.LastColumn;
      //value.OddVerticalBand = GetOddVerticalBand(openXmlElement) ?? value.OddVerticalBand;
      //value.EvenVerticalBand = GetEvenVerticalBand(openXmlElement) ?? value.EvenVerticalBand;
      //value.OddHorizontalBand = GetOddHorizontalBand(openXmlElement) ?? value.OddHorizontalBand;
      //value.EvenHorizontalBand = GetEvenHorizontalBand(openXmlElement) ?? value.EvenHorizontalBand;
      //value.FirstRowFirstColumn = GetFirstRowFirstColumn(openXmlElement) ?? value.FirstRowFirstColumn;
      //value.FirstRowLastColumn = GetFirstRowLastColumn(openXmlElement) ?? value.FirstRowLastColumn;
      //value.LastRowFirstColumn = GetLastRowFirstColumn(openXmlElement) ?? value.LastRowFirstColumn;
      //value.LastRowLastColumn = GetLastRowLastColumn(openXmlElement) ?? value.LastRowLastColumn;
      //return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ConditionalFormatStyle? openXmlElement, DMW.ConditionalFormatFlags? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value, diffs, objName, propName))
        ok = false;
      //if (!CmpFirstRow(openXmlElement, value.FirstRow, diffs, objName, propName))
      //  ok = false;
      //if (!CmpLastRow(openXmlElement, value.LastRow, diffs, objName, propName))
      //  ok = false;
      //if (!CmpFirstColumn(openXmlElement, value.FirstColumn, diffs, objName, propName))
      //  ok = false;
      //if (!CmpLastColumn(openXmlElement, value.LastColumn, diffs, objName, propName))
      //  ok = false;
      //if (!CmpOddVerticalBand(openXmlElement, value.OddVerticalBand, diffs, objName, propName))
      //  ok = false;
      //if (!CmpEvenVerticalBand(openXmlElement, value.EvenVerticalBand, diffs, objName, propName))
      //  ok = false;
      //if (!CmpOddHorizontalBand(openXmlElement, value.OddHorizontalBand, diffs, objName, propName))
      //  ok = false;
      //if (!CmpEvenHorizontalBand(openXmlElement, value.EvenHorizontalBand, diffs, objName, propName))
      //  ok = false;
      //if (!CmpFirstRowFirstColumn(openXmlElement, value.FirstRowFirstColumn, diffs, objName, propName))
      //  ok = false;
      //if (!CmpFirstRowLastColumn(openXmlElement, value.FirstRowLastColumn, diffs, objName, propName))
      //  ok = false;
      //if (!CmpLastRowFirstColumn(openXmlElement, value.LastRowFirstColumn, diffs, objName, propName))
      //  ok = false;
      //if (!CmpLastRowLastColumn(openXmlElement, value.LastRowLastColumn, diffs, objName, propName))
      //  ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ConditionalFormatFlags value)
    where OpenXmlElementType: DXW.ConditionalFormatStyle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ConditionalFormatStyle openXmlElement, DMW.ConditionalFormatFlags value)
  {
    SetVal(openXmlElement, value);
    SetFirstRow(openXmlElement, value.HasFlag(ConditionalFormatFlags.FirstRow));
    SetLastRow(openXmlElement, value.HasFlag(ConditionalFormatFlags.LastRow));
    SetFirstColumn(openXmlElement, value.HasFlag(ConditionalFormatFlags.FirstColumn));
    SetLastColumn(openXmlElement, value.HasFlag(ConditionalFormatFlags.LastColumn));
    SetOddVerticalBand(openXmlElement, value.HasFlag(ConditionalFormatFlags.OddVBand));
    SetEvenVerticalBand(openXmlElement, value.HasFlag(ConditionalFormatFlags.EvenVBand));
    SetOddHorizontalBand(openXmlElement, value.HasFlag(ConditionalFormatFlags.OddHBand));
    SetEvenHorizontalBand(openXmlElement, value.HasFlag(ConditionalFormatFlags.EvenHBand));
    SetFirstRowFirstColumn(openXmlElement, value.HasFlag(ConditionalFormatFlags.FirstRowFirstColumn));
    SetFirstRowLastColumn(openXmlElement, value.HasFlag(ConditionalFormatFlags.FirstRowLastColumn));
    SetLastRowFirstColumn(openXmlElement, value.HasFlag(ConditionalFormatFlags.LastRowFirstColumn));
    SetLastRowLastColumn(openXmlElement, value.HasFlag(ConditionalFormatFlags.LastRowLastColumn));
  }
}
