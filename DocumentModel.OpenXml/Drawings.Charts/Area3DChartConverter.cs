namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Area Charts converter from/to OpenXml.
///</summary>
public static class Area3DChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDrawsCharts.GroupingKind? GetGrouping(DXDrawCharts.Area3DChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.Grouping>()?.Val?.Value);
  }
  
  private static bool CmpGrouping(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.GroupingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDrawsCharts.GroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.Grouping>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetGrouping(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.GroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDrawCharts.Area3DChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.Area3DChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
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
  
  private static Collection<DMDrawsCharts.AreaChartSeries>? GetAreaChartSeries(DXDrawCharts.Area3DChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.AreaChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.AreaChartSeries>())
    {
      var newItem = DMXDrawsCharts.AreaChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAreaChartSeries(DXDrawCharts.Area3DChart openXmlElement, Collection<DMDrawsCharts.AreaChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.AreaChartSeries>();
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
        if (!DMXDrawsCharts.AreaChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAreaChartSeries(DXDrawCharts.Area3DChart openXmlElement, Collection<DMDrawsCharts.AreaChartSeries>? value)
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DropLines>();
    if (element != null)
      return DMXDrawsCharts.DropLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLines(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.DropLines? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DropLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DropLines>(), value, diffs, objName);
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
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.GapDepth>()?.Val);
  }
  
  private static bool CmpGapDepth(DXDrawCharts.Area3DChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.GapDepth>()?.Val, value, diffs, objName, "GapDepth");
  }
  
  private static void SetGapDepth(DXDrawCharts.Area3DChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.GapDepth,System.UInt16>(openXmlElement, value);
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDrawCharts.Area3DChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDrawCharts.Area3DChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
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
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Area3DChartExtensionList>();
    if (element != null)
      return DMXDrawsCharts.Area3DChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArea3DChartExtensionList(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.Area3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Area3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Area3DChartExtensionList>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Charts.Area3DChart? CreateModelElement(DXDrawCharts.Area3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Area3DChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.AreaChartSeries = GetAreaChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.GapDepth = GetGapDepth(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Area3DChartExtensionList = GetArea3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Area3DChart? openXmlElement, DMDrawsCharts.Area3DChart? value, DiffList? diffs, string? objName)
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
      if (!CmpGapDepth(openXmlElement, value.GapDepth, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpArea3DChartExtensionList(openXmlElement, value.Area3DChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Area3DChart value)
    where OpenXmlElementType: DXDrawCharts.Area3DChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.Area3DChart openXmlElement, DMDrawsCharts.Area3DChart value)
  {
    SetGrouping(openXmlElement, value?.Grouping);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetAreaChartSeries(openXmlElement, value?.AreaChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetDropLines(openXmlElement, value?.DropLines);
    SetGapDepth(openXmlElement, value?.GapDepth);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetArea3DChartExtensionList(openXmlElement, value?.Area3DChartExtensionList);
  }
}
