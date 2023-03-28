namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoCache Class converter from/to OpenXml.
///</summary>
public static class GeoCacheConverter
{
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetProvider(DXO2016DrawChartDraw.GeoCache openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Provider);
  }
  
  private static bool CmpProvider(DXO2016DrawChartDraw.GeoCache openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Provider, value, diffs, objName, "Provider");
  }
  
  private static void SetProvider(DXO2016DrawChartDraw.GeoCache openXmlElement, String? value)
  {
    openXmlElement.Provider = StringValueConverter.CreateStringValue(value);
  }
  
  private static String? GetXsdbase64Binary(DXO2016DrawChartDraw.GeoCache openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Xsdbase64Binary>()?.Text;
  }
  
  private static bool CmpXsdbase64Binary(DXO2016DrawChartDraw.GeoCache openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Xsdbase64Binary>()?.Text == value;
  }
  
  private static void SetXsdbase64Binary(DXO2016DrawChartDraw.GeoCache openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Xsdbase64Binary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.Xsdbase64Binary { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.Clear? GetClear(DXO2016DrawChartDraw.GeoCache openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Clear>();
    if (element != null)
      return DMXDrawsChartDraws.ClearConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpClear(DXO2016DrawChartDraw.GeoCache openXmlElement, DMDrawsChartDraws.Clear? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ClearConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Clear>(), value, diffs, objName);
  }
  
  private static void SetClear(DXO2016DrawChartDraw.GeoCache openXmlElement, DMDrawsChartDraws.Clear? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Clear>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ClearConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Clear>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoCache? CreateModelElement(DXO2016DrawChartDraw.GeoCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoCache();
      value.Provider = GetProvider(openXmlElement);
      value.Xsdbase64Binary = GetXsdbase64Binary(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoCache? openXmlElement, DMDrawsChartDraws.GeoCache? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpProvider(openXmlElement, value.Provider, diffs, objName))
        ok = false;
      if (!CmpXsdbase64Binary(openXmlElement, value.Xsdbase64Binary, diffs, objName))
        ok = false;
      if (!CmpClear(openXmlElement, value.Clear, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoCache value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoCache, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoCache openXmlElement, DMDrawsChartDraws.GeoCache value)
  {
    SetProvider(openXmlElement, value?.Provider);
    SetXsdbase64Binary(openXmlElement, value?.Xsdbase64Binary);
    SetClear(openXmlElement, value?.Clear);
  }
}
