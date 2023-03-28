namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Line Charts converter from/to OpenXml.
///</summary>
public static class LineChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDrawsCharts.GroupingKind? GetGrouping(DXDrawCharts.LineChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.Grouping>()?.Val?.Value);
  }
  
  private static bool CmpGrouping(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.GroupingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.Grouping>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetGrouping(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.GroupingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Grouping>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(itemElement, (DMDrawsCharts.GroupingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.Grouping, DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>((DMDrawsCharts.GroupingKind)value));
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.LineChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.LineChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
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
  
  private static Collection<DMDrawsCharts.LineChartSeries>? GetLineChartSeries(DXDrawCharts.LineChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.LineChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.LineChartSeries>())
    {
      var newItem = DMXDrawsCharts.LineChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLineChartSeries(DXDrawCharts.LineChart openXmlElement, Collection<DMDrawsCharts.LineChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.LineChartSeries>();
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
        if (!DMXDrawsCharts.LineChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLineChartSeries(DXDrawCharts.LineChart openXmlElement, Collection<DMDrawsCharts.LineChartSeries>? value)
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DropLines>();
    if (element != null)
      return DMXDrawsCharts.DropLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLines(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.DropLines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DropLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DropLines>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.HighLowLines>();
    if (element != null)
      return DMXDrawsCharts.HighLowLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHighLowLines(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.HighLowLines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.HighLowLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.HighLowLines>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.UpDownBars>();
    if (element != null)
      return DMXDrawsCharts.UpDownBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUpDownBars(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.UpDownBars? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.UpDownBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.UpDownBars>(), value, diffs, objName);
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
    return openXmlElement.GetFirstChild<DXDrawCharts.ShowMarker>() != null;
  }
  
  private static bool CmpShowMarker(DXDrawCharts.LineChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ShowMarker>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ShowMarker", val, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXDrawCharts.Smooth>() != null;
  }
  
  private static bool CmpSmooth(DXDrawCharts.LineChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Smooth>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Smooth", val, value);
    return false;
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
  
  private static Collection<UInt32>? GetAxisIds(DXDrawCharts.LineChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDrawCharts.LineChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.LineChartExtensionList>();
    if (element != null)
      return DMXDrawsCharts.LineChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineChartExtensionList(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.LineChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LineChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.LineChartExtensionList>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Charts.LineChart? CreateModelElement(DXDrawCharts.LineChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.LineChartSeries = GetLineChartSeries(openXmlElement);
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
  
  public static bool CompareModelElement(DXDrawCharts.LineChart? openXmlElement, DMDrawsCharts.LineChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGrouping(openXmlElement, value.Grouping, diffs, objName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpLineChartSeries(openXmlElement, value.LineChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpDropLines(openXmlElement, value.DropLines, diffs, objName))
        ok = false;
      if (!CmpHighLowLines(openXmlElement, value.HighLowLines, diffs, objName))
        ok = false;
      if (!CmpUpDownBars(openXmlElement, value.UpDownBars, diffs, objName))
        ok = false;
      if (!CmpShowMarker(openXmlElement, value.ShowMarker, diffs, objName))
        ok = false;
      if (!CmpSmooth(openXmlElement, value.Smooth, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpLineChartExtensionList(openXmlElement, value.LineChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.LineChart value)
    where OpenXmlElementType: DXDrawCharts.LineChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.LineChart openXmlElement, DMDrawsCharts.LineChart value)
  {
    SetGrouping(openXmlElement, value?.Grouping);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetLineChartSeries(openXmlElement, value?.LineChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetDropLines(openXmlElement, value?.DropLines);
    SetHighLowLines(openXmlElement, value?.HighLowLines);
    SetUpDownBars(openXmlElement, value?.UpDownBars);
    SetShowMarker(openXmlElement, value?.ShowMarker);
    SetSmooth(openXmlElement, value?.Smooth);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetLineChartExtensionList(openXmlElement, value?.LineChartExtensionList);
  }
}
