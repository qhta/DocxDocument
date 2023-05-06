namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartSeries Class.
/// </summary>
public static class SurfaceChartSeries3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXO13DC.SurfaceChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXO13DC.SurfaceChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  private static UInt32? GetOrder(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val);
  }
  
  private static bool CmpOrder(DXO13DC.SurfaceChartSeries openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Order>()?.Val, value, diffs, objName, "Order");
  }
  
  private static void SetOrder(DXO13DC.SurfaceChartSeries openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Order,System.UInt32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  private static DMDC.SeriesText? GetSeriesText(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SeriesText>();
    if (element != null)
      return DMXDC.SeriesTextConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeriesText(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.SeriesText? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SeriesTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SeriesText>(), value, diffs, objName);
  }
  
  private static void SetSeriesText(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.SeriesText? value)
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
  private static DMDC.ChartShapeProperties? GetChartShapeProperties(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ChartShapeProperties>();
    if (element != null)
      return DMXDC.ChartShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartShapeProperties(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.ChartShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ChartShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ChartShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetChartShapeProperties(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.ChartShapeProperties? value)
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
  private static DMDC.PictureOptions? GetPictureOptions(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PictureOptions>();
    if (element != null)
      return DMXDC.PictureOptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPictureOptions(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.PictureOptions? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PictureOptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PictureOptions>(), value, diffs, objName);
  }
  
  private static void SetPictureOptions(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.PictureOptions? value)
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
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  private static DMDC.CategoryAxisData? GetCategoryAxisData(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.CategoryAxisData>();
    if (element != null)
      return DMXDC.CategoryAxisDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryAxisData(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.CategoryAxisData? value, DiffList? diffs, string? objName)
  {
    return DMXDC.CategoryAxisDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.CategoryAxisData>(), value, diffs, objName);
  }
  
  private static void SetCategoryAxisData(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.CategoryAxisData? value)
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
  
  /// <summary>
  /// Values.
  /// </summary>
  private static DMDC.Values? GetValues(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.Values>();
    if (element != null)
      return DMXDC.ValuesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpValues(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.Values? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ValuesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.Values>(), value, diffs, objName);
  }
  
  private static void SetValues(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.Values? value)
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
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  private static Boolean? GetBubble3D(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Bubble3D>() != null;
  }
  
  private static bool CmpBubble3D(DXO13DC.SurfaceChartSeries openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Bubble3D>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Bubble3D", val, value);
    return false;
  }
  
  private static void SetBubble3D(DXO13DC.SurfaceChartSeries openXmlElement, Boolean? value)
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
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  private static DMDC.SurfaceSerExtensionList? GetSurfaceSerExtensionList(DXO13DC.SurfaceChartSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.SurfaceSerExtensionList>();
    if (element != null)
      return DMXDC.SurfaceSerExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSurfaceSerExtensionList(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.SurfaceSerExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.SurfaceSerExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.SurfaceSerExtensionList>(), value, diffs, objName);
  }
  
  private static void SetSurfaceSerExtensionList(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.SurfaceSerExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.SurfaceSerExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.SurfaceSerExtensionListConverter.CreateOpenXmlElement<DXDC.SurfaceSerExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChartSeries3? CreateModelElement(DXO13DC.SurfaceChartSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChartSeries3();
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
  
  public static bool CompareModelElement(DXO13DC.SurfaceChartSeries? openXmlElement, DMDC.SurfaceChartSeries3? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SurfaceChartSeries3 value)
    where OpenXmlElementType: DXO13DC.SurfaceChartSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.SurfaceChartSeries openXmlElement, DMDC.SurfaceChartSeries3 value)
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
