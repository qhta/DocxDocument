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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>(openXmlElement.GetFirstChild<DXDrawCharts.BarDirection>()?.Val?.Value);
  }
  
  private static bool CmpBarDirection(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.BarDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDrawsCharts.BarDirectionKind>(openXmlElement.GetFirstChild<DXDrawCharts.BarDirection>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.BarGrouping>()?.Val?.Value);
  }
  
  private static bool CmpBarGrouping(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.BarGroupingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDrawsCharts.BarGroupingKind>(openXmlElement.GetFirstChild<DXDrawCharts.BarGrouping>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.Bar3DChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
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
  
  private static Collection<DMDrawsCharts.BarChartSeries> GetBarChartSeries(DXDrawCharts.Bar3DChart openXmlElement)
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
  
  private static bool CmpBarChartSeries(DXDrawCharts.Bar3DChart openXmlElement, Collection<DMDrawsCharts.BarChartSeries>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.BarChartSeries>();
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
        if (!DMXDrawsCharts.BarChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBarChartSeries(DXDrawCharts.Bar3DChart openXmlElement, Collection<DMDrawsCharts.BarChartSeries>? value)
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
    return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>());
  }
  
  private static bool CmpDataLabels(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>()?.Val?.Value;
  }
  
  private static bool CmpGapWidth(DXDrawCharts.Bar3DChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapWidth>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.GapWidth", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement?.GetFirstChild<DXDrawCharts.GapDepth>()?.Val?.Value;
  }
  
  private static bool CmpGapDepth(DXDrawCharts.Bar3DChart openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.GapDepth>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.GapDepth", itemElement?.Val?.Value, value);
    return false;
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDrawsCharts.ShapeKind>(openXmlElement.GetFirstChild<DXDrawCharts.Shape>()?.Val?.Value);
  }
  
  private static bool CmpShape(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.ShapeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDrawsCharts.ShapeKind>(openXmlElement.GetFirstChild<DXDrawCharts.Shape>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpAxisIds(DXDrawCharts.Bar3DChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
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
    return DMXDrawsCharts.Bar3DChartExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Bar3DChartExtensionList>());
  }
  
  private static bool CmpBar3DChartExtensionList(DXDrawCharts.Bar3DChart openXmlElement, DMDrawsCharts.Bar3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Bar3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Bar3DChartExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
      value.BarChartSeries = GetBarChartSeries(openXmlElement);
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
  
  public static bool CompareModelElement(DXDrawCharts.Bar3DChart? openXmlElement, DMDrawsCharts.Bar3DChart? value, DiffList? diffs, string? objName)
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
      if (!CmpGapDepth(openXmlElement, value.GapDepth, diffs, objName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpBar3DChartExtensionList(openXmlElement, value.Bar3DChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
      SetBarChartSeries(openXmlElement, value?.BarChartSeries);
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
