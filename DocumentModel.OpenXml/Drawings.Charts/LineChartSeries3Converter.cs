namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineChartSeries Class.
/// </summary>
public static class LineChartSeries3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXO2013DrawChart.LineChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXO2013DrawChart.LineChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Order>()?.Val);
  }
  
  private static bool CmpOrder(DXO2013DrawChart.LineChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Order>()?.Val, value, diffs, objName, "Order");
  }
  
  private static void SetOrder(DXO2013DrawChart.LineChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Order,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DMDrawsCharts.SeriesText? GetSeriesText(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.SeriesText>();
    if (element != null)
      return DMXDrawsCharts.SeriesTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesText(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.SeriesText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SeriesText>(), value, diffs, objName);
  }
  
  private static void SetSeriesText(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.SeriesText? value)
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
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  private static DMDrawsCharts.Marker? GetMarker(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Marker>();
    if (element != null)
      return DMXDrawsCharts.MarkerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMarker(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.Marker? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MarkerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Marker>(), value, diffs, objName);
  }
  
  private static void SetMarker(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.Marker? value)
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
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (element != null)
      return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PictureOptions>(), value, diffs, objName);
  }
  
  private static void SetPictureOptions(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PictureOptionsConverter.CreateOpenXmlElement<DXDrawCharts.PictureOptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.DataPoint>? GetDataPoints(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DataPoint>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DataPoint>())
    {
      var newItem = DMXDrawsCharts.DataPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataPoints(DXO2013DrawChart.LineChartSeries openXmlElement, Collection<DMDrawsCharts.DataPoint>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.DataPoint>();
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
        if (!DMXDrawsCharts.DataPointConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataPoints(DXO2013DrawChart.LineChartSeries openXmlElement, Collection<DMDrawsCharts.DataPoint>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (element != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static Collection<DMDrawsCharts.Trendline>? GetTrendlines(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Trendline>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Trendline>())
    {
      var newItem = DMXDrawsCharts.TrendlineConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTrendlines(DXO2013DrawChart.LineChartSeries openXmlElement, Collection<DMDrawsCharts.Trendline>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.Trendline>();
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
        if (!DMXDrawsCharts.TrendlineConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTrendlines(DXO2013DrawChart.LineChartSeries openXmlElement, Collection<DMDrawsCharts.Trendline>? value)
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
  
  private static DMDrawsCharts.ErrorBars? GetErrorBars(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ErrorBars>();
    if (element != null)
      return DMXDrawsCharts.ErrorBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpErrorBars(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.ErrorBars? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ErrorBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ErrorBars>(), value, diffs, objName);
  }
  
  private static void SetErrorBars(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.ErrorBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ErrorBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ErrorBarsConverter.CreateOpenXmlElement<DXDrawCharts.ErrorBars>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.CategoryAxisData? GetCategoryAxisData(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.CategoryAxisData>();
    if (element != null)
      return DMXDrawsCharts.CategoryAxisDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxisData(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.CategoryAxisData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryAxisDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.CategoryAxisData>(), value, diffs, objName);
  }
  
  private static void SetCategoryAxisData(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.CategoryAxisData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CategoryAxisData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.CategoryAxisDataConverter.CreateOpenXmlElement<DXDrawCharts.CategoryAxisData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Values? GetValues(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Values>();
    if (element != null)
      return DMXDrawsCharts.ValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValues(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.Values? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Values>(), value, diffs, objName);
  }
  
  private static void SetValues(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.Values? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Values>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ValuesConverter.CreateOpenXmlElement<DXDrawCharts.Values>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSmooth(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Smooth>() != null;
  }
  
  private static bool CmpSmooth(DXO2013DrawChart.LineChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Smooth>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Smooth", val, value);
    return false;
  }
  
  private static void SetSmooth(DXO2013DrawChart.LineChartSeries openXmlElement, Boolean? value)
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
  
  private static DMDrawsCharts.LineSerExtensionList? GetLineSerExtensionList(DXO2013DrawChart.LineChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.LineSerExtensionList>();
    if (element != null)
      return DMXDrawsCharts.LineSerExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineSerExtensionList(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.LineSerExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LineSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.LineSerExtensionList>(), value, diffs, objName);
  }
  
  private static void SetLineSerExtensionList(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.LineSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.LineSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LineSerExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.LineSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.LineChartSeries3? CreateModelElement(DXO2013DrawChart.LineChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineChartSeries3();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.Marker = GetMarker(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBars = GetErrorBars(openXmlElement);
      value.CategoryAxisData = GetCategoryAxisData(openXmlElement);
      value.Values = GetValues(openXmlElement);
      value.Smooth = GetSmooth(openXmlElement);
      value.LineSerExtensionList = GetLineSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.LineChartSeries? openXmlElement, DMDrawsCharts.LineChartSeries3? value, DiffList? diffs, string? objName)
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
      if (!CmpPictureOptions(openXmlElement, value.PictureOptions, diffs, objName))
        ok = false;
      if (!CmpDataPoints(openXmlElement, value.DataPoints, diffs, objName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName))
        ok = false;
      if (!CmpTrendlines(openXmlElement, value.Trendlines, diffs, objName))
        ok = false;
      if (!CmpErrorBars(openXmlElement, value.ErrorBars, diffs, objName))
        ok = false;
      if (!CmpCategoryAxisData(openXmlElement, value.CategoryAxisData, diffs, objName))
        ok = false;
      if (!CmpValues(openXmlElement, value.Values, diffs, objName))
        ok = false;
      if (!CmpSmooth(openXmlElement, value.Smooth, diffs, objName))
        ok = false;
      if (!CmpLineSerExtensionList(openXmlElement, value.LineSerExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.LineChartSeries3 value)
    where OpenXmlElementType: DXO2013DrawChart.LineChartSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.LineChartSeries openXmlElement, DMDrawsCharts.LineChartSeries3 value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetOrder(openXmlElement, value?.Order);
    SetSeriesText(openXmlElement, value?.SeriesText);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetMarker(openXmlElement, value?.Marker);
    SetPictureOptions(openXmlElement, value?.PictureOptions);
    SetDataPoints(openXmlElement, value?.DataPoints);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetTrendlines(openXmlElement, value?.Trendlines);
    SetErrorBars(openXmlElement, value?.ErrorBars);
    SetCategoryAxisData(openXmlElement, value?.CategoryAxisData);
    SetValues(openXmlElement, value?.Values);
    SetSmooth(openXmlElement, value?.Smooth);
    SetLineSerExtensionList(openXmlElement, value?.LineSerExtensionList);
  }
}
