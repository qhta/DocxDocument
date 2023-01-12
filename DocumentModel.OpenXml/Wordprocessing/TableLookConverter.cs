namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableLook Class.
/// </summary>
public static class TableLookConverter
{
  /// <summary>
  /// val
  /// </summary>
  public static Byte[]? GetVal(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return Convert.FromHexString(openXmlElement.Val.Value);
    return null;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement, Byte[]? value)
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
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetFirstRow(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement)
  {
    return openXmlElement?.FirstRow?.Value;
  }
  
  public static void SetFirstRow(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FirstRow = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FirstRow = null;
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetLastRow(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement)
  {
    return openXmlElement?.LastRow?.Value;
  }
  
  public static void SetLastRow(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastRow = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LastRow = null;
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetFirstColumn(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement)
  {
    return openXmlElement?.FirstColumn?.Value;
  }
  
  public static void SetFirstColumn(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FirstColumn = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FirstColumn = null;
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetLastColumn(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement)
  {
    return openXmlElement?.LastColumn?.Value;
  }
  
  public static void SetLastColumn(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LastColumn = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.LastColumn = null;
  }
  
  /// <summary>
  /// noHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetNoHorizontalBand(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement)
  {
    return openXmlElement?.NoHorizontalBand?.Value;
  }
  
  public static void SetNoHorizontalBand(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoHorizontalBand = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.NoHorizontalBand = null;
  }
  
  /// <summary>
  /// noVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetNoVerticalBand(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement)
  {
    return openXmlElement?.NoVerticalBand?.Value;
  }
  
  public static void SetNoVerticalBand(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.NoVerticalBand = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.NoVerticalBand = null;
  }
  
  public static DocumentModel.Wordprocessing.TableLook? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableLook? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableLook();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableLook? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableLook, new()
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
