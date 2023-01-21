namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Area Charts.
/// </summary>
public static class AreaChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDrawsCharts.GroupingKind? GetGrouping(DXDrawCharts.AreaChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Grouping>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetGrouping(DXDrawCharts.AreaChart openXmlElement, DMDrawsCharts.GroupingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Grouping>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.Grouping, DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.AreaChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.AreaChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.AreaChartSeries> GetAreaChartSerieses(DXDrawCharts.AreaChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.AreaChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AreaChartSeries>())
    {
      var newItem = DMXDrawsCharts.AreaChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetAreaChartSerieses(DXDrawCharts.AreaChart openXmlElement, Collection<DMDrawsCharts.AreaChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.AreaChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.AreaChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.AreaChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.AreaChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.AreaChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static DMDrawsCharts.DropLines? GetDropLines(DXDrawCharts.AreaChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DropLines>();
    if (itemElement != null)
      return DMXDrawsCharts.DropLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropLines(DXDrawCharts.AreaChart openXmlElement, DMDrawsCharts.DropLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DropLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DropLinesConverter.CreateOpenXmlElement<DXDrawCharts.DropLines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.AreaChart openXmlElement)
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
  
  private static void SetAxisIds(DXDrawCharts.AreaChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.AreaChartExtensionList? GetAreaChartExtensionList(DXDrawCharts.AreaChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.AreaChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.AreaChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAreaChartExtensionList(DXDrawCharts.AreaChart openXmlElement, DMDrawsCharts.AreaChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.AreaChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.AreaChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.AreaChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.AreaChart? CreateModelElement(DXDrawCharts.AreaChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.AreaChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.AreaChartSerieses = GetAreaChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.AreaChartExtensionList = GetAreaChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.AreaChart? value)
    where OpenXmlElementType: DXDrawCharts.AreaChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGrouping(openXmlElement, value?.Grouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetAreaChartSerieses(openXmlElement, value?.AreaChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetAreaChartExtensionList(openXmlElement, value?.AreaChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
