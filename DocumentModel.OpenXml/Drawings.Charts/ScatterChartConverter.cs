namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public static class ScatterChartConverter
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  private static DMDrawsCharts.ScatterStyleKind? GetScatterStyle(DXDrawCharts.ScatterChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDrawsCharts.ScatterStyleKind>(openXmlElement.GetFirstChild<DXDrawCharts.ScatterStyle>()?.Val?.Value);
  }
  
  private static bool CmpScatterStyle(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.ScatterStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDrawsCharts.ScatterStyleKind>(openXmlElement.GetFirstChild<DXDrawCharts.ScatterStyle>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetScatterStyle(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.ScatterStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ScatterStyle>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDrawsCharts.ScatterStyleKind>(itemElement, (DMDrawsCharts.ScatterStyleKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.ScatterStyle, DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDrawsCharts.ScatterStyleKind>((DMDrawsCharts.ScatterStyleKind)value));
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.ScatterChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.ScatterChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDrawCharts.ScatterChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.ScatterChartSeries>? GetScatterChartSeries(DXDrawCharts.ScatterChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ScatterChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ScatterChartSeries>())
    {
      var newItem = DMXDrawsCharts.ScatterChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpScatterChartSeries(DXDrawCharts.ScatterChart openXmlElement, Collection<DMDrawsCharts.ScatterChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.ScatterChartSeries>();
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
        if (!DMXDrawsCharts.ScatterChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetScatterChartSeries(DXDrawCharts.ScatterChart openXmlElement, Collection<DMDrawsCharts.ScatterChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ScatterChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ScatterChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.ScatterChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.ScatterChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static Collection<UInt32>? GetAxisIds(DXDrawCharts.ScatterChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDrawCharts.ScatterChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
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
  
  private static void SetAxisIds(DXDrawCharts.ScatterChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.ScatterChartExtensionList? GetScatterChartExtensionList(DXDrawCharts.ScatterChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ScatterChartExtensionList>();
    if (element != null)
      return DMXDrawsCharts.ScatterChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScatterChartExtensionList(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.ScatterChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ScatterChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ScatterChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetScatterChartExtensionList(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.ScatterChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ScatterChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ScatterChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ScatterChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChart? CreateModelElement(DXDrawCharts.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChart();
      value.ScatterStyle = GetScatterStyle(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.ScatterChartSeries = GetScatterChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.ScatterChartExtensionList = GetScatterChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ScatterChart? openXmlElement, DMDrawsCharts.ScatterChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterStyle(openXmlElement, value.ScatterStyle, diffs, objName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpScatterChartSeries(openXmlElement, value.ScatterChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpScatterChartExtensionList(openXmlElement, value.ScatterChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterChart value)
    where OpenXmlElementType: DXDrawCharts.ScatterChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ScatterChart openXmlElement, DMDrawsCharts.ScatterChart value)
  {
    SetScatterStyle(openXmlElement, value?.ScatterStyle);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetScatterChartSeries(openXmlElement, value?.ScatterChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetScatterChartExtensionList(openXmlElement, value?.ScatterChartExtensionList);
  }
}
