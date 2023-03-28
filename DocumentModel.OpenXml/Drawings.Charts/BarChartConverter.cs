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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>(openXmlElement.GetFirstChild<DXDrawCharts.BarDirection>()?.Val?.Value);
  }
  
  private static bool CmpBarDirection(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>(openXmlElement.GetFirstChild<DXDrawCharts.BarDirection>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBarDirection(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarDirection>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>(itemElement, (DMDrawsCharts.BarDirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.BarDirection, DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>((DMDrawsCharts.BarDirectionKind)value));
  }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  private static DMDrawsCharts.BarGroupingKind? GetBarGrouping(DXDrawCharts.BarChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.BarGrouping>()?.Val?.Value);
  }
  
  private static bool CmpBarGrouping(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarGroupingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.BarGrouping>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBarGrouping(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarGroupingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarGrouping>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>(itemElement, (DMDrawsCharts.BarGroupingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.BarGrouping, DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>((DMDrawsCharts.BarGroupingKind)value));
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.BarChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.BarChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
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
  
  private static Collection<DMDrawsCharts.BarChartSeries>? GetBarChartSeries(DXDrawCharts.BarChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BarChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BarChartSeries>())
    {
      var newItem = DMXDrawsCharts.BarChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBarChartSeries(DXDrawCharts.BarChart openXmlElement, Collection<DMDrawsCharts.BarChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.BarChartSeries>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
        if (!DMXDrawsCharts.BarChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBarChartSeries(DXDrawCharts.BarChart openXmlElement, Collection<DMDrawsCharts.BarChartSeries>? value)
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName);
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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>()?.Val);
  }
  
  private static bool CmpGapWidth(DXDrawCharts.BarChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>()?.Val, value, diffs, objName, "GapWidth");
  }
  
  private static void SetGapWidth(DXDrawCharts.BarChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.GapWidth,System.UInt16>(openXmlElement, value);
  }
  
  private static SByte? GetOverlap(DXDrawCharts.BarChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Overlap>()?.Val);
  }
  
  private static bool CmpOverlap(DXDrawCharts.BarChart openXmlElement, SByte? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Overlap>()?.Val, value, diffs, objName, "Overlap");
  }
  
  private static void SetOverlap(DXDrawCharts.BarChart openXmlElement, SByte? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Overlap,System.SByte>(openXmlElement, value);
  }
  
  private static Collection<DMDrawsCharts.SeriesLines>? GetSeriesLines(DXDrawCharts.BarChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.SeriesLines>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SeriesLines>())
    {
      var newItem = DMXDrawsCharts.SeriesLinesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSeriesLines(DXDrawCharts.BarChart openXmlElement, Collection<DMDrawsCharts.SeriesLines>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.SeriesLines>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
        if (!DMXDrawsCharts.SeriesLinesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSeriesLines(DXDrawCharts.BarChart openXmlElement, Collection<DMDrawsCharts.SeriesLines>? value)
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
  
  private static Collection<UInt32>? GetAxisIds(DXDrawCharts.BarChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxisIds(DXDrawCharts.BarChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.AxisId>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.BarChartExtensionList>();
    if (element != null)
      return DMXDrawsCharts.BarChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBarChartExtensionList(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BarChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.BarChartExtensionList>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Charts.BarChart? CreateModelElement(DXDrawCharts.BarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChart();
      value.BarDirection = GetBarDirection(openXmlElement);
      value.BarGrouping = GetBarGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.BarChartSeries = GetBarChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.GapWidth = GetGapWidth(openXmlElement);
      value.Overlap = GetOverlap(openXmlElement);
      value.SeriesLines = GetSeriesLines(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.BarChartExtensionList = GetBarChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BarChart? openXmlElement, DMDrawsCharts.BarChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarDirection(openXmlElement, value.BarDirection, diffs, objName))
        ok = false;
      if (!CmpBarGrouping(openXmlElement, value.BarGrouping, diffs, objName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpBarChartSeries(openXmlElement, value.BarChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpGapWidth(openXmlElement, value.GapWidth, diffs, objName))
        ok = false;
      if (!CmpOverlap(openXmlElement, value.Overlap, diffs, objName))
        ok = false;
      if (!CmpSeriesLines(openXmlElement, value.SeriesLines, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpBarChartExtensionList(openXmlElement, value.BarChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarChart value)
    where OpenXmlElementType: DXDrawCharts.BarChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.BarChart openXmlElement, DMDrawsCharts.BarChart value)
  {
    SetBarDirection(openXmlElement, value?.BarDirection);
    SetBarGrouping(openXmlElement, value?.BarGrouping);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetBarChartSeries(openXmlElement, value?.BarChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetGapWidth(openXmlElement, value?.GapWidth);
    SetOverlap(openXmlElement, value?.Overlap);
    SetSeriesLines(openXmlElement, value?.SeriesLines);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetBarChartExtensionList(openXmlElement, value?.BarChartExtensionList);
  }
}
