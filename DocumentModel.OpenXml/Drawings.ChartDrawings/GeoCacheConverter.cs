namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
public static class GeoCacheConverter
{
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetProvider(DXO2016DrawChartDraw.GeoCache openXmlElement)
  {
    return openXmlElement?.Provider?.Value;
  }
  
  private static void SetProvider(DXO2016DrawChartDraw.GeoCache openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Provider = new StringValue { Value = value };
    else
      openXmlElement.Provider = null;
  }
  
  private static String? GetXsdbase64Binary(DXO2016DrawChartDraw.GeoCache openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Xsdbase64Binary>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Clear>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ClearConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsChartDraws.GeoCache? CreateModelElement(DXO2016DrawChartDraw.GeoCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoCache();
      value.Provider = GetProvider(openXmlElement);
      value.Xsdbase64Binary = GetXsdbase64Binary(openXmlElement);
      value.Clear = GetClear(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoCache? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoCache, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetProvider(openXmlElement, value?.Provider);
      SetXsdbase64Binary(openXmlElement, value?.Xsdbase64Binary);
      SetClear(openXmlElement, value?.Clear);
      return openXmlElement;
    }
    return default;
  }
}
