namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Line Charts.
/// </summary>
public static class LineChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDrawsCharts.GroupingKind? GetGrouping(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Grouping>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetGrouping(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.GroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.LineChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.LineChartSeries> GetLineChartSerieses(DXDrawCharts.LineChart openXmlElement)
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
  
  private static void SetLineChartSerieses(DXDrawCharts.LineChart openXmlElement, Collection<DMDrawsCharts.LineChartSeries>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static DMDrawsCharts.DropLines? GetDropLines(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DropLines>();
    if (itemElement != null)
      return DMXDrawsCharts.DropLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropLines(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.DropLines? value)
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
  
  private static DMDrawsCharts.HighLowLines? GetHighLowLines(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.HighLowLines>();
    if (itemElement != null)
      return DMXDrawsCharts.HighLowLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHighLowLines(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.HighLowLines? value)
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
  
  private static DMDrawsCharts.UpDownBars? GetUpDownBars(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.UpDownBars>();
    if (itemElement != null)
      return DMXDrawsCharts.UpDownBarsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUpDownBars(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.UpDownBars? value)
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
  
  private static Boolean? GetShowMarker(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowMarker>();
    return itemElement != null;
  }
  
  private static void SetShowMarker(DXDrawCharts.LineChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShowMarker>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ShowMarker();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSmooth(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Smooth>();
    return itemElement != null;
  }
  
  private static void SetSmooth(DXDrawCharts.LineChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Smooth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Smooth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.LineChart openXmlElement)
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
  
  private static void SetAxisIds(DXDrawCharts.LineChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.LineChartExtensionList? GetLineChartExtensionList(DXDrawCharts.LineChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.LineChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.LineChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineChartExtensionList(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.LineChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LineChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LineChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.LineChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.LineChart? CreateModelElement(DXDrawCharts.LineChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.LineChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.LineChartSerieses = GetLineChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.HighLowLines = GetHighLowLines(openXmlElement);
      value.UpDownBars = GetUpDownBars(openXmlElement);
      value.ShowMarker = GetShowMarker(openXmlElement);
      value.Smooth = GetSmooth(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.LineChartExtensionList = GetLineChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.LineChart? value)
    where OpenXmlElementType: DXDrawCharts.LineChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGrouping(openXmlElement, value?.Grouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetLineChartSerieses(openXmlElement, value?.LineChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetHighLowLines(openXmlElement, value?.HighLowLines);
      SetUpDownBars(openXmlElement, value?.UpDownBars);
      SetShowMarker(openXmlElement, value?.ShowMarker);
      SetSmooth(openXmlElement, value?.Smooth);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetLineChartExtensionList(openXmlElement, value?.LineChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
