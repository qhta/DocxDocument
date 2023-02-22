namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public static class PivotSource3Converter
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  private static String? GetPivotTableName(DXO2013DrawChart.PivotSource openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.PivotTableName>()?.Text;
  }
  
  private static bool CmpPivotTableName(DXO2013DrawChart.PivotSource openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.PivotTableName>()?.Text == value;
  }
  
  private static void SetPivotTableName(DXO2013DrawChart.PivotSource openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PivotTableName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.PivotTableName { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  private static UInt32? GetFormatId(DXO2013DrawChart.PivotSource openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.FormatId>()?.Val);
  }
  
  private static bool CmpFormatId(DXO2013DrawChart.PivotSource openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.FormatId>()?.Val, value, diffs, objName, "FormatId");
  }
  
  private static void SetFormatId(DXO2013DrawChart.PivotSource openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.FormatId,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXO2013DrawChart.PivotSource openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2013DrawChart.PivotSource openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2013DrawChart.PivotSource openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PivotSource3? CreateModelElement(DXO2013DrawChart.PivotSource? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotSource3();
      value.PivotTableName = GetPivotTableName(openXmlElement);
      value.FormatId = GetFormatId(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.PivotSource? openXmlElement, DMDrawsCharts.PivotSource3? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPivotTableName(openXmlElement, value.PivotTableName, diffs, objName))
        ok = false;
      if (!CmpFormatId(openXmlElement, value.FormatId, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PivotSource3 value)
    where OpenXmlElementType: DXO2013DrawChart.PivotSource, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.PivotSource openXmlElement, DMDrawsCharts.PivotSource3 value)
  {
    SetPivotTableName(openXmlElement, value?.PivotTableName);
    SetFormatId(openXmlElement, value?.FormatId);
    SetExtensionList(openXmlElement, value?.ExtensionList);
    }
  }
