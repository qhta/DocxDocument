namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public static class ScatterChartConverter
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  private static DMDrawsCharts.ScatterStyleKind? GetScatterStyle(DXDrawCharts.ScatterChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ScatterStyle>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDrawsCharts.ScatterStyleKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetScatterStyle(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.ScatterStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ScatterStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.ScatterStyle, DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDrawsCharts.ScatterStyleKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.ScatterChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.ScatterChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.VaryColors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.ScatterChartSeries> GetScatterChartSerieses(DXDrawCharts.ScatterChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ScatterChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ScatterChartSeries>())
    {
      var newItem = DMXDrawsCharts.ScatterChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetScatterChartSerieses(DXDrawCharts.ScatterChart openXmlElement, Collection<DMDrawsCharts.ScatterChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ScatterChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ScatterChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.ScatterChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.ScatterChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabelsConverter.CreateOpenXmlElement<DXDrawCharts.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.ScatterChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetAxisIds(DXDrawCharts.ScatterChart openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXDrawCharts.AxisId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.ScatterChartExtensionList? GetScatterChartExtensionList(DXDrawCharts.ScatterChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ScatterChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ScatterChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScatterChartExtensionList(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.ScatterChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ScatterChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ScatterChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ScatterChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.ScatterChart? CreateModelElement(DXDrawCharts.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ScatterChart();
      value.ScatterStyle = GetScatterStyle(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.ScatterChartSerieses = GetScatterChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.ScatterChartExtensionList = GetScatterChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterChart? value)
    where OpenXmlElementType: DXDrawCharts.ScatterChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterStyle(openXmlElement, value?.ScatterStyle);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetScatterChartSerieses(openXmlElement, value?.ScatterChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetScatterChartExtensionList(openXmlElement, value?.ScatterChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
