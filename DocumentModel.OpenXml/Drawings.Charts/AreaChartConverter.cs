namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Area Charts.
/// </summary>
public static class AreaChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDC.GroupingKind? GetGrouping(DXDC.AreaChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(openXmlElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value);
  }
  
  private static bool CmpGrouping(DXDC.AreaChart openXmlElement, DMDC.GroupingKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(openXmlElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetGrouping(DXDC.AreaChart openXmlElement, DMDC.GroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDC.AreaChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.AreaChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.AreaChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.AreaChartSeries>? GetAreaChartSeries(DXDC.AreaChart openXmlElement)
  {
    var collection = new Collection<DMDC.AreaChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDC.AreaChartSeries>())
    {
      var newItem = DMXDC.AreaChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpAreaChartSeries(DXDC.AreaChart openXmlElement, Collection<DMDC.AreaChartSeries>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.AreaChartSeries>();
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
        if (!DMXDC.AreaChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetAreaChartSeries(DXDC.AreaChart openXmlElement, Collection<DMDC.AreaChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.AreaChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.AreaChartSeriesConverter.CreateOpenXmlElement<DXDC.AreaChartSeries>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.AreaChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.AreaChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.AreaChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static DMDC.DropLines? GetDropLines(DXDC.AreaChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DropLines>();
    if (element != null)
      return DMXDC.DropLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLines(DXDC.AreaChart openXmlElement, DMDC.DropLines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DropLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DropLines>(), value, diffs, objName, propName);
  }
  
  private static void SetDropLines(DXDC.AreaChart openXmlElement, DMDC.DropLines? value)
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
  
  private static Collection<UInt32>? GetAxisIds(DXDC.AreaChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDC.AreaChart openXmlElement, Collection<UInt32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetAxisIds(DXDC.AreaChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDC.AreaChartExtensionList? GetAreaChartExtensionList(DXDC.AreaChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.AreaChartExtensionList>();
    if (element != null)
      return DMXDC.AreaChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAreaChartExtensionList(DXDC.AreaChart openXmlElement, DMDC.AreaChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.AreaChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.AreaChartExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetAreaChartExtensionList(DXDC.AreaChart openXmlElement, DMDC.AreaChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.AreaChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.AreaChartExtensionListConverter.CreateOpenXmlElement<DXDC.AreaChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.AreaChart? CreateModelElement(DXDC.AreaChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.AreaChart();
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
  
  public static bool CompareModelElement(DXDC.AreaChart? openXmlElement, DMDC.AreaChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGrouping(openXmlElement, value.Grouping, diffs, objName, propName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName, propName))
        ok = false;
      if (!CmpAreaChartSeries(openXmlElement, value.AreaChartSeries, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName, propName))
        ok = false;
      if (!CmpDropLines(openXmlElement, value.DropLines, diffs, objName, propName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName, propName))
        ok = false;
      if (!CmpAreaChartExtensionList(openXmlElement, value.AreaChartExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.AreaChart value)
    where OpenXmlElementType: DXDC.AreaChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.AreaChart openXmlElement, DMDC.AreaChart value)
  {
    SetGrouping(openXmlElement, value?.Grouping);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetAreaChartSeries(openXmlElement, value?.AreaChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetDropLines(openXmlElement, value?.DropLines);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetAreaChartExtensionList(openXmlElement, value?.AreaChartExtensionList);
  }
}
