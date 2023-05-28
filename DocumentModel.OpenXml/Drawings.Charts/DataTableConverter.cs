namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Data Table.
/// </summary>
public static class DataTableConverter
{
  /// <summary>
  /// Show Horizontal Border.
  /// </summary>
  private static Boolean? GetShowHorizontalBorder(DXDC.DataTable openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowHorizontalBorder>() != null;
  }
  
  private static bool CmpShowHorizontalBorder(DXDC.DataTable openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowHorizontalBorder>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowHorizontalBorder", val, value);
    return false;
  }
  
  private static void SetShowHorizontalBorder(DXDC.DataTable openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowHorizontalBorder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowHorizontalBorder();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Show Vertical Border.
  /// </summary>
  private static Boolean? GetShowVerticalBorder(DXDC.DataTable openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowVerticalBorder>() != null;
  }
  
  private static bool CmpShowVerticalBorder(DXDC.DataTable openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowVerticalBorder>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowVerticalBorder", val, value);
    return false;
  }
  
  private static void SetShowVerticalBorder(DXDC.DataTable openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowVerticalBorder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowVerticalBorder();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Show Outline Border.
  /// </summary>
  private static Boolean? GetShowOutlineBorder(DXDC.DataTable openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowOutlineBorder>() != null;
  }
  
  private static bool CmpShowOutlineBorder(DXDC.DataTable openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowOutlineBorder>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowOutlineBorder", val, value);
    return false;
  }
  
  private static void SetShowOutlineBorder(DXDC.DataTable openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowOutlineBorder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowOutlineBorder();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Show Legend Keys.
  /// </summary>
  private static Boolean? GetShowKeys(DXDC.DataTable openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowKeys>() != null;
  }
  
  private static bool CmpShowKeys(DXDC.DataTable openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowKeys>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowKeys", val, value);
    return false;
  }
  
  private static void SetShowKeys(DXDC.DataTable openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowKeys>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowKeys();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.DataTable openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.DataTable openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXDC.DataTable openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  private static DMDC.TextProperties? GetTextProperties(DXDC.DataTable openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.DataTable openXmlElement, DMDC.TextProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTextProperties(DXDC.DataTable openXmlElement, DMDC.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDC.ExtensionList? GetExtensionList(DXDC.DataTable openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.DataTable openXmlElement, DMDC.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDC.DataTable openXmlElement, DMDC.ExtensionList? value)
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
  
  public static DMD.Charts.DataTable? CreateModelElement(DXDC.DataTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.DataTable();
      value.ShowHorizontalBorder = GetShowHorizontalBorder(openXmlElement);
      value.ShowVerticalBorder = GetShowVerticalBorder(openXmlElement);
      value.ShowOutlineBorder = GetShowOutlineBorder(openXmlElement);
      value.ShowKeys = GetShowKeys(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DataTable? openXmlElement, DMDC.DataTable? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShowHorizontalBorder(openXmlElement, value.ShowHorizontalBorder, diffs, objName, propName))
        ok = false;
      if (!CmpShowVerticalBorder(openXmlElement, value.ShowVerticalBorder, diffs, objName, propName))
        ok = false;
      if (!CmpShowOutlineBorder(openXmlElement, value.ShowOutlineBorder, diffs, objName, propName))
        ok = false;
      if (!CmpShowKeys(openXmlElement, value.ShowKeys, diffs, objName, propName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DataTable value)
    where OpenXmlElementType: DXDC.DataTable, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DataTable openXmlElement, DMDC.DataTable value)
  {
    SetShowHorizontalBorder(openXmlElement, value?.ShowHorizontalBorder);
    SetShowVerticalBorder(openXmlElement, value?.ShowVerticalBorder);
    SetShowOutlineBorder(openXmlElement, value?.ShowOutlineBorder);
    SetShowKeys(openXmlElement, value?.ShowKeys);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetTextProperties(openXmlElement, value?.TextProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
