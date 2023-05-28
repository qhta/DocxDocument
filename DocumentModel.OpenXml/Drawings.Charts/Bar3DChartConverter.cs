namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public static class Bar3DChartConverter
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  private static DMDC.BarDirectionKind? GetBarDirection(DXDC.Bar3DChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>(openXmlElement.GetFirstChild<DXDC.BarDirection>()?.Val?.Value);
  }
  
  private static bool CmpBarDirection(DXDC.Bar3DChart openXmlElement, DMDC.BarDirectionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>(openXmlElement.GetFirstChild<DXDC.BarDirection>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBarDirection(DXDC.Bar3DChart openXmlElement, DMDC.BarDirectionKind? value)
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
  private static DMDC.BarGroupingKind? GetBarGrouping(DXDC.Bar3DChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>(openXmlElement.GetFirstChild<DXDC.BarGrouping>()?.Val?.Value);
  }
  
  private static bool CmpBarGrouping(DXDC.Bar3DChart openXmlElement, DMDC.BarGroupingKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>(openXmlElement.GetFirstChild<DXDC.BarGrouping>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBarGrouping(DXDC.Bar3DChart openXmlElement, DMDC.BarGroupingKind? value)
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
  private static Boolean? GetVaryColors(DXDC.Bar3DChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDC.Bar3DChart openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDC.Bar3DChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDC.BarChartSeries>? GetBarChartSeries(DXDC.Bar3DChart openXmlElement)
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
  
  private static bool CmpBarChartSeries(DXDC.Bar3DChart openXmlElement, Collection<DMDC.BarChartSeries>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetBarChartSeries(DXDC.Bar3DChart openXmlElement, Collection<DMDC.BarChartSeries>? value)
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
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.Bar3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.Bar3DChart openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.Bar3DChart openXmlElement, DMDC.DataLabels? value)
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
  
  private static UInt16? GetGapWidth(DXDC.Bar3DChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.GapWidth>()?.Val);
  }
  
  private static bool CmpGapWidth(DXDC.Bar3DChart openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.GapWidth>()?.Val, value, diffs, objName, "GapWidth");
  }
  
  private static void SetGapWidth(DXDC.Bar3DChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.GapWidth,System.UInt16>(openXmlElement, value);
  }
  
  private static UInt16? GetGapDepth(DXDC.Bar3DChart openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.GapDepth>()?.Val);
  }
  
  private static bool CmpGapDepth(DXDC.Bar3DChart openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.GapDepth>()?.Val, value, diffs, objName, "GapDepth");
  }
  
  private static void SetGapDepth(DXDC.Bar3DChart openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXDC.GapDepth,System.UInt16>(openXmlElement, value);
  }
  
  private static DMDC.ShapeKind? GetShape(DXDC.Bar3DChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(openXmlElement.GetFirstChild<DXDC.Shape>()?.Val?.Value);
  }
  
  private static bool CmpShape(DXDC.Bar3DChart openXmlElement, DMDC.ShapeKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(openXmlElement.GetFirstChild<DXDC.Shape>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetShape(DXDC.Bar3DChart openXmlElement, DMDC.ShapeKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Shape>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(itemElement, (DMDC.ShapeKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Shape, DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>((DMDC.ShapeKind)value));
  }
  
  private static Collection<UInt32>? GetAxisIds(DXDC.Bar3DChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDC.Bar3DChart openXmlElement, Collection<UInt32>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetAxisIds(DXDC.Bar3DChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDC.Bar3DChartExtensionList? GetBar3DChartExtensionList(DXDC.Bar3DChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Bar3DChartExtensionList>();
    if (element != null)
      return DMXDC.Bar3DChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBar3DChartExtensionList(DXDC.Bar3DChart openXmlElement, DMDC.Bar3DChartExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.Bar3DChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Bar3DChartExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetBar3DChartExtensionList(DXDC.Bar3DChart openXmlElement, DMDC.Bar3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Bar3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Bar3DChartExtensionListConverter.CreateOpenXmlElement<DXDC.Bar3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.Bar3DChart? CreateModelElement(DXDC.Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Bar3DChart();
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
  
  public static bool CompareModelElement(DXDC.Bar3DChart? openXmlElement, DMDC.Bar3DChart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
      if (!CmpGapDepth(openXmlElement, value.GapDepth, diffs, objName, propName))
        ok = false;
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName, propName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName, propName))
        ok = false;
      if (!CmpBar3DChartExtensionList(openXmlElement, value.Bar3DChartExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Bar3DChart value)
    where OpenXmlElementType: DXDC.Bar3DChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Bar3DChart openXmlElement, DMDC.Bar3DChart value)
  {
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
  }
}
