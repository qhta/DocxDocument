namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Line Charts.
/// </summary>
public static class LineChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDC.GroupingKind? GetGrouping(DXDC.LineChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(openXmlElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value);
  }
  
  private static bool CmpGrouping(DXDC.LineChart openXmlElement, DMDC.GroupingKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(openXmlElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetGrouping(DXDC.LineChart openXmlElement, DMDC.GroupingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Grouping>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(itemElement, (DMDC.GroupingKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Grouping, DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>((DMDC.GroupingKind)value));
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDC.LineChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.LineChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.LineChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.LineChartSeries>? GetLineChartSeries(DXDC.LineChart openXmlElement)
  {
    var collection = new Collection<DMDC.LineChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDC.LineChartSeries>())
    {
      var newItem = DMXDC.LineChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpLineChartSeries(DXDC.LineChart openXmlElement, Collection<DMDC.LineChartSeries>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.LineChartSeries>();
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
        if (!DMXDC.LineChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLineChartSeries(DXDC.LineChart openXmlElement, Collection<DMDC.LineChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.LineChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.LineChartSeriesConverter.CreateOpenXmlElement<DXDC.LineChartSeries>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.LineChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.LineChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.LineChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static DMDC.DropLines? GetDropLines(DXDC.LineChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DropLines>();
    if (element != null)
      return DMXDC.DropLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLines(DXDC.LineChart openXmlElement, DMDC.DropLines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DropLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DropLines>(), value, diffs, objName, propName);
  }
  
  private static void SetDropLines(DXDC.LineChart openXmlElement, DMDC.DropLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DropLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DropLinesConverter.CreateOpenXmlElement<DXDC.DropLines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.HighLowLines? GetHighLowLines(DXDC.LineChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.HighLowLines>();
    if (element != null)
      return DMXDC.HighLowLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHighLowLines(DXDC.LineChart openXmlElement, DMDC.HighLowLines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.HighLowLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.HighLowLines>(), value, diffs, objName, propName);
  }
  
  private static void SetHighLowLines(DXDC.LineChart openXmlElement, DMDC.HighLowLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.HighLowLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.HighLowLinesConverter.CreateOpenXmlElement<DXDC.HighLowLines>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.UpDownBars? GetUpDownBars(DXDC.LineChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.UpDownBars>();
    if (element != null)
      return DMXDC.UpDownBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUpDownBars(DXDC.LineChart openXmlElement, DMDC.UpDownBars? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.UpDownBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.UpDownBars>(), value, diffs, objName, propName);
  }
  
  private static void SetUpDownBars(DXDC.LineChart openXmlElement, DMDC.UpDownBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.UpDownBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.UpDownBarsConverter.CreateOpenXmlElement<DXDC.UpDownBars>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowMarker(DXDC.LineChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ShowMarker>() != null;
  }
  
  private static bool CmpShowMarker(DXDC.LineChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ShowMarker>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ShowMarker", val, value);
    return false;
  }
  
  private static void SetShowMarker(DXDC.LineChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ShowMarker>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ShowMarker();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetSmooth(DXDC.LineChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Smooth>() != null;
  }
  
  private static bool CmpSmooth(DXDC.LineChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Smooth>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Smooth", val, value);
    return false;
  }
  
  private static void SetSmooth(DXDC.LineChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Smooth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Smooth();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDC.LineChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDC.LineChart openXmlElement, Collection<UInt32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetAxisIds(DXDC.LineChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDC.LineChartExtensionList? GetLineChartExtensionList(DXDC.LineChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.LineChartExtensionList>();
    if (element != null)
      return DMXDC.LineChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineChartExtensionList(DXDC.LineChart openXmlElement, DMDC.LineChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.LineChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.LineChartExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetLineChartExtensionList(DXDC.LineChart openXmlElement, DMDC.LineChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.LineChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.LineChartExtensionListConverter.CreateOpenXmlElement<DXDC.LineChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.LineChart? CreateModelElement(DXDC.LineChart? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.LineChart? openXmlElement, DMDC.LineChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGrouping(openXmlElement, value.Grouping, diffs, objName, propName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName, propName))
        ok = false;
      if (!CmpLineChartSeries(openXmlElement, value.LineChartSeries, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName, propName))
        ok = false;
      if (!CmpDropLines(openXmlElement, value.DropLines, diffs, objName, propName))
        ok = false;
      if (!CmpHighLowLines(openXmlElement, value.HighLowLines, diffs, objName, propName))
        ok = false;
      if (!CmpUpDownBars(openXmlElement, value.UpDownBars, diffs, objName, propName))
        ok = false;
      if (!CmpShowMarker(openXmlElement, value.ShowMarker, diffs, objName, propName))
        ok = false;
      if (!CmpSmooth(openXmlElement, value.Smooth, diffs, objName, propName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName, propName))
        ok = false;
      if (!CmpLineChartExtensionList(openXmlElement, value.LineChartExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.LineChart value)
    where OpenXmlElementType: DXDC.LineChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.LineChart openXmlElement, DMDC.LineChart value)
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
