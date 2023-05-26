namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Area Charts.
/// </summary>
public static class Area3DChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDC.GroupingKind? GetGrouping(DXDC.Area3DChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(openXmlElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value);
  }
  
  private static bool CmpGrouping(DXDC.Area3DChart openXmlElement, DMDC.GroupingKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(openXmlElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetGrouping(DXDC.Area3DChart openXmlElement, DMDC.GroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDC.Area3DChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.Area3DChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.Area3DChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.AreaChartSeries>? GetAreaChartSeries(DXDC.Area3DChart openXmlElement)
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
  
  private static bool CmpAreaChartSeries(DXDC.Area3DChart openXmlElement, Collection<DMDC.AreaChartSeries>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetAreaChartSeries(DXDC.Area3DChart openXmlElement, Collection<DMDC.AreaChartSeries>? value)
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
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.Area3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.Area3DChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.Area3DChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static DMDC.DropLines? GetDropLines(DXDC.Area3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DropLines>();
    if (element != null)
      return DMXDC.DropLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLines(DXDC.Area3DChart openXmlElement, DMDC.DropLines? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DropLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DropLines>(), value, diffs, objName, propName);
  }
  
  private static void SetDropLines(DXDC.Area3DChart openXmlElement, DMDC.DropLines? value)
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
  
  private static UInt16? GetGapDepth(DXDC.Area3DChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.GapDepth>()?.Val);
  }
  
  private static bool CmpGapDepth(DXDC.Area3DChart openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.GapDepth>()?.Val, value, diffs, objName, "GapDepth");
  }
  
  private static void SetGapDepth(DXDC.Area3DChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.GapDepth,System.UInt16>(openXmlElement, value);
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDC.Area3DChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDC.Area3DChart openXmlElement, Collection<UInt32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetAxisIds(DXDC.Area3DChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDC.Area3DChartExtensionList? GetArea3DChartExtensionList(DXDC.Area3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Area3DChartExtensionList>();
    if (element != null)
      return DMXDC.Area3DChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArea3DChartExtensionList(DXDC.Area3DChart openXmlElement, DMDC.Area3DChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.Area3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Area3DChartExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetArea3DChartExtensionList(DXDC.Area3DChart openXmlElement, DMDC.Area3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Area3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Area3DChartExtensionListConverter.CreateOpenXmlElement<DXDC.Area3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Area3DChart? CreateModelElement(DXDC.Area3DChart? openXmlElement)
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
  
  public static bool CompareModelElement(DXDC.Area3DChart? openXmlElement, DMDC.Area3DChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
      if (!CmpGapDepth(openXmlElement, value.GapDepth, diffs, objName, propName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName, propName))
        ok = false;
      if (!CmpArea3DChartExtensionList(openXmlElement, value.Area3DChartExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Area3DChart value)
    where OpenXmlElementType: DXDC.Area3DChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Area3DChart openXmlElement, DMDC.Area3DChart value)
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
