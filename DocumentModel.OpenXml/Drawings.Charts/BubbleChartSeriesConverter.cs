namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
public static class BubbleChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDC.BubbleChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXDC.BubbleChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXDC.BubbleChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DXDC.BubbleChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val);
  }
  
  private static bool CmpOrder(DXDC.BubbleChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val, value, diffs, objName, "Order");
  }
  
  private static void SetOrder(DXDC.BubbleChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Order,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DMDC.SeriesText? GetSeriesText(DXDC.BubbleChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SeriesText>();
    if (element != null)
      return DMXDC.SeriesTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesText(DXDC.BubbleChartSeries openXmlElement, DMDC.SeriesText? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SeriesText>(), value, diffs, objName);
  }
  
  private static void SetSeriesText(DXDC.BubbleChartSeries openXmlElement, DMDC.SeriesText? value)
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
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXDC.BubbleChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDC.BubbleChartSeries openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDC.BubbleChartSeries openXmlElement, DMDC.ChartShapeProperties? value)
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
  /// PictureOptions.
  /// </summary>
  private static DMDC.PictureOptions? GetPictureOptions(DXDC.BubbleChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PictureOptions>();
    if (element != null)
      return DMXDC.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXDC.BubbleChartSeries openXmlElement, DMDC.PictureOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PictureOptions>(), value, diffs, objName);
  }
  
  private static void SetPictureOptions(DXDC.BubbleChartSeries openXmlElement, DMDC.PictureOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PictureOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PictureOptionsConverter.CreateOpenXmlElement<DXDC.PictureOptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// InvertIfNegative.
  /// </summary>
  private static Boolean? GetInvertIfNegative(DXDC.BubbleChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.InvertIfNegative>() != null;
  }
  
  private static bool CmpInvertIfNegative(DXDC.BubbleChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.InvertIfNegative>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.InvertIfNegative", val, value);
    return false;
  }
  
  private static void SetInvertIfNegative(DXDC.BubbleChartSeries openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.InvertIfNegative>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.InvertIfNegative();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDC.DataPoint>? GetDataPoints(DXDC.BubbleChartSeries openXmlElement)
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
  
  private static bool CmpDataPoints(DXDC.BubbleChartSeries openXmlElement, Collection<DMDC.DataPoint>? value, DiffList? diffs, string? objName)
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
  
  private static void SetDataPoints(DXDC.BubbleChartSeries openXmlElement, Collection<DMDC.DataPoint>? value)
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
  
  private static DMDC.DataLabels? GetDataLabels(DXDC.BubbleChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXDC.BubbleChartSeries openXmlElement, DMDC.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName);
  }
  
  private static void SetDataLabels(DXDC.BubbleChartSeries openXmlElement, DMDC.DataLabels? value)
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
  
  private static Collection<DMDC.Trendline>? GetTrendlines(DXDC.BubbleChartSeries openXmlElement)
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
  
  private static bool CmpTrendlines(DXDC.BubbleChartSeries openXmlElement, Collection<DMDC.Trendline>? value, DiffList? diffs, string? objName)
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
  
  private static void SetTrendlines(DXDC.BubbleChartSeries openXmlElement, Collection<DMDC.Trendline>? value)
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
  
  private static Collection<DMDC.ErrorBars>? GetErrorBars(DXDC.BubbleChartSeries openXmlElement)
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
  
  private static bool CmpErrorBars(DXDC.BubbleChartSeries openXmlElement, Collection<DMDC.ErrorBars>? value, DiffList? diffs, string? objName)
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
  
  private static void SetErrorBars(DXDC.BubbleChartSeries openXmlElement, Collection<DMDC.ErrorBars>? value)
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
  
  private static DMDC.XValues? GetXValues(DXDC.BubbleChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.XValues>();
    if (element != null)
      return DMXDC.XValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpXValues(DXDC.BubbleChartSeries openXmlElement, DMDC.XValues? value, DiffList? diffs, string? objName)
  {
    return DMXDC.XValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.XValues>(), value, diffs, objName);
  }
  
  private static void SetXValues(DXDC.BubbleChartSeries openXmlElement, DMDC.XValues? value)
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
  
  private static DMDC.YValues? GetYValues(DXDC.BubbleChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.YValues>();
    if (element != null)
      return DMXDC.YValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpYValues(DXDC.BubbleChartSeries openXmlElement, DMDC.YValues? value, DiffList? diffs, string? objName)
  {
    return DMXDC.YValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.YValues>(), value, diffs, objName);
  }
  
  private static void SetYValues(DXDC.BubbleChartSeries openXmlElement, DMDC.YValues? value)
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
  
  private static DMDC.BubbleSize? GetBubbleSize(DXDC.BubbleChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BubbleSize>();
    if (element != null)
      return DMXDC.BubbleSizeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBubbleSize(DXDC.BubbleChartSeries openXmlElement, DMDC.BubbleSize? value, DiffList? diffs, string? objName)
  {
    return DMXDC.BubbleSizeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BubbleSize>(), value, diffs, objName);
  }
  
  private static void SetBubbleSize(DXDC.BubbleChartSeries openXmlElement, DMDC.BubbleSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BubbleSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BubbleSizeConverter.CreateOpenXmlElement<DXDC.BubbleSize>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBubble3D(DXDC.BubbleChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXDC.BubbleChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXDC.BubbleChartSeries openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Bubble3D();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.BubbleSerExtensionList? GetBubbleSerExtensionList(DXDC.BubbleChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BubbleSerExtensionList>();
    if (element != null)
      return DMXDC.BubbleSerExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBubbleSerExtensionList(DXDC.BubbleChartSeries openXmlElement, DMDC.BubbleSerExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.BubbleSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BubbleSerExtensionList>(), value, diffs, objName);
  }
  
  private static void SetBubbleSerExtensionList(DXDC.BubbleChartSeries openXmlElement, DMDC.BubbleSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BubbleSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BubbleSerExtensionListConverter.CreateOpenXmlElement<DXDC.BubbleSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChartSeries? CreateModelElement(DXDC.BubbleChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChartSeries();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.InvertIfNegative = GetInvertIfNegative(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBars = GetErrorBars(openXmlElement);
      value.XValues = GetXValues(openXmlElement);
      value.YValues = GetYValues(openXmlElement);
      value.BubbleSize = GetBubbleSize(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.BubbleSerExtensionList = GetBubbleSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BubbleChartSeries? openXmlElement, DMDC.BubbleChartSeries? value, DiffList? diffs, string? objName)
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
      if (!CmpPictureOptions(openXmlElement, value.PictureOptions, diffs, objName))
        ok = false;
      if (!CmpInvertIfNegative(openXmlElement, value.InvertIfNegative, diffs, objName))
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
      if (!CmpBubbleSize(openXmlElement, value.BubbleSize, diffs, objName))
        ok = false;
      if (!CmpBubble3D(openXmlElement, value.Bubble3D, diffs, objName))
        ok = false;
      if (!CmpBubbleSerExtensionList(openXmlElement, value.BubbleSerExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BubbleChartSeries value)
    where OpenXmlElementType: DXDC.BubbleChartSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BubbleChartSeries openXmlElement, DMDC.BubbleChartSeries value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetOrder(openXmlElement, value?.Order);
    SetSeriesText(openXmlElement, value?.SeriesText);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetPictureOptions(openXmlElement, value?.PictureOptions);
    SetInvertIfNegative(openXmlElement, value?.InvertIfNegative);
    SetDataPoints(openXmlElement, value?.DataPoints);
    SetDataLabels(openXmlElement, value?.DataLabels);
    SetTrendlines(openXmlElement, value?.Trendlines);
    SetErrorBars(openXmlElement, value?.ErrorBars);
    SetXValues(openXmlElement, value?.XValues);
    SetYValues(openXmlElement, value?.YValues);
    SetBubbleSize(openXmlElement, value?.BubbleSize);
    SetBubble3D(openXmlElement, value?.Bubble3D);
    SetBubbleSerExtensionList(openXmlElement, value?.BubbleSerExtensionList);
  }
}
