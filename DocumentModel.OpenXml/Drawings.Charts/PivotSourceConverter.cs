namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public static class PivotSourceConverter
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  private static String? GetPivotTableName(DXDrawCharts.PivotSource openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.PivotTableName>()?.Text;
  }
  
  private static bool CmpPivotTableName(DXDrawCharts.PivotSource openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawCharts.PivotTableName>()?.Text == value;
  }
  
  private static void SetPivotTableName(DXDrawCharts.PivotSource openXmlElement, String? value)
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
  private static UInt32? GetFormatId(DXDrawCharts.PivotSource openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.FormatId>()?.Val?.Value;
  }
  
  private static bool CmpFormatId(DXDrawCharts.PivotSource openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.FormatId>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.FormatId", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetFormatId(DXDrawCharts.PivotSource openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.FormatId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.FormatId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.PivotSource openXmlElement)
  {
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawCharts.PivotSource openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.PivotSource openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.PivotSource? CreateModelElement(DXDrawCharts.PivotSource? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PivotSource();
      value.PivotTableName = GetPivotTableName(openXmlElement);
      value.FormatId = GetFormatId(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.PivotSource? openXmlElement, DMDrawsCharts.PivotSource? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PivotSource? value)
    where OpenXmlElementType: DXDrawCharts.PivotSource, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPivotTableName(openXmlElement, value?.PivotTableName);
      SetFormatId(openXmlElement, value?.FormatId);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
