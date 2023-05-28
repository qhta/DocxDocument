namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarChartSeries Class.
/// </summary>
public static class BarChartSeries3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXO13DC.BarChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXO13DC.BarChartSeries openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXO13DC.BarChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DXO13DC.BarChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val);
  }
  
  private static bool CmpOrder(DXO13DC.BarChartSeries openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val, value, diffs, objName, "Order");
  }
  
  private static void SetOrder(DXO13DC.BarChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Order,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DMDC.SeriesText? GetSeriesText(DXO13DC.BarChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SeriesText>();
    if (element != null)
      return DMXDC.SeriesTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesText(DXO13DC.BarChartSeries openXmlElement, DMDC.SeriesText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SeriesText>(), value, diffs, objName, propName);
  }
  
  private static void SetSeriesText(DXO13DC.BarChartSeries openXmlElement, DMDC.SeriesText? value)
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
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXO13DC.BarChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXO13DC.BarChartSeries openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetChartShapeProperties(DXO13DC.BarChartSeries openXmlElement, DMDC.ChartShapeProperties? value)
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
  /// InvertIfNegative.
  /// </summary>
  private static Boolean? GetInvertIfNegative(DXO13DC.BarChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.InvertIfNegative>() != null;
  }
  
  private static bool CmpInvertIfNegative(DXO13DC.BarChartSeries openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.InvertIfNegative>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.InvertIfNegative", val, value);
    return false;
  }
  
  private static void SetInvertIfNegative(DXO13DC.BarChartSeries openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PictureOptions.
  /// </summary>
  private static DMDC.PictureOptions? GetPictureOptions(DXO13DC.BarChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PictureOptions>();
    if (element != null)
      return DMXDC.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXO13DC.BarChartSeries openXmlElement, DMDC.PictureOptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PictureOptions>(), value, diffs, objName, propName);
  }
  
  private static void SetPictureOptions(DXO13DC.BarChartSeries openXmlElement, DMDC.PictureOptions? value)
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
  
  private static Collection<DMDC.DataPoint>? GetDataPoints(DXO13DC.BarChartSeries openXmlElement)
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
  
  private static bool CmpDataPoints(DXO13DC.BarChartSeries openXmlElement, Collection<DMDC.DataPoint>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetDataPoints(DXO13DC.BarChartSeries openXmlElement, Collection<DMDC.DataPoint>? value)
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
  
  private static DMDC.DataLabels? GetDataLabels(DXO13DC.BarChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.DataLabels>();
    if (element != null)
      return DMXDC.DataLabelsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabels(DXO13DC.BarChartSeries openXmlElement, DMDC.DataLabels? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.DataLabels>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabels(DXO13DC.BarChartSeries openXmlElement, DMDC.DataLabels? value)
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
  
  private static Collection<DMDC.Trendline>? GetTrendlines(DXO13DC.BarChartSeries openXmlElement)
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
  
  private static bool CmpTrendlines(DXO13DC.BarChartSeries openXmlElement, Collection<DMDC.Trendline>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  private static void SetTrendlines(DXO13DC.BarChartSeries openXmlElement, Collection<DMDC.Trendline>? value)
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
  
  private static DMDC.ErrorBars? GetErrorBars(DXO13DC.BarChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ErrorBars>();
    if (element != null)
      return DMXDC.ErrorBarsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpErrorBars(DXO13DC.BarChartSeries openXmlElement, DMDC.ErrorBars? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ErrorBarsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ErrorBars>(), value, diffs, objName, propName);
  }
  
  private static void SetErrorBars(DXO13DC.BarChartSeries openXmlElement, DMDC.ErrorBars? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ErrorBars>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ErrorBarsConverter.CreateOpenXmlElement<DXDC.ErrorBars>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.CategoryAxisData? GetCategoryAxisData(DXO13DC.BarChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.CategoryAxisData>();
    if (element != null)
      return DMXDC.CategoryAxisDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxisData(DXO13DC.BarChartSeries openXmlElement, DMDC.CategoryAxisData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.CategoryAxisDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.CategoryAxisData>(), value, diffs, objName, propName);
  }
  
  private static void SetCategoryAxisData(DXO13DC.BarChartSeries openXmlElement, DMDC.CategoryAxisData? value)
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
  
  private static DMDC.Values? GetValues(DXO13DC.BarChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Values>();
    if (element != null)
      return DMXDC.ValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValues(DXO13DC.BarChartSeries openXmlElement, DMDC.Values? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Values>(), value, diffs, objName, propName);
  }
  
  private static void SetValues(DXO13DC.BarChartSeries openXmlElement, DMDC.Values? value)
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
  
  private static DMDC.ShapeKind? GetShape(DXO13DC.BarChartSeries openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(openXmlElement.GetFirstChild<DXDC.Shape>()?.Val?.Value);
  }
  
  private static bool CmpShape(DXO13DC.BarChartSeries openXmlElement, DMDC.ShapeKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(openXmlElement.GetFirstChild<DXDC.Shape>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetShape(DXO13DC.BarChartSeries openXmlElement, DMDC.ShapeKind? value)
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
  
  private static DMDC.BarSerExtensionList? GetBarSerExtensionList(DXO13DC.BarChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.BarSerExtensionList>();
    if (element != null)
      return DMXDC.BarSerExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBarSerExtensionList(DXO13DC.BarChartSeries openXmlElement, DMDC.BarSerExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.BarSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.BarSerExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetBarSerExtensionList(DXO13DC.BarChartSeries openXmlElement, DMDC.BarSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.BarSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.BarSerExtensionListConverter.CreateOpenXmlElement<DXDC.BarSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.BarChartSeries3? CreateModelElement(DXO13DC.BarChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.BarChartSeries3();
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
  
  public static bool CompareModelElement(DXO13DC.BarChartSeries? openXmlElement, DMDC.BarChartSeries3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
      if (!CmpInvertIfNegative(openXmlElement, value.InvertIfNegative, diffs, objName, propName))
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
      if (!CmpShape(openXmlElement, value.Shape, diffs, objName, propName))
        ok = false;
      if (!CmpBarSerExtensionList(openXmlElement, value.BarSerExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BarChartSeries3 value)
    where OpenXmlElementType: DXO13DC.BarChartSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.BarChartSeries openXmlElement, DMDC.BarChartSeries3 value)
  {
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
  }
}
