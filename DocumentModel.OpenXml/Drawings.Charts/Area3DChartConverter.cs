namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Area Charts.
/// </summary>
public static class Area3DChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDrawsCharts.GroupingKind? GetGrouping(DXDrawCharts.Area3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Grouping>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetGrouping(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.GroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDrawCharts.Area3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.Area3DChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.AreaChartSeries> GetAreaChartSerieses(DXDrawCharts.Area3DChart openXmlElement)
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
  
  private static void SetAreaChartSerieses(DXDrawCharts.Area3DChart openXmlElement, Collection<DMDrawsCharts.AreaChartSeries>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.Area3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static DMDrawsCharts.DropLines? GetDropLines(DXDrawCharts.Area3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DropLines>();
    if (itemElement != null)
      return DMXDrawsCharts.DropLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropLines(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.DropLines? value)
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
  
  private static UInt16? GetGapDepth(DXDrawCharts.Area3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapDepth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGapDepth(DXDrawCharts.Area3DChart openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.GapDepth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.GapDepth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.Area3DChart openXmlElement)
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
  
  private static void SetAxisIds(DXDrawCharts.Area3DChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.Area3DChartExtensionList? GetArea3DChartExtensionList(DXDrawCharts.Area3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Area3DChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.Area3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArea3DChartExtensionList(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.Area3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Area3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Area3DChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.Area3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Area3DChart? CreateModelElement(DXDrawCharts.Area3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Area3DChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.AreaChartSerieses = GetAreaChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.GapDepth = GetGapDepth(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Area3DChartExtensionList = GetArea3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Area3DChart? value)
    where OpenXmlElementType: DXDrawCharts.Area3DChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGrouping(openXmlElement, value?.Grouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetAreaChartSerieses(openXmlElement, value?.AreaChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetGapDepth(openXmlElement, value?.GapDepth);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetArea3DChartExtensionList(openXmlElement, value?.Area3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
