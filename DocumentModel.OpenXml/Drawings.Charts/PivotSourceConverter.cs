namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public static class PivotSourceConverter
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  private static String? GetPivotTableName(DXDC.PivotSource openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.PivotTableName>()?.Text;
  }
  
  private static bool CmpPivotTableName(DXDC.PivotSource openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.PivotTableName>()?.Text == value;
  }
  
  private static void SetPivotTableName(DXDC.PivotSource openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PivotTableName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.PivotTableName { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  private static UInt32? GetFormatId(DXDC.PivotSource openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.FormatId>()?.Val);
  }
  
  private static bool CmpFormatId(DXDC.PivotSource openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.FormatId>()?.Val, value, diffs, objName, "FormatId");
  }
  
  private static void SetFormatId(DXDC.PivotSource openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.FormatId,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.PivotSource openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.PivotSource openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.PivotSource openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.PivotSource? CreateModelElement(DXDC.PivotSource? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.PivotSource();
      value.PivotTableName = GetPivotTableName(openXmlElement);
      value.FormatId = GetFormatId(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.PivotSource? openXmlElement, DMDC.PivotSource? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPivotTableName(openXmlElement, value.PivotTableName, diffs, objName, propName))
        ok = false;
      if (!CmpFormatId(openXmlElement, value.FormatId, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PivotSource value)
    where OpenXmlElementType: DXDC.PivotSource, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PivotSource openXmlElement, DMDC.PivotSource value)
  {
    SetPivotTableName(openXmlElement, value?.PivotTableName);
    SetFormatId(openXmlElement, value?.FormatId);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
