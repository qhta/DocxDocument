namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Radar Charts converter from/to OpenXml.
///</summary>
public static class RadarChartConverter
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  private static DMDrawsCharts.RadarStyleKind? GetRadarStyle(DXDrawCharts.RadarChart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DMDrawsCharts.RadarStyleKind>(openXmlElement.GetFirstChild<DXDrawCharts.RadarStyle>()?.Val?.Value);
  }
  
  private static bool CmpRadarStyle(DXDrawCharts.RadarChart openXmlElement, DMDrawsCharts.RadarStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DMDrawsCharts.RadarStyleKind>(openXmlElement.GetFirstChild<DXDrawCharts.RadarStyle>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetRadarStyle(DXDrawCharts.RadarChart openXmlElement, DMDrawsCharts.RadarStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RadarStyle>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DMDrawsCharts.RadarStyleKind>(itemElement, (DMDrawsCharts.RadarStyleKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.RadarStyle, DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DMDrawsCharts.RadarStyleKind>((DMDrawsCharts.RadarStyleKind)value));
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DXDrawCharts.RadarChart openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
  }
  
  private static bool CmpVaryColors(DXDrawCharts.RadarChart openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.VaryColors>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.VaryColors", val, value);
    return false;
  }
  
  private static void SetVaryColors(DXDrawCharts.RadarChart openXmlElement, Boolean? value)
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
  
  private static Collection<DMDrawsCharts.RadarChartSeries>? GetRadarChartSeries(DXDrawCharts.RadarChart openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.RadarChartSeries>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.RadarChartSeries>())
    {
      var newItem = DMXDrawsCharts.RadarChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpRadarChartSeries(DXDrawCharts.RadarChart openXmlElement, Collection<DMDrawsCharts.RadarChartSeries>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.RadarChartSeries>();
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
        if (!DMXDrawsCharts.RadarChartSeriesConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetRadarChartSeries(DXDrawCharts.RadarChart openXmlElement, Collection<DMDrawsCharts.RadarChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.RadarChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.RadarChartSeriesConverter.CreateOpenXmlElement<DXDrawCharts.RadarChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.RadarChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDrawCharts.RadarChart openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDrawCharts.RadarChart openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static Collection<UInt32>? GetAxisIds(DXDrawCharts.RadarChart openXmlElement)
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
  
  private static bool CmpAxisIds(DXDrawCharts.RadarChart openXmlElement, Collection<UInt32>? value, DiffList? diffs, string? objName)
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
  
  private static void SetAxisIds(DXDrawCharts.RadarChart openXmlElement, Collection<UInt32>? value)
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
  
  private static DMDrawsCharts.RadarChartExtensionList? GetRadarChartExtensionList(DXDrawCharts.RadarChart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.RadarChartExtensionList>();
    if (element != null)
      return DMXDrawsCharts.RadarChartExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadarChartExtensionList(DXDrawCharts.RadarChart openXmlElement, DMDrawsCharts.RadarChartExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.RadarChartExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.RadarChartExtensionList>(), value, diffs, objName);
  }
  
  private static void SetRadarChartExtensionList(DXDrawCharts.RadarChart openXmlElement, DMDrawsCharts.RadarChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RadarChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.RadarChartExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.RadarChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.RadarChart? CreateModelElement(DXDrawCharts.RadarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.RadarChart();
      value.RadarStyle = GetRadarStyle(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.RadarChartSeries = GetRadarChartSeries(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.RadarChartExtensionList = GetRadarChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.RadarChart? openXmlElement, DMDrawsCharts.RadarChart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadarStyle(openXmlElement, value.RadarStyle, diffs, objName))
        ok = false;
      if (!CmpVaryColors(openXmlElement, value.VaryColors, diffs, objName))
        ok = false;
      if (!CmpRadarChartSeries(openXmlElement, value.RadarChartSeries, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpAxisIds(openXmlElement, value.AxisIds, diffs, objName))
        ok = false;
      if (!CmpRadarChartExtensionList(openXmlElement, value.RadarChartExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.RadarChart value)
    where OpenXmlElementType: DXDrawCharts.RadarChart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.RadarChart openXmlElement, DMDrawsCharts.RadarChart value)
  {
    SetRadarStyle(openXmlElement, value?.RadarStyle);
    SetVaryColors(openXmlElement, value?.VaryColors);
    SetRadarChartSeries(openXmlElement, value?.RadarChartSeries);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetAxisIds(openXmlElement, value?.AxisIds);
    SetRadarChartExtensionList(openXmlElement, value?.RadarChartExtensionList);
  }
}
