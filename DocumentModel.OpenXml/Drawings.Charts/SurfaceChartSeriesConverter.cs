namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Surface Chart Series converter from/to OpenXml.
///</summary>
public static class SurfaceChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXDrawCharts.SurfaceChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXDrawCharts.SurfaceChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawCharts.Order>()?.Val);
  }
  
  private static bool CmpOrder(DXDrawCharts.SurfaceChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawCharts.Order>()?.Val, value, diffs, objName, "Order");
  }
  
  private static void SetOrder(DXDrawCharts.SurfaceChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDrawCharts.Order,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DMDrawsCharts.SeriesText? GetSeriesText(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.SeriesText>();
    if (element != null)
      return DMXDrawsCharts.SeriesTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesText(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.SeriesText? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SeriesText>(), value, diffs, objName);
  }
  
  private static void SetSeriesText(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.SeriesText? value)
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
  private static DMDrawsCharts.ChartShapeProperties? GetChartShapeProperties(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.ChartShapeProperties? value)
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
  private static DMDrawsCharts.PictureOptions? GetPictureOptions(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (element != null)
      return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.PictureOptions>(), value, diffs, objName);
  }
  
  private static void SetPictureOptions(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.PictureOptions? value)
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
  private static DMDrawsCharts.CategoryAxisData? GetCategoryAxisData(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.CategoryAxisData>();
    if (element != null)
      return DMXDrawsCharts.CategoryAxisDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxisData(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.CategoryAxisData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.CategoryAxisDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.CategoryAxisData>(), value, diffs, objName);
  }
  
  private static void SetCategoryAxisData(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.CategoryAxisData? value)
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
  private static DMDrawsCharts.Values? GetValues(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.Values>();
    if (element != null)
      return DMXDrawsCharts.ValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValues(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.Values? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.Values>(), value, diffs, objName);
  }
  
  private static void SetValues(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.Values? value)
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
  private static Boolean? GetBubble3D(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXDrawCharts.SurfaceChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXDrawCharts.SurfaceChartSeries openXmlElement, Boolean? value)
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
  private static DMDrawsCharts.SurfaceSerExtensionList? GetSurfaceSerExtensionList(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.SurfaceSerExtensionList>();
    if (element != null)
      return DMXDrawsCharts.SurfaceSerExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurfaceSerExtensionList(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.SurfaceSerExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.SurfaceSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.SurfaceSerExtensionList>(), value, diffs, objName);
  }
  
  private static void SetSurfaceSerExtensionList(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.SurfaceSerExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.SurfaceChartSeries? CreateModelElement(DXDrawCharts.SurfaceChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChartSeries();
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
  
  public static bool CompareModelElement(DXDrawCharts.SurfaceChartSeries? openXmlElement, DMDrawsCharts.SurfaceChartSeries? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceChartSeries value)
    where OpenXmlElementType: DXDrawCharts.SurfaceChartSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.SurfaceChartSeries openXmlElement, DMDrawsCharts.SurfaceChartSeries value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetOrder(openXmlElement, value?.Order);
    SetSeriesText(openXmlElement, value?.SeriesText);
    SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
    SetPictureOptions(openXmlElement, value?.PictureOptions);
    SetCategoryAxisData(openXmlElement, value?.CategoryAxisData);
    SetValues(openXmlElement, value?.Values);
    SetBubble3D(openXmlElement, value?.Bubble3D);
    SetSurfaceSerExtensionList(openXmlElement, value?.SurfaceSerExtensionList);
  }
}
