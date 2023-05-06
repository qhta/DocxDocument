namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
public static class Line3DChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DMDC.GroupingKind? GetGrouping(DXDC.Line3DChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(openXmlElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value);
  }
  
  private static bool CmpGrouping(DXDC.Line3DChart openXmlElement, DMDC.GroupingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(openXmlElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetGrouping(DXDC.Line3DChart openXmlElement, DMDC.GroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDC.Line3DChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.Line3DChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.Line3DChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.LineChartSeries>? GetLineChartSeries(DXDC.Line3DChart openXmlElement)
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
  
  private static bool CmpLineChartSeries(DXDC.Line3DChart openXmlElement, Collection<DMDC.LineChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.LineChartSeries>();
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
        if (!DMXDC.LineChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLineChartSeries(DXDC.Line3DChart openXmlElement, Collection<DMDC.LineChartSeries>? value)
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
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.Line3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.Line3DChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDC.Line3DChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static DMDC.DropLines? GetDropLines(DXDC.Line3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DropLines>();
    if (element != null)
      return DMXDC.DropLinesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropLines(DXDC.Line3DChart openXmlElement, DMDC.DropLines? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DropLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DropLines>(), value, diffs, objName);
  }
  
  private static void SetDropLines(DXDC.Line3DChart openXmlElement, DMDC.DropLines? value)
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
  
  private static UInt16? GetGapDepth(DXDC.Line3DChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.GapDepth>()?.Val);
  }
  
  private static bool CmpGapDepth(DXDC.Line3DChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.GapDepth>()?.Val, value, diffs, objName, "GapDepth");
  }
  
  private static void SetGapDepth(DXDC.Line3DChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.GapDepth,System.UInt16>(openXmlElement, value);
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDC.Line3DChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDC.Line3DChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.AxisId>();
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
  
  private static void SetAxisIds(DXDC.Line3DChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDC.Line3DChartExtensionList? GetLine3DChartExtensionList(DXDC.Line3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Line3DChartExtensionList>();
    if (element != null)
      return DMXDC.Line3DChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLine3DChartExtensionList(DXDC.Line3DChart openXmlElement, DMDC.Line3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.Line3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Line3DChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetLine3DChartExtensionList(DXDC.Line3DChart openXmlElement, DMDC.Line3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Line3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Line3DChartExtensionListConverter.CreateOpenXmlElement<DXDC.Line3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Line3DChart? CreateModelElement(DXDC.Line3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Line3DChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.LineChartSeries = GetLineChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.GapDepth = GetGapDepth(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Line3DChartExtensionList = GetLine3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Line3DChart? openXmlElement, DMDC.Line3DChart? value, DiffList? diffs, string? objName)
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
      if (!CmpGapDepth(openXmlElement, value.GapDepth, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpLine3DChartExtensionList(openXmlElement, value.Line3DChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Line3DChart value)
    where OpenXmlElementType: DXDC.Line3DChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Line3DChart openXmlElement, DMDC.Line3DChart value)
  {
    SetGrouping(openXmlElement, value?.Grouping);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetLineChartSeries(openXmlElement, value?.LineChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetDropLines(openXmlElement, value?.DropLines);
    SetGapDepth(openXmlElement, value?.GapDepth);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetLine3DChartExtensionList(openXmlElement, value?.Line3DChartExtensionList);
  }
}
