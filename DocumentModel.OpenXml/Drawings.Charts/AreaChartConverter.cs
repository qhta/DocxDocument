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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.Grouping>()?.Val?.Value);
  }
  
  private static bool CmpGrouping(DXDrawCharts.AreaChart openXmlElement, DMDrawsCharts.GroupingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.Grouping>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.AreaChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
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
  
  private static Collection<DMDrawsCharts.AreaChartSeries> GetAreaChartSeries(DXDrawCharts.AreaChart openXmlElement)
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
  
  private static bool CmpAreaChartSeries(DXDrawCharts.AreaChart openXmlElement, Collection<DMDrawsCharts.AreaChartSeries>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.AreaChartSeries>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsCharts.AreaChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAreaChartSeries(DXDrawCharts.AreaChart openXmlElement, Collection<DMDrawsCharts.AreaChartSeries>? value)
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
    return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>());
  }
  
  private static bool CmpDataLabels(DXDrawCharts.AreaChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsCharts.DropLinesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DropLines>());
  }
  
  private static bool CmpDropLines(DXDrawCharts.AreaChart openXmlElement, DMDrawsCharts.DropLines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DropLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DropLines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpAxisIds(DXDrawCharts.AreaChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.AxisId>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!UInt32ValueConverter.CmpValue(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
    return DMXDrawsCharts.AreaChartExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.AreaChartExtensionList>());
  }
  
  private static bool CmpAreaChartExtensionList(DXDrawCharts.AreaChart openXmlElement, DMDrawsCharts.AreaChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.AreaChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.AreaChartExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
      value.AreaChartSeries = GetAreaChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.AreaChartExtensionList = GetAreaChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.AreaChart? openXmlElement, DMDrawsCharts.AreaChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGrouping(openXmlElement, value.Grouping, diffs, objName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpAreaChartSeries(openXmlElement, value.AreaChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpDropLines(openXmlElement, value.DropLines, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpAreaChartExtensionList(openXmlElement, value.AreaChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.AreaChart? value)
    where OpenXmlElementType: DXDrawCharts.AreaChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGrouping(openXmlElement, value?.Grouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetAreaChartSeries(openXmlElement, value?.AreaChartSeries);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetAreaChartExtensionList(openXmlElement, value?.AreaChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
