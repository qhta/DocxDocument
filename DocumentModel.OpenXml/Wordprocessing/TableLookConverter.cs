namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableLook Class.
/// </summary>
public static class TableLookConverter
{
  /// <summary>
  /// val
  /// </summary>
  private static DM.HexChar? GetVal(DXW.TableLook openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.Val.Value);
    return null;
  }
  
  private static bool CmpVal(DXW.TableLook openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.Val.Value).Equals(value))
        return true;
    if (openXmlElement == null && openXmlElement?.Val?.Value == null && value is null) return true;
    diffs?.Add(objName, "Normal", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXW.TableLook openXmlElement, DM.HexChar? value)
  {
    if (value is not null)
      openXmlElement.Val = value.ToString();
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRow(DXW.TableLook openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FirstRow);
  }
  
  private static bool CmpFirstRow(DXW.TableLook openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FirstRow, value, diffs, objName, "FirstRow");
  }
  
  private static void SetFirstRow(DXW.TableLook openXmlElement, Boolean? value)
  {
    openXmlElement.FirstRow = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRow(DXW.TableLook openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LastRow);
  }
  
  private static bool CmpLastRow(DXW.TableLook openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LastRow, value, diffs, objName, "LastRow");
  }
  
  private static void SetLastRow(DXW.TableLook openXmlElement, Boolean? value)
  {
    openXmlElement.LastRow = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstColumn(DXW.TableLook openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.FirstColumn);
  }
  
  private static bool CmpFirstColumn(DXW.TableLook openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.FirstColumn, value, diffs, objName, "FirstColumn");
  }
  
  private static void SetFirstColumn(DXW.TableLook openXmlElement, Boolean? value)
  {
    openXmlElement.FirstColumn = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastColumn(DXW.TableLook openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LastColumn);
  }
  
  private static bool CmpLastColumn(DXW.TableLook openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.LastColumn, value, diffs, objName, "LastColumn");
  }
  
  private static void SetLastColumn(DXW.TableLook openXmlElement, Boolean? value)
  {
    openXmlElement.LastColumn = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNoHorizontalBand(DXW.TableLook openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.NoHorizontalBand);
  }
  
  private static bool CmpNoHorizontalBand(DXW.TableLook openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.NoHorizontalBand, value, diffs, objName, "NoHorizontalBand");
  }
  
  private static void SetNoHorizontalBand(DXW.TableLook openXmlElement, Boolean? value)
  {
    openXmlElement.NoHorizontalBand = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNoVerticalBand(DXW.TableLook openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.NoVerticalBand);
  }
  
  private static bool CmpNoVerticalBand(DXW.TableLook openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.NoVerticalBand, value, diffs, objName, "NoVerticalBand");
  }
  
  private static void SetNoVerticalBand(DXW.TableLook openXmlElement, Boolean? value)
  {
    openXmlElement.NoVerticalBand = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.TableLook? CreateModelElement(DXW.TableLook? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableLook();
      value.Val = GetVal(openXmlElement);
      value.FirstRow = GetFirstRow(openXmlElement);
      value.LastRow = GetLastRow(openXmlElement);
      value.FirstColumn = GetFirstColumn(openXmlElement);
      value.LastColumn = GetLastColumn(openXmlElement);
      value.NoHorizontalBand = GetNoHorizontalBand(openXmlElement);
      value.NoVerticalBand = GetNoVerticalBand(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableLook? openXmlElement, DMW.TableLook? value, DiffList? diffs, string? objName)
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
      if (!CmpNoHorizontalBand(openXmlElement, value.NoHorizontalBand, diffs, objName))
        ok = false;
      if (!CmpNoVerticalBand(openXmlElement, value.NoVerticalBand, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableLook value)
    where OpenXmlElementType: DXW.TableLook, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableLook openXmlElement, DMW.TableLook value)
  {
    SetVal(openXmlElement, value?.Val);
    SetFirstRow(openXmlElement, value?.FirstRow);
    SetLastRow(openXmlElement, value?.LastRow);
    SetFirstColumn(openXmlElement, value?.FirstColumn);
    SetLastColumn(openXmlElement, value?.LastColumn);
    SetNoHorizontalBand(openXmlElement, value?.NoHorizontalBand);
    SetNoVerticalBand(openXmlElement, value?.NoVerticalBand);
  }
}
