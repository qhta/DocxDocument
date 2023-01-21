namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public static class Bar3DChartConverter
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  private static DMDrawsCharts.BarDirectionKind? GetBarDirection(DXDrawCharts.Bar3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarDirection>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBarDirection(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.BarDirectionKind? value)
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
  private static DMDrawsCharts.BarGroupingKind? GetBarGrouping(DXDrawCharts.Bar3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarGrouping>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBarGrouping(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.BarGroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDrawCharts.Bar3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DXDrawCharts.Bar3DChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.BarChartSeries> GetBarChartSerieses(DXDrawCharts.Bar3DChart openXmlElement)
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
  
  private static void SetBarChartSerieses(DXDrawCharts.Bar3DChart openXmlElement, Collection<DMDrawsCharts.BarChartSeries>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.Bar3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static UInt16? GetGapWidth(DXDrawCharts.Bar3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGapWidth(DXDrawCharts.Bar3DChart openXmlElement, UInt16? value)
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
  
  private static UInt16? GetGapDepth(DXDrawCharts.Bar3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapDepth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGapDepth(DXDrawCharts.Bar3DChart openXmlElement, UInt16? value)
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
  
  private static DMDrawsCharts.ShapeKind? GetShape(DXDrawCharts.Bar3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Shape>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDrawsCharts.ShapeKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetShape(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.ShapeKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Shape>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.Shape, DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDrawsCharts.ShapeKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<UInt32> GetAxisIds(DXDrawCharts.Bar3DChart openXmlElement)
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
  
  private static void SetAxisIds(DXDrawCharts.Bar3DChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.Bar3DChartExtensionList? GetBar3DChartExtensionList(DXDrawCharts.Bar3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Bar3DChartExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.Bar3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBar3DChartExtensionList(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.Bar3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bar3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Bar3DChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.Bar3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Bar3DChart? CreateModelElement(DXDrawCharts.Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Bar3DChart();
      value.BarDirection = GetBarDirection(openXmlElement);
      value.BarGrouping = GetBarGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BarChartSerieses = GetBarChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.GapWidth = GetGapWidth(openXmlElement);
      value.GapDepth = GetGapDepth(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Bar3DChartExtensionList = GetBar3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Bar3DChart? value)
    where OpenXmlElementType: DXDrawCharts.Bar3DChart, new()
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
      SetGapDepth(openXmlElement, value?.GapDepth);
      SetShape(openXmlElement, value?.Shape);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetBar3DChartExtensionList(openXmlElement, value?.Bar3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
