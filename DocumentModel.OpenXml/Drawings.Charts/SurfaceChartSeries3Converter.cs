namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartSeries Class.
/// </summary>
public static class SurfaceChartSeries3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val?.Value;
  }
  
  private static bool CmpIndex(DXO2013DrawChart.SurfaceChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Index", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXO2013DrawChart.SurfaceChartSeries openXmlElement, UInt32? value)
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
  private static UInt32? GetOrder(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.Order>()?.Val?.Value;
  }
  
  private static bool CmpOrder(DXO2013DrawChart.SurfaceChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Order>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Order", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetOrder(DXO2013DrawChart.SurfaceChartSeries openXmlElement, UInt32? value)
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
  private static DMDrawsCharts.SeriesText? GetSeriesText(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return DMXDrawsCharts.SeriesTextConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SeriesText>());
  }
  
  private static bool CmpSeriesText(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.SeriesText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SeriesText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSeriesText(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.SeriesText? value)
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
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>());
  }
  
  private static bool CmpChartShapeProperties(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartShapeProperties(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>());
  }
  
  private static bool CmpPictureOptions(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PictureOptions>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPictureOptions(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value)
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
  /// CategoryAxisData.
  /// </summary>
  private static DMDrawsCharts.CategoryAxisData? GetCategoryAxisData(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return DMXDrawsCharts.CategoryAxisDataConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.CategoryAxisData>());
  }
  
  private static bool CmpCategoryAxisData(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.CategoryAxisData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryAxisDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.CategoryAxisData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCategoryAxisData(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.CategoryAxisData? value)
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
  
  /// <summary>
  /// Values.
  /// </summary>
  private static DMDrawsCharts.Values? GetValues(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return DMXDrawsCharts.ValuesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.Values>());
  }
  
  private static bool CmpValues(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.Values? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Values>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetValues(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.Values? value)
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
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  private static Boolean? GetBubble3D(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXO2013DrawChart.SurfaceChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXO2013DrawChart.SurfaceChartSeries openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  private static DMDrawsCharts.SurfaceSerExtensionList? GetSurfaceSerExtensionList(DXO2013DrawChart.SurfaceChartSeries openXmlElement)
  {
    return DMXDrawsCharts.SurfaceSerExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.SurfaceSerExtensionList>());
  }
  
  private static bool CmpSurfaceSerExtensionList(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.SurfaceSerExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SurfaceSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SurfaceSerExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSurfaceSerExtensionList(DXO2013DrawChart.SurfaceChartSeries openXmlElement, DMDrawsCharts.SurfaceSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.SurfaceSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SurfaceSerExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.SurfaceSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.SurfaceChartSeries3? CreateModelElement(DXO2013DrawChart.SurfaceChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SurfaceChartSeries3();
      value.Index = GetIndex(openXmlElement);
      value.Order = GetOrder(openXmlElement);
      value.SeriesText = GetSeriesText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.PictureOptions = GetPictureOptions(openXmlElement);
      value.CategoryAxisData = GetCategoryAxisData(openXmlElement);
      value.Values = GetValues(openXmlElement);
      value.Bubble3D = GetBubble3D(openXmlElement);
      value.SurfaceSerExtensionList = GetSurfaceSerExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.SurfaceChartSeries? openXmlElement, DMDrawsCharts.SurfaceChartSeries3? value, DiffList? diffs, string? objName)
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
      if (!CmpCategoryAxisData(openXmlElement, value.CategoryAxisData, diffs, objName))
        ok = false;
      if (!CmpValues(openXmlElement, value.Values, diffs, objName))
        ok = false;
      if (!CmpBubble3D(openXmlElement, value.Bubble3D, diffs, objName))
        ok = false;
      if (!CmpSurfaceSerExtensionList(openXmlElement, value.SurfaceSerExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceChartSeries3? value)
    where OpenXmlElementType: DXO2013DrawChart.SurfaceChartSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetOrder(openXmlElement, value?.Order);
      SetSeriesText(openXmlElement, value?.SeriesText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetPictureOptions(openXmlElement, value?.PictureOptions);
      SetCategoryAxisData(openXmlElement, value?.CategoryAxisData);
      SetValues(openXmlElement, value?.Values);
      SetBubble3D(openXmlElement, value?.Bubble3D);
      SetSurfaceSerExtensionList(openXmlElement, value?.SurfaceSerExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
