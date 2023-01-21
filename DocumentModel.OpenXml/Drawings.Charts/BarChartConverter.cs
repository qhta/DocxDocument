namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bar Charts.
/// </summary>
public static class BarChartConverter
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  private static DMDrawsCharts.BarDirectionKind? GetBarDirection(DXDrawCharts.BarChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarDirection>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBarDirection(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.BarDirection, DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  private static DMDrawsCharts.BarGroupingKind? GetBarGrouping(DXDrawCharts.BarChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarGrouping>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBarGrouping(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarGroupingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarGrouping>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.BarGrouping, DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.BarChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.BarChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.BarChartSeries> GetBarChartSerieses(DXDrawCharts.BarChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BarChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BarChartSeries>())
    {
      var newItem = DMXDrawsCharts.BarChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetBarChartSerieses(DXDrawCharts.BarChart openXmlElement, Collection<DMDrawsCharts.BarChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BarChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BarChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.BarChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.BarChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static UInt16? GetGapWidth(DXDrawCharts.BarChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGapWidth(DXDrawCharts.BarChart openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.GapWidth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static SByte? GetOverlap(DXDrawCharts.BarChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Overlap>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetOverlap(DXDrawCharts.BarChart openXmlElement, SByte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Overlap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Overlap{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.SeriesLines> GetSeriesLineses(DXDrawCharts.BarChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SeriesLines>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SeriesLines>())
    {
      var newItem = DMXDrawsCharts.SeriesLinesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetSeriesLineses(DXDrawCharts.BarChart openXmlElement, Collection<DMDrawsCharts.SeriesLines>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SeriesLines>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.SeriesLinesConverter.CreateOpenXmlElement<DXDrawCharts.SeriesLines>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.BarChart openXmlElement)
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
  
  private static void SetAxisIds(DXDrawCharts.BarChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.BarChartExtensionList? GetBarChartExtensionList(DXDrawCharts.BarChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BarChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.BarChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBarChartExtensionList(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BarChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.BarChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.BarChart? CreateModelElement(DXDrawCharts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BarChart();
      value.BarDirection = GetBarDirection(openXmlElement);
      value.BarGrouping = GetBarGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BarChartSerieses = GetBarChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.GapWidth = GetGapWidth(openXmlElement);
      value.Overlap = GetOverlap(openXmlElement);
      value.SeriesLineses = GetSeriesLineses(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.BarChartExtensionList = GetBarChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarChart? value)
    where OpenXmlElementType: DXDrawCharts.BarChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarDirection(openXmlElement, value?.BarDirection);
      SetBarGrouping(openXmlElement, value?.BarGrouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetBarChartSerieses(openXmlElement, value?.BarChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetGapWidth(openXmlElement, value?.GapWidth);
      SetOverlap(openXmlElement, value?.Overlap);
      SetSeriesLineses(openXmlElement, value?.SeriesLineses);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetBarChartExtensionList(openXmlElement, value?.BarChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
