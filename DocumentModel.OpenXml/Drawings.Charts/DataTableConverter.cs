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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowHorizontalBorder>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowVerticalBorder>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowOutlineBorder>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowKeys>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
