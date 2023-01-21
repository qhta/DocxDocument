namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Stock Charts.
/// </summary>
public static class StockChartConverter
{
  private static Collection<DMDrawsCharts.LineChartSeries> GetLineChartSerieses(DXDrawCharts.StockChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.LineChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.LineChartSeries>())
    {
      var newItem = DMXDrawsCharts.LineChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetLineChartSerieses(DXDrawCharts.StockChart openXmlElement, Collection<DMDrawsCharts.LineChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.LineChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.LineChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.LineChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.StockChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.StockChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static DMDrawsCharts.DropLines? GetDropLines(DXDrawCharts.StockChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DropLines>();
    if (itemElement != null)
      return DMXDrawsCharts.DropLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropLines(DXDrawCharts.StockChart openXmlElement, DMDrawsCharts.DropLines? value)
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
  
  private static DMDrawsCharts.HighLowLines? GetHighLowLines(DXDrawCharts.StockChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.HighLowLines>();
    if (itemElement != null)
      return DMXDrawsCharts.HighLowLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHighLowLines(DXDrawCharts.StockChart openXmlElement, DMDrawsCharts.HighLowLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.HighLowLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.HighLowLinesConverter.CreateOpenXmlElement<DXDrawCharts.HighLowLines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.UpDownBars? GetUpDownBars(DXDrawCharts.StockChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.UpDownBars>();
    if (itemElement != null)
      return DMXDrawsCharts.UpDownBarsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUpDownBars(DXDrawCharts.StockChart openXmlElement, DMDrawsCharts.UpDownBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.UpDownBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.UpDownBarsConverter.CreateOpenXmlElement<DXDrawCharts.UpDownBars>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.StockChart openXmlElement)
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
  
  private static void SetAxisIds(DXDrawCharts.StockChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.StockChartExtensionList? GetStockChartExtensionList(DXDrawCharts.StockChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StockChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.StockChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStockChartExtensionList(DXDrawCharts.StockChart openXmlElement, DMDrawsCharts.StockChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StockChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StockChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.StockChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.StockChart? CreateModelElement(DXDrawCharts.StockChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StockChart();
      value.LineChartSerieses = GetLineChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.HighLowLines = GetHighLowLines(openXmlElement);
      value.UpDownBars = GetUpDownBars(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.StockChartExtensionList = GetStockChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StockChart? value)
    where OpenXmlElementType: DXDrawCharts.StockChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineChartSerieses(openXmlElement, value?.LineChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetHighLowLines(openXmlElement, value?.HighLowLines);
      SetUpDownBars(openXmlElement, value?.UpDownBars);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetStockChartExtensionList(openXmlElement, value?.StockChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
