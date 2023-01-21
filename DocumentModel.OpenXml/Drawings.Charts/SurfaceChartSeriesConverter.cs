namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Surface Chart Series.
/// </summary>
public static class SurfaceChartSeriesConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Index>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetIndex(DXDrawCharts.SurfaceChartSeries openXmlElement, UInt32? value)
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
  private static UInt32? GetOrder(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Order>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetOrder(DXDrawCharts.SurfaceChartSeries openXmlElement, UInt32? value)
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
  private static DMDrawsCharts.SeriesText? GetSeriesText(DXDrawCharts.SurfaceChartSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SeriesText>();
    if (itemElement != null)
      return DMXDrawsCharts.SeriesTextConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PictureOptions>();
    if (itemElement != null)
      return DMXDrawsCharts.PictureOptionsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.CategoryAxisData>();
    if (itemElement != null)
      return DMXDrawsCharts.CategoryAxisDataConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Values>();
    if (itemElement != null)
      return DMXDrawsCharts.ValuesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Bubble3D>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.SurfaceSerExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.SurfaceSerExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsCharts.SurfaceChartSeries? CreateModelElement(DXDrawCharts.SurfaceChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SurfaceChartSeries();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SurfaceChartSeries? value)
    where OpenXmlElementType: DXDrawCharts.SurfaceChartSeries, new()
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
