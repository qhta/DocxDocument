namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Area Chart Series.
/// </summary>
public static class AreaChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDC.AreaChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXDC.AreaChartSeries openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXDC.AreaChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DXDC.AreaChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val);
  }
  
  private static bool CmpOrder(DXDC.AreaChartSeries openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val, value, diffs, objName, "Order");
  }
  
  private static void SetOrder(DXDC.AreaChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Order,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DMDC.SeriesText? GetSeriesText(DXDC.AreaChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SeriesText>();
    if (element != null)
      return DMXDC.SeriesTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesText(DXDC.AreaChartSeries openXmlElement, DMDC.SeriesText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SeriesText>(), value, diffs, objName, propName);
  }
  
  private static void SetSeriesText(DXDC.AreaChartSeries openXmlElement, DMDC.SeriesText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SeriesText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SeriesTextConverter.CreateOpenXmlElement<DXDC.SeriesText>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.AreaChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.AreaChartSeries openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXDC.AreaChartSeries openXmlElement, DMDC.ChartShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  private static DMDC.PictureOptions? GetPictureOptions(DXDC.AreaChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PictureOptions>();
    if (element != null)
      return DMXDC.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXDC.AreaChartSeries openXmlElement, DMDC.PictureOptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PictureOptions>(), value, diffs, objName, propName);
  }
  
  private static void SetPictureOptions(DXDC.AreaChartSeries openXmlElement, DMDC.PictureOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PictureOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PictureOptionsConverter.CreateOpenXmlElement<DXDC.PictureOptions>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<DMDC.DataPoint>? GetDataPoints(DXDC.AreaChartSeries openXmlElement)
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
  
  private static bool CmpDataPoints(DXDC.AreaChartSeries openXmlElement, Collection<DMDC.DataPoint>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.DataPoint>();
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
        if (!DMXDC.DataPointConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataPoints(DXDC.AreaChartSeries openXmlElement, Collection<DMDC.DataPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.DataPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.DataPointConverter.CreateOpenXmlElement<DXDC.DataPoint>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.AreaChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.AreaChartSeries openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXDC.AreaChartSeries openXmlElement, DMDC.DataLabels? value)
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
  
  private static Collection<DMDC.Trendline>? GetTrendlines(DXDC.AreaChartSeries openXmlElement)
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
  
  private static bool CmpTrendlines(DXDC.AreaChartSeries openXmlElement, Collection<DMDC.Trendline>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.Trendline>();
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
        if (!DMXDC.TrendlineConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTrendlines(DXDC.AreaChartSeries openXmlElement, Collection<DMDC.Trendline>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.Trendline>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.TrendlineConverter.CreateOpenXmlElement<DXDC.Trendline>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static Collection<DMDC.ErrorBars>? GetErrorBars(DXDC.AreaChartSeries openXmlElement)
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
  
  private static bool CmpErrorBars(DXDC.AreaChartSeries openXmlElement, Collection<DMDC.ErrorBars>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDC.ErrorBars>();
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
        if (!DMXDC.ErrorBarsConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetErrorBars(DXDC.AreaChartSeries openXmlElement, Collection<DMDC.ErrorBars>? value)
  {
    openXmlElement.RemoveAllChildren<DXDC.ErrorBars>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDC.ErrorBarsConverter.CreateOpenXmlElement<DXDC.ErrorBars>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDC.CategoryAxisData? GetCategoryAxisData(DXDC.AreaChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.CategoryAxisData>();
    if (element != null)
      return DMXDC.CategoryAxisDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxisData(DXDC.AreaChartSeries openXmlElement, DMDC.CategoryAxisData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.CategoryAxisDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.CategoryAxisData>(), value, diffs, objName, propName);
  }
  
  private static void SetCategoryAxisData(DXDC.AreaChartSeries openXmlElement, DMDC.CategoryAxisData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.CategoryAxisData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.CategoryAxisDataConverter.CreateOpenXmlElement<DXDC.CategoryAxisData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Values? GetValues(DXDC.AreaChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Values>();
    if (element != null)
      return DMXDC.ValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValues(DXDC.AreaChartSeries openXmlElement, DMDC.Values? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Values>(), value, diffs, objName, propName);
  }
  
  private static void SetValues(DXDC.AreaChartSeries openXmlElement, DMDC.Values? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.Values>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ValuesConverter.CreateOpenXmlElement<DXDC.Values>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.AreaSerExtensionList? GetAreaSerExtensionList(DXDC.AreaChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.AreaSerExtensionList>();
    if (element != null)
      return DMXDC.AreaSerExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAreaSerExtensionList(DXDC.AreaChartSeries openXmlElement, DMDC.AreaSerExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.AreaSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.AreaSerExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetAreaSerExtensionList(DXDC.AreaChartSeries openXmlElement, DMDC.AreaSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.AreaSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.AreaSerExtensionListConverter.CreateOpenXmlElement<DXDC.AreaSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.AreaChartSeries? CreateModelElement(DXDC.AreaChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.AreaChartSeries();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBars = GetErrorBars(openXmlElement);
      value.CategoryAxisData = GetCategoryAxisData(openXmlElement);
      value.Values = GetValues(openXmlElement);
      value.AreaSerExtensionList = GetAreaSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.AreaChartSeries? openXmlElement, DMDC.AreaChartSeries? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName, propName))
        ok = false;
      if (!CmpOrder(openXmlElement, value.Order, diffs, objName, propName))
        ok = false;
      if (!CmpSeriesText(openXmlElement, value.SeriesText, diffs, objName, propName))
        ok = false;
      if (!CmpChartShapeProperties(openXmlElement, value.ChartShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpPictureOptions(openXmlElement, value.PictureOptions, diffs, objName, propName))
        ok = false;
      if (!CmpDataPoints(openXmlElement, value.DataPoints, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabels(openXmlElement, value.DataLabels, diffs, objName, propName))
        ok = false;
      if (!CmpTrendlines(openXmlElement, value.Trendlines, diffs, objName, propName))
        ok = false;
      if (!CmpErrorBars(openXmlElement, value.ErrorBars, diffs, objName, propName))
        ok = false;
      if (!CmpCategoryAxisData(openXmlElement, value.CategoryAxisData, diffs, objName, propName))
        ok = false;
      if (!CmpValues(openXmlElement, value.Values, diffs, objName, propName))
        ok = false;
      if (!CmpAreaSerExtensionList(openXmlElement, value.AreaSerExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.AreaChartSeries value)
    where OpenXmlElementType: DXDC.AreaChartSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.AreaChartSeries openXmlElement, DMDC.AreaChartSeries value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetOrder(openXmlElement, value?.Order);
    SetSeriesText(openXmlElement, value?.SeriesText);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetPictureOptions(openXmlElement, value?.PictureOptions);
    SetDataPoints(openXmlElement, value?.DataPoints);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetTrendlines(openXmlElement, value?.Trendlines);
    SetErrorBars(openXmlElement, value?.ErrorBars);
    SetCategoryAxisData(openXmlElement, value?.CategoryAxisData);
    SetValues(openXmlElement, value?.Values);
    SetAreaSerExtensionList(openXmlElement, value?.AreaSerExtensionList);
  }
}
