namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bar Chart Series.
/// </summary>
public static class BarChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val?.Value;
  }
  
  private static bool CmpIndex(DXDrawCharts.BarChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val?.Value == value;
  }
  
  private static void SetIndex(DXDrawCharts.BarChartSeries openXmlElement, UInt32? value)
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
  private static UInt32? GetOrder(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Order>()?.Val?.Value;
  }
  
  private static bool CmpOrder(DXDrawCharts.BarChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Order>()?.Val?.Value == value;
  }
  
  private static void SetOrder(DXDrawCharts.BarChartSeries openXmlElement, UInt32? value)
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
  private static DMDrawsCharts.SeriesText? GetSeriesText(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return DMXDrawsCharts.SeriesTextConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SeriesText>());
  }
  
  private static bool CmpSeriesText(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.SeriesText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SeriesTextConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SeriesText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSeriesText(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.SeriesText? value)
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
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>());
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  /// InvertIfNegative.
  /// </summary>
  private static Boolean? GetInvertIfNegative(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.InvertIfNegative>() != null;
  }
  
  private static bool CmpInvertIfNegative(DXDrawCharts.BarChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.InvertIfNegative>() != null == value;
  }
  
  private static void SetInvertIfNegative(DXDrawCharts.BarChartSeries openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>());
  }
  
  private static bool CmpPictureOptions(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PictureOptionsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPictureOptions(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value)
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
  
  private static Collection<DMDrawsCharts.DataPoint> GetDataPoints(DXDrawCharts.BarChartSeries openXmlElement)
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
  
  private static bool CmpDataPoints(DXDrawCharts.BarChartSeries openXmlElement, Collection<DMDrawsCharts.DataPoint>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetDataPoints(DXDrawCharts.BarChartSeries openXmlElement, Collection<DMDrawsCharts.DataPoint>? value)
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
  
  private static DMDrawsCharts.DataLabels? GetDataLabels(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return DMXDrawsCharts.DataLabelsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>());
  }
  
  private static bool CmpDataLabels(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.DataLabels? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.DataLabels>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabels(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.DataLabels? value)
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
  
  private static Collection<DMDrawsCharts.Trendline> GetTrendlines(DXDrawCharts.BarChartSeries openXmlElement)
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
  
  private static bool CmpTrendlines(DXDrawCharts.BarChartSeries openXmlElement, Collection<DMDrawsCharts.Trendline>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetTrendlines(DXDrawCharts.BarChartSeries openXmlElement, Collection<DMDrawsCharts.Trendline>? value)
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
  
  private static DMDrawsCharts.ErrorBars? GetErrorBars(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return DMXDrawsCharts.ErrorBarsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ErrorBars>());
  }
  
  private static bool CmpErrorBars(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.ErrorBars? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ErrorBarsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ErrorBars>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetErrorBars(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.ErrorBars? value)
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
  
  private static DMDrawsCharts.CategoryAxisData? GetCategoryAxisData(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return DMXDrawsCharts.CategoryAxisDataConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.CategoryAxisData>());
  }
  
  private static bool CmpCategoryAxisData(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.CategoryAxisData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryAxisDataConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.CategoryAxisData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCategoryAxisData(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.CategoryAxisData? value)
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
  
  private static DMDrawsCharts.Values? GetValues(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return DMXDrawsCharts.ValuesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Values>());
  }
  
  private static bool CmpValues(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.Values? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ValuesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Values>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetValues(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.Values? value)
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
  
  private static DMDrawsCharts.ShapeKind? GetShape(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDrawsCharts.ShapeKind>(openXmlElement.GetFirstChild<DXDrawCharts.Shape>()?.Val?.Value);
  }
  
  private static bool CmpShape(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.ShapeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDrawsCharts.ShapeKind>(openXmlElement.GetFirstChild<DXDrawCharts.Shape>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShape(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.ShapeKind? value)
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
  
  private static DMDrawsCharts.BarSerExtensionList? GetBarSerExtensionList(DXDrawCharts.BarChartSeries openXmlElement)
  {
    return DMXDrawsCharts.BarSerExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.BarSerExtensionList>());
  }
  
  private static bool CmpBarSerExtensionList(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.BarSerExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BarSerExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.BarSerExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBarSerExtensionList(DXDrawCharts.BarChartSeries openXmlElement, DMDrawsCharts.BarSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BarSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BarSerExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.BarSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.BarChartSeries? CreateModelElement(DXDrawCharts.BarChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BarChartSeries();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.InvertIfNegative = GetInvertIfNegative(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Trendlines = GetTrendlines(openXmlElement);
      value.ErrorBars = GetErrorBars(openXmlElement);
      value.CategoryAxisData = GetCategoryAxisData(openXmlElement);
      value.Values = GetValues(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.BarSerExtensionList = GetBarSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BarChartSeries? openXmlElement, DMDrawsCharts.BarChartSeries? value, DiffList? diffs, string? objName)
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
      if (!CmpInvertIfNegative(openXmlElement, value.InvertIfNegative, diffs, objName))
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
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName))
        ok = false;
      if (!CmpBarSerExtensionList(openXmlElement, value.BarSerExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarChartSeries? value)
    where OpenXmlElementType: DXDrawCharts.BarChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetInvertIfNegative(openXmlElement, value?.InvertIfNegative);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetDataPoints(openXmlElement, value?.DataPoints);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetTrendlines(openXmlElement, value?.Trendlines);
      SetErrorBars(openXmlElement, value?.ErrorBars);
      SetCategoryAxisData(openXmlElement, value?.CategoryAxisData);
      SetValues(openXmlElement, value?.Values);
      SetShape(openXmlElement, value?.Shape);
      SetBarSerExtensionList(openXmlElement, value?.BarSerExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
