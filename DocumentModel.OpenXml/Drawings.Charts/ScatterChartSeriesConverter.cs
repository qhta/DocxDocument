namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartSeries Class.
/// </summary>
public static class ScatterChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val?.Value;
  }
  
  private static bool CmpIndex(DXDrawCharts.ScatterChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Index", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXDrawCharts.ScatterChartSeries openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Index{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Order>()?.Val?.Value;
  }
  
  private static bool CmpOrder(DXDrawCharts.ScatterChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Order>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Order", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetOrder(DXDrawCharts.ScatterChartSeries openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Order>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.Order{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DMDrawsCharts.SeriesText? GetSeriesText(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return DMXDrawsCharts.SeriesTextConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SeriesText>());
  }
  
  private static bool CmpSeriesText(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.SeriesText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SeriesText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSeriesText(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.SeriesText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SeriesText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SeriesTextConverter.CreateOpenXmlElement<DXDrawCharts.SeriesText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>());
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  private static DMDrawsCharts.Marker? GetMarker(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return DMXDrawsCharts.MarkerConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Marker>());
  }
  
  private static bool CmpMarker(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.Marker? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MarkerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Marker>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMarker(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.Marker? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Marker>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MarkerConverter.CreateOpenXmlElement<DXDrawCharts.Marker>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.DataPoint> GetDataPoints(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DataPoint>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DataPoint>())
    {
      var newItem = DMXDrawsCharts.DataPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpDataPoints(DXDrawCharts.ScatterChartSeries openXmlElement, Collection<DMDrawsCharts.DataPoint>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.DataPoint>();
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
        if (!DMXDrawsCharts.DataPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataPoints(DXDrawCharts.ScatterChartSeries openXmlElement, Collection<DMDrawsCharts.DataPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DataPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DataPointConverter.CreateOpenXmlElement<DXDrawCharts.DataPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>());
  }
  
  private static bool CmpDataLabels(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabels(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static Collection<DMDrawsCharts.Trendline> GetTrendlines(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Trendline>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Trendline>())
    {
      var newItem = DMXDrawsCharts.TrendlineConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpTrendlines(DXDrawCharts.ScatterChartSeries openXmlElement, Collection<DMDrawsCharts.Trendline>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.Trendline>();
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
        if (!DMXDrawsCharts.TrendlineConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTrendlines(DXDrawCharts.ScatterChartSeries openXmlElement, Collection<DMDrawsCharts.Trendline>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Trendline>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.TrendlineConverter.CreateOpenXmlElement<DXDrawCharts.Trendline>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMDrawsCharts.ErrorBars> GetErrorBars(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ErrorBars>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ErrorBars>())
    {
      var newItem = DMXDrawsCharts.ErrorBarsConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpErrorBars(DXDrawCharts.ScatterChartSeries openXmlElement, Collection<DMDrawsCharts.ErrorBars>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.ErrorBars>();
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
        if (!DMXDrawsCharts.ErrorBarsConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetErrorBars(DXDrawCharts.ScatterChartSeries openXmlElement, Collection<DMDrawsCharts.ErrorBars>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ErrorBars>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ErrorBarsConverter.CreateOpenXmlElement<DXDrawCharts.ErrorBars>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.XValues? GetXValues(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return DMXDrawsCharts.XValuesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.XValues>());
  }
  
  private static bool CmpXValues(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.XValues? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.XValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.XValues>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetXValues(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.XValues? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.XValues>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.XValuesConverter.CreateOpenXmlElement<DXDrawCharts.XValues>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.YValues? GetYValues(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return DMXDrawsCharts.YValuesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.YValues>());
  }
  
  private static bool CmpYValues(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.YValues? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.YValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.YValues>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetYValues(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.YValues? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.YValues>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.YValuesConverter.CreateOpenXmlElement<DXDrawCharts.YValues>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSmooth(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Smooth>() != null;
  }
  
  private static bool CmpSmooth(DXDrawCharts.ScatterChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Smooth>() != null == value;
  }
  
  private static void SetSmooth(DXDrawCharts.ScatterChartSeries openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Smooth>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Smooth();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ScatterSerExtensionList? GetScatterSerExtensionList(DXDrawCharts.ScatterChartSeries openXmlElement)
  {
    return DMXDrawsCharts.ScatterSerExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ScatterSerExtensionList>());
  }
  
  private static bool CmpScatterSerExtensionList(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.ScatterSerExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ScatterSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ScatterSerExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScatterSerExtensionList(DXDrawCharts.ScatterChartSeries openXmlElement, DMDrawsCharts.ScatterSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ScatterSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ScatterSerExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ScatterSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.ScatterChartSeries? CreateModelElement(DXDrawCharts.ScatterChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ScatterChartSeries();
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
  
  public static bool CompareModelElement(DXDrawCharts.ScatterChartSeries? openXmlElement, DMDrawsCharts.ScatterChartSeries? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterChartSeries? value)
    where OpenXmlElementType: DXDrawCharts.ScatterChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
