namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bar Charts.
/// </summary>
public static class BarChartConverter
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  private static DMDC.BarDirectionKind? GetBarDirection(DXDC.BarChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>(openXmlElement.GetFirstChild<DXDC.BarDirection>()?.Val?.Value);
  }
  
  private static bool CmpBarDirection(DXDC.BarChart openXmlElement, DMDC.BarDirectionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>(openXmlElement.GetFirstChild<DXDC.BarDirection>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBarDirection(DXDC.BarChart openXmlElement, DMDC.BarDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BarDirection>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>(itemElement, (DMDC.BarDirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.BarDirection, DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>((DMDC.BarDirectionKind)value));
  }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  private static DMDC.BarGroupingKind? GetBarGrouping(DXDC.BarChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>(openXmlElement.GetFirstChild<DXDC.BarGrouping>()?.Val?.Value);
  }
  
  private static bool CmpBarGrouping(DXDC.BarChart openXmlElement, DMDC.BarGroupingKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>(openXmlElement.GetFirstChild<DXDC.BarGrouping>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBarGrouping(DXDC.BarChart openXmlElement, DMDC.BarGroupingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BarGrouping>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>(itemElement, (DMDC.BarGroupingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.BarGrouping, DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>((DMDC.BarGroupingKind)value));
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.BarChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.BarChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.BarChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.VaryColors();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<DMDC.BarChartSeries>? GetBarChartSeries(DXDC.BarChart openXmlElement)
  {
    var collection = new Collection<DMDC.BarChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDC.BarChartSeries>())
    {
      var newItem = DMXDC.BarChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBarChartSeries(DXDC.BarChart openXmlElement, Collection<DMDC.BarChartSeries>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.BarChartSeries>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDC.BarChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBarChartSeries(DXDC.BarChart openXmlElement, Collection<DMDC.BarChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.BarChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.BarChartSeriesConverter.CreateOpenXmlElement<DXDC.BarChartSeries>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.BarChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.BarChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.BarChart openXmlElement, DMDC.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static UInt16? GetGapWidth(DXDC.BarChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.GapWidth>()?.Val);
  }
  
  private static bool CmpGapWidth(DXDC.BarChart openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.GapWidth>()?.Val, value, diffs, objName, "GapWidth");
  }
  
  private static void SetGapWidth(DXDC.BarChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.GapWidth,System.UInt16>(openXmlElement, value);
  }
  
  private static SByte? GetOverlap(DXDC.BarChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Overlap>()?.Val);
  }
  
  private static bool CmpOverlap(DXDC.BarChart openXmlElement, SByte? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Overlap>()?.Val, value, diffs, objName, "Overlap");
  }
  
  private static void SetOverlap(DXDC.BarChart openXmlElement, SByte? value)
  {
    SimpleValueConverter.SetValue<DXDC.Overlap,System.SByte>(openXmlElement, value);
  }
  
  private static Collection<DMDC.SeriesLines>? GetSeriesLines(DXDC.BarChart openXmlElement)
  {
    var collection = new Collection<DMDC.SeriesLines>();
    foreach (var item in openXmlElement.Elements<DXDC.SeriesLines>())
    {
      var newItem = DMXDC.SeriesLinesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSeriesLines(DXDC.BarChart openXmlElement, Collection<DMDC.SeriesLines>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.SeriesLines>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDC.SeriesLinesConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSeriesLines(DXDC.BarChart openXmlElement, Collection<DMDC.SeriesLines>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.SeriesLines>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.SeriesLinesConverter.CreateOpenXmlElement<DXDC.SeriesLines>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDC.BarChart openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDC.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAxisIds(DXDC.BarChart openXmlElement, Collection<UInt32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.AxisId>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!UInt32ValueConverter.CmpValue(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAxisIds(DXDC.BarChart openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXDC.AxisId>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.BarChartExtensionList? GetBarChartExtensionList(DXDC.BarChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BarChartExtensionList>();
    if (element != null)
      return DMXDC.BarChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBarChartExtensionList(DXDC.BarChart openXmlElement, DMDC.BarChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.BarChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BarChartExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetBarChartExtensionList(DXDC.BarChart openXmlElement, DMDC.BarChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BarChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BarChartExtensionListConverter.CreateOpenXmlElement<DXDC.BarChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChart? CreateModelElement(DXDC.BarChart? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.BarChart? openXmlElement, DMDC.BarChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarDirection(openXmlElement, value.BarDirection, diffs, objName, propName))
        ok = false;
      if (!CmpBarGrouping(openXmlElement, value.BarGrouping, diffs, objName, propName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName, propName))
        ok = false;
      if (!CmpBarChartSeries(openXmlElement, value.BarChartSeries, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName, propName))
        ok = false;
      if (!CmpGapWidth(openXmlElement, value.GapWidth, diffs, objName, propName))
        ok = false;
      if (!CmpOverlap(openXmlElement, value.Overlap, diffs, objName, propName))
        ok = false;
      if (!CmpSeriesLines(openXmlElement, value.SeriesLines, diffs, objName, propName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName, propName))
        ok = false;
      if (!CmpBarChartExtensionList(openXmlElement, value.BarChartExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BarChart value)
    where OpenXmlElementType: DXDC.BarChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BarChart openXmlElement, DMDC.BarChart value)
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
