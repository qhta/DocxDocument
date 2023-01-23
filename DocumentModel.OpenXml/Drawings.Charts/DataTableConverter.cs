namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Data Table.
/// </summary>
public static class DataTableConverter
{
  /// <summary>
  /// Show Horizontal Border.
  /// </summary>
  private static Boolean? GetShowHorizontalBorder(DXDrawCharts.DataTable openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowHorizontalBorder>() != null;
  }
  
  private static bool CmpShowHorizontalBorder(DXDrawCharts.DataTable openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowHorizontalBorder>() != null == value;
  }
  
  private static void SetShowHorizontalBorder(DXDrawCharts.DataTable openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowHorizontalBorder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowHorizontalBorder();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Show Vertical Border.
  /// </summary>
  private static Boolean? GetShowVerticalBorder(DXDrawCharts.DataTable openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowVerticalBorder>() != null;
  }
  
  private static bool CmpShowVerticalBorder(DXDrawCharts.DataTable openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowVerticalBorder>() != null == value;
  }
  
  private static void SetShowVerticalBorder(DXDrawCharts.DataTable openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowVerticalBorder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowVerticalBorder();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Show Outline Border.
  /// </summary>
  private static Boolean? GetShowOutlineBorder(DXDrawCharts.DataTable openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowOutlineBorder>() != null;
  }
  
  private static bool CmpShowOutlineBorder(DXDrawCharts.DataTable openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowOutlineBorder>() != null == value;
  }
  
  private static void SetShowOutlineBorder(DXDrawCharts.DataTable openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowOutlineBorder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowOutlineBorder();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Show Legend Keys.
  /// </summary>
  private static Boolean? GetShowKeys(DXDrawCharts.DataTable openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowKeys>() != null;
  }
  
  private static bool CmpShowKeys(DXDrawCharts.DataTable openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowKeys>() != null == value;
  }
  
  private static void SetShowKeys(DXDrawCharts.DataTable openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowKeys>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowKeys();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.DataTable openXmlElement)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>());
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.DataTable openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.DataTable openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.DataTable openXmlElement)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>());
  }
  
  private static bool CmpTextProperties(DXDrawCharts.DataTable openXmlElement, DMDrawsCharts.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.TextPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextProperties(DXDrawCharts.DataTable openXmlElement, DMDrawsCharts.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TextPropertiesConverter.CreateOpenXmlElement<DXDrawCharts.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.DataTable openXmlElement)
  {
    return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawCharts.DataTable openXmlElement, DMDrawsCharts.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawCharts.DataTable openXmlElement, DMDrawsCharts.ExtensionList? value)
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
  
  public static DMDrawsCharts.DataTable? CreateModelElement(DXDrawCharts.DataTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DataTable();
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
  
  public static bool CompareModelElement(DXDrawCharts.DataTable? openXmlElement, DMDrawsCharts.DataTable? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShowHorizontalBorder(openXmlElement, value.ShowHorizontalBorder, diffs, objName))
        ok = false;
      if (!CmpShowVerticalBorder(openXmlElement, value.ShowVerticalBorder, diffs, objName))
        ok = false;
      if (!CmpShowOutlineBorder(openXmlElement, value.ShowOutlineBorder, diffs, objName))
        ok = false;
      if (!CmpShowKeys(openXmlElement, value.ShowKeys, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DataTable? value)
    where OpenXmlElementType: DXDrawCharts.DataTable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShowHorizontalBorder(openXmlElement, value?.ShowHorizontalBorder);
      SetShowVerticalBorder(openXmlElement, value?.ShowVerticalBorder);
      SetShowOutlineBorder(openXmlElement, value?.ShowOutlineBorder);
      SetShowKeys(openXmlElement, value?.ShowKeys);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
