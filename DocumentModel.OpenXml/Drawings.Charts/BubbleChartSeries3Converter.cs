namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartSeries Class.
/// </summary>
public static class BubbleChartSeries3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DXO2013DrawChart.BubbleChartSeries openXmlElement, UInt32? value)
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
  private static UInt32? GetOrder(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetOrder(DXO2013DrawChart.BubbleChartSeries openXmlElement, UInt32? value)
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
  private static DMDrawsCharts.SeriesText? GetSeriesText(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SeriesText>();
    if (itemElement != null)
      return DMXDrawsCharts.SeriesTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesText(DXO2013DrawChart.BubbleChartSeries openXmlElement, DMDrawsCharts.SeriesText? value)
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
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartShapeProperties(DXO2013DrawChart.BubbleChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  /// PictureOptions.
  /// </summary>
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (itemElement != null)
      return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureOptions(DXO2013DrawChart.BubbleChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value)
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
  
  /// <summary>
  /// InvertIfNegative.
  /// </summary>
  private static Boolean? GetInvertIfNegative(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.InvertIfNegative>();
    return itemElement != null;
  }
  
  private static void SetInvertIfNegative(DXO2013DrawChart.BubbleChartSeries openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.InvertIfNegative>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.InvertIfNegative();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.DataPoint> GetDataPoints(DXO2013DrawChart.BubbleChartSeries openXmlElement)
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
  
  private static void SetDataPoints(DXO2013DrawChart.BubbleChartSeries openXmlElement, Collection<DMDrawsCharts.DataPoint>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DXO2013DrawChart.BubbleChartSeries openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static Collection<DMDrawsCharts.Trendline> GetTrendlines(DXO2013DrawChart.BubbleChartSeries openXmlElement)
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
  
  private static void SetTrendlines(DXO2013DrawChart.BubbleChartSeries openXmlElement, Collection<DMDrawsCharts.Trendline>? value)
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
  
  private static Collection<DMDrawsCharts.ErrorBars> GetErrorBarses(DXO2013DrawChart.BubbleChartSeries openXmlElement)
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
  
  private static void SetErrorBarses(DXO2013DrawChart.BubbleChartSeries openXmlElement, Collection<DMDrawsCharts.ErrorBars>? value)
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
  
  private static DMDrawsCharts.XValues? GetXValues(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.XValues>();
    if (itemElement != null)
      return DMXDrawsCharts.XValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetXValues(DXO2013DrawChart.BubbleChartSeries openXmlElement, DMDrawsCharts.XValues? value)
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
  
  private static DMDrawsCharts.YValues? GetYValues(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.YValues>();
    if (itemElement != null)
      return DMXDrawsCharts.YValuesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetYValues(DXO2013DrawChart.BubbleChartSeries openXmlElement, DMDrawsCharts.YValues? value)
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
  
  private static DMDrawsCharts.BubbleSize? GetBubbleSize(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BubbleSize>();
    if (itemElement != null)
      return DMXDrawsCharts.BubbleSizeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBubbleSize(DXO2013DrawChart.BubbleChartSeries openXmlElement, DMDrawsCharts.BubbleSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BubbleSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BubbleSizeConverter.CreateOpenXmlElement<DXDrawCharts.BubbleSize>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBubble3D(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>();
    return itemElement != null;
  }
  
  private static void SetBubble3D(DXO2013DrawChart.BubbleChartSeries openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Bubble3D();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.BubbleSerExtensionList? GetBubbleSerExtensionList(DXO2013DrawChart.BubbleChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.BubbleSerExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.BubbleSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBubbleSerExtensionList(DXO2013DrawChart.BubbleChartSeries openXmlElement, DMDrawsCharts.BubbleSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BubbleSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BubbleSerExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.BubbleSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.BubbleChartSeries3? CreateModelElement(DXO2013DrawChart.BubbleChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BubbleChartSeries3();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.InvertIfNegative = GetInvertIfNegative(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBarses = GetErrorBarses(openXmlElement);
      value.XValues = GetXValues(openXmlElement);
      value.YValues = GetYValues(openXmlElement);
      value.BubbleSize = GetBubbleSize(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.BubbleSerExtensionList = GetBubbleSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleChartSeries3? value)
    where OpenXmlElementType: DXO2013DrawChart.BubbleChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetInvertIfNegative(openXmlElement, value?.InvertIfNegative);
      SetDataPoints(openXmlElement, value?.DataPoints);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetTrendlines(openXmlElement, value?.Trendlines);
      SetErrorBarses(openXmlElement, value?.ErrorBarses);
      SetXValues(openXmlElement, value?.XValues);
      SetYValues(openXmlElement, value?.YValues);
      SetBubbleSize(openXmlElement, value?.BubbleSize);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetBubbleSerExtensionList(openXmlElement, value?.BubbleSerExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
