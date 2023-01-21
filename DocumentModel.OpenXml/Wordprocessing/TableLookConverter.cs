namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableLook Class.
/// </summary>
public static class TableLookConverter
{
  /// <summary>
  /// val
  /// </summary>
  private static UInt16? GetVal(DXW.TableLook openXmlElement)
  {
    if (openXmlElement.Val?.Value != null)
      return UInt16.Parse(openXmlElement.Val.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetVal(DXW.TableLook openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.Val = ((UInt16)value).ToString("X4");
      else
        openXmlElement.Val = null;
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstRow(DXW.TableLook openXmlElement)
  {
    return openXmlElement?.FirstRow?.Value;
  }
  
  private static void SetFirstRow(DXW.TableLook openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstRow = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstRow = null;
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastRow(DXW.TableLook openXmlElement)
  {
    return openXmlElement?.LastRow?.Value;
  }
  
  private static void SetLastRow(DXW.TableLook openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastRow = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastRow = null;
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetFirstColumn(DXW.TableLook openXmlElement)
  {
    return openXmlElement?.FirstColumn?.Value;
  }
  
  private static void SetFirstColumn(DXW.TableLook openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.FirstColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.FirstColumn = null;
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetLastColumn(DXW.TableLook openXmlElement)
  {
    return openXmlElement?.LastColumn?.Value;
  }
  
  private static void SetLastColumn(DXW.TableLook openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.LastColumn = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.LastColumn = null;
  }
  
  /// <summary>
  /// noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNoHorizontalBand(DXW.TableLook openXmlElement)
  {
    return openXmlElement?.NoHorizontalBand?.Value;
  }
  
  private static void SetNoHorizontalBand(DXW.TableLook openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoHorizontalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.NoHorizontalBand = null;
  }
  
  /// <summary>
  /// noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNoVerticalBand(DXW.TableLook openXmlElement)
  {
    return openXmlElement?.NoVerticalBand?.Value;
  }
  
  private static void SetNoVerticalBand(DXW.TableLook openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.NoVerticalBand = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.NoVerticalBand = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableLook? value)
    where OpenXmlElementType: DXW.TableLook, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetFirstRow(openXmlElement, value?.FirstRow);
      SetLastRow(openXmlElement, value?.LastRow);
      SetFirstColumn(openXmlElement, value?.FirstColumn);
      SetLastColumn(openXmlElement, value?.LastColumn);
      SetNoHorizontalBand(openXmlElement, value?.NoHorizontalBand);
      SetNoVerticalBand(openXmlElement, value?.NoVerticalBand);
      return openXmlElement;
    }
    return default;
  }
}
