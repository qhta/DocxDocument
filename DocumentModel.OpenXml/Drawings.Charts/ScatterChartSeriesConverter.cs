namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public static class ScatterChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDC.ScatterChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXDC.ScatterChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXDC.ScatterChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DXDC.ScatterChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val);
  }
  
  private static bool CmpOrder(DXDC.ScatterChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val, value, diffs, objName, "Order");
  }
  
  private static void SetOrder(DXDC.ScatterChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Order,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DMDC.SeriesText? GetSeriesText(DXDC.ScatterChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SeriesText>();
    if (element != null)
      return DMXDC.SeriesTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesText(DXDC.ScatterChartSeries openXmlElement, DMDC.SeriesText? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SeriesText>(), value, diffs, objName);
  }
  
  private static void SetSeriesText(DXDC.ScatterChartSeries openXmlElement, DMDC.SeriesText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SeriesText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SeriesTextConverter.CreateOpenXmlElement<DXDC.SeriesText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.ScatterChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.ScatterChartSeries openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDC.ScatterChartSeries openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DMDC.Marker? GetMarker(DXDC.ScatterChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Marker>();
    if (element != null)
      return DMXDC.MarkerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMarker(DXDC.ScatterChartSeries openXmlElement, DMDC.Marker? value, DiffList? diffs, string? objName)
  {
    return DMXDC.MarkerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Marker>(), value, diffs, objName);
  }
  
  private static void SetMarker(DXDC.ScatterChartSeries openXmlElement, DMDC.Marker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MarkerConverter.CreateOpenXmlElement<DXDC.Marker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDC.DataPoint>? GetDataPoints(DXDC.ScatterChartSeries openXmlElement)
  {
    var collection = new Collection<DMDC.DataPoint>();
    foreach (var item in openXmlElement.Elements<DXDC.DataPoint>())
    {
      var newItem = DMXDC.DataPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataPoints(DXDC.ScatterChartSeries openXmlElement, Collection<DMDC.DataPoint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.DataPoint>();
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
        if (!DMXDC.DataPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataPoints(DXDC.ScatterChartSeries openXmlElement, Collection<DMDC.DataPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.DataPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.DataPointConverter.CreateOpenXmlElement<DXDC.DataPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.ScatterChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.ScatterChartSeries openXmlElement, DMDC.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDC.ScatterChartSeries openXmlElement, DMDC.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDC.Trendline>? GetTrendlines(DXDC.ScatterChartSeries openXmlElement)
  {
    var collection = new Collection<DMDC.Trendline>();
    foreach (var item in openXmlElement.Elements<DXDC.Trendline>())
    {
      var newItem = DMXDC.TrendlineConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTrendlines(DXDC.ScatterChartSeries openXmlElement, Collection<DMDC.Trendline>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.Trendline>();
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
        if (!DMXDC.TrendlineConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTrendlines(DXDC.ScatterChartSeries openXmlElement, Collection<DMDC.Trendline>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.Trendline>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.TrendlineConverter.CreateOpenXmlElement<DXDC.Trendline>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMDC.ErrorBars>? GetErrorBars(DXDC.ScatterChartSeries openXmlElement)
  {
    var collection = new Collection<DMDC.ErrorBars>();
    foreach (var item in openXmlElement.Elements<DXDC.ErrorBars>())
    {
      var newItem = DMXDC.ErrorBarsConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpErrorBars(DXDC.ScatterChartSeries openXmlElement, Collection<DMDC.ErrorBars>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDC.ErrorBars>();
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
        if (!DMXDC.ErrorBarsConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetErrorBars(DXDC.ScatterChartSeries openXmlElement, Collection<DMDC.ErrorBars>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.ErrorBars>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.ErrorBarsConverter.CreateOpenXmlElement<DXDC.ErrorBars>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDC.XValues? GetXValues(DXDC.ScatterChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.XValues>();
    if (element != null)
      return DMXDC.XValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpXValues(DXDC.ScatterChartSeries openXmlElement, DMDC.XValues? value, DiffList? diffs, string? objName)
  {
    return DMXDC.XValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.XValues>(), value, diffs, objName);
  }
  
  private static void SetXValues(DXDC.ScatterChartSeries openXmlElement, DMDC.XValues? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.XValues>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.XValuesConverter.CreateOpenXmlElement<DXDC.XValues>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.YValues? GetYValues(DXDC.ScatterChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.YValues>();
    if (element != null)
      return DMXDC.YValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpYValues(DXDC.ScatterChartSeries openXmlElement, DMDC.YValues? value, DiffList? diffs, string? objName)
  {
    return DMXDC.YValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.YValues>(), value, diffs, objName);
  }
  
  private static void SetYValues(DXDC.ScatterChartSeries openXmlElement, DMDC.YValues? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.YValues>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.YValuesConverter.CreateOpenXmlElement<DXDC.YValues>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSmooth(DXDC.ScatterChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Smooth>() != null;
  }
  
  private static bool CmpSmooth(DXDC.ScatterChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Smooth>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Smooth", val, value);
    return false;
  }
  
  private static void SetSmooth(DXDC.ScatterChartSeries openXmlElement, Boolean? value)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.ScatterSerExtensionList? GetScatterSerExtensionList(DXDC.ScatterChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ScatterSerExtensionList>();
    if (element != null)
      return DMXDC.ScatterSerExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScatterSerExtensionList(DXDC.ScatterChartSeries openXmlElement, DMDC.ScatterSerExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ScatterSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ScatterSerExtensionList>(), value, diffs, objName);
  }
  
  private static void SetScatterSerExtensionList(DXDC.ScatterChartSeries openXmlElement, DMDC.ScatterSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ScatterSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ScatterSerExtensionListConverter.CreateOpenXmlElement<DXDC.ScatterSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChartSeries? CreateModelElement(DXDC.ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChartSeries();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBars = GetErrorBars(openXmlElement);
      value.XValues = GetXValues(openXmlElement);
      value.YValues = GetYValues(openXmlElement);
      value.Smooth = GetSmooth(openXmlElement);
      value.ScatterSerExtensionList = GetScatterSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.ScatterChartSeries? openXmlElement, DMDC.ScatterChartSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpOrder(openXmlElement, value.Order, diffs, objName))
        ok = false;
      if (!CmpSeriesText(openXmlElement, value.SeriesText, diffs, objName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName))
        ok = false;
      if (!CmpMarker(openXmlElement, value.Marker, diffs, objName))
        ok = false;
      if (!CmpDataPoints(openXmlElement, value.DataPoints, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpTrendlines(openXmlElement, value.Trendlines, diffs, objName))
        ok = false;
      if (!CmpErrorBars(openXmlElement, value.ErrorBars, diffs, objName))
        ok = false;
      if (!CmpXValues(openXmlElement, value.XValues, diffs, objName))
        ok = false;
      if (!CmpYValues(openXmlElement, value.YValues, diffs, objName))
        ok = false;
      if (!CmpSmooth(openXmlElement, value.Smooth, diffs, objName))
        ok = false;
      if (!CmpScatterSerExtensionList(openXmlElement, value.ScatterSerExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.ScatterChartSeries value)
    where OpenXmlElementType: DXDC.ScatterChartSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.ScatterChartSeries openXmlElement, DMDC.ScatterChartSeries value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetOrder(openXmlElement, value?.Order);
    SetSeriesText(openXmlElement, value?.SeriesText);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetMarker(openXmlElement, value?.Marker);
    SetDataPoints(openXmlElement, value?.DataPoints);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetTrendlines(openXmlElement, value?.Trendlines);
    SetErrorBars(openXmlElement, value?.ErrorBars);
    SetXValues(openXmlElement, value?.XValues);
    SetYValues(openXmlElement, value?.YValues);
    SetSmooth(openXmlElement, value?.Smooth);
    SetScatterSerExtensionList(openXmlElement, value?.ScatterSerExtensionList);
  }
}
