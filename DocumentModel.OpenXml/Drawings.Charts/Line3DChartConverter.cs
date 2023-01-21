namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
public static class Line3DChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDrawsCharts.GroupingKind? GetGrouping(DXDrawCharts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Grouping>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetGrouping(DXDrawCharts.Line3DChart openXmlElement, DMDrawsCharts.GroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDrawCharts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.Line3DChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.LineChartSeries> GetLineChartSerieses(DXDrawCharts.Line3DChart openXmlElement)
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
  
  private static void SetLineChartSerieses(DXDrawCharts.Line3DChart openXmlElement, Collection<DMDrawsCharts.LineChartSeries>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.Line3DChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static DMDrawsCharts.DropLines? GetDropLines(DXDrawCharts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DropLines>();
    if (itemElement != null)
      return DMXDrawsCharts.DropLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropLines(DXDrawCharts.Line3DChart openXmlElement, DMDrawsCharts.DropLines? value)
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
  
  private static UInt16? GetGapDepth(DXDrawCharts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapDepth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGapDepth(DXDrawCharts.Line3DChart openXmlElement, UInt16? value)
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
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.Line3DChart openXmlElement)
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
  
  private static void SetAxisIds(DXDrawCharts.Line3DChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.Line3DChartExtensionList? GetLine3DChartExtensionList(DXDrawCharts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Line3DChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.Line3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLine3DChartExtensionList(DXDrawCharts.Line3DChart openXmlElement, DMDrawsCharts.Line3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Line3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Line3DChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.Line3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Line3DChart? CreateModelElement(DXDrawCharts.Line3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Line3DChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.LineChartSerieses = GetLineChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.GapDepth = GetGapDepth(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Line3DChartExtensionList = GetLine3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Line3DChart? value)
    where OpenXmlElementType: DXDrawCharts.Line3DChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGrouping(openXmlElement, value?.Grouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetLineChartSerieses(openXmlElement, value?.LineChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetGapDepth(openXmlElement, value?.GapDepth);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetLine3DChartExtensionList(openXmlElement, value?.Line3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
