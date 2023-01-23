namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public static class DataLabelFieldTableEntryConverter
{
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  private static String? GetTextFieldGuid(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.TextFieldGuid>()?.Text;
  }
  
  private static bool CmpTextFieldGuid(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.TextFieldGuid>()?.Text == value;
  }
  
  private static void SetTextFieldGuid(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.TextFieldGuid>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013DrawChart.TextFieldGuid { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  private static String? GetFormula(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.Formula>()?.Text;
  }
  
  private static bool CmpFormula(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.Formula>()?.Text == value;
  }
  
  private static void SetFormula(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013DrawChart.Formula { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  private static DMDrawsCharts.DataLabelFieldTableCache? GetDataLabelFieldTableCache(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement)
  {
    return DMXDrawsCharts.DataLabelFieldTableCacheConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelFieldTableCache>());
  }
  
  private static bool CmpDataLabelFieldTableCache(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement, DMDrawsCharts.DataLabelFieldTableCache? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelFieldTableCacheConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelFieldTableCache>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabelFieldTableCache(DXO2013DrawChart.DataLabelFieldTableEntry openXmlElement, DMDrawsCharts.DataLabelFieldTableCache? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelFieldTableCache>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabelFieldTableCacheConverter.CreateOpenXmlElement<DXO2013DrawChart.DataLabelFieldTableCache>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.DataLabelFieldTableEntry? CreateModelElement(DXO2013DrawChart.DataLabelFieldTableEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DataLabelFieldTableEntry();
      value.TextFieldGuid = GetTextFieldGuid(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.DataLabelFieldTableCache = GetDataLabelFieldTableCache(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.DataLabelFieldTableEntry? openXmlElement, DMDrawsCharts.DataLabelFieldTableEntry? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTextFieldGuid(openXmlElement, value.TextFieldGuid, diffs, objName))
        ok = false;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      if (!CmpDataLabelFieldTableCache(openXmlElement, value.DataLabelFieldTableCache, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataLabelFieldTableEntry? value)
    where OpenXmlElementType: DXO2013DrawChart.DataLabelFieldTableEntry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextFieldGuid(openXmlElement, value?.TextFieldGuid);
      SetFormula(openXmlElement, value?.Formula);
      SetDataLabelFieldTableCache(openXmlElement, value?.DataLabelFieldTableCache);
      return openXmlElement;
    }
    return default;
  }
}
