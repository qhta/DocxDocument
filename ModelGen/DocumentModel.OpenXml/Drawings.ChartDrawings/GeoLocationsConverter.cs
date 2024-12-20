namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocations Class.
/// </summary>
public static class GeoLocationsConverter
{
  /// <summary>
  /// GeoLocation.
  /// </summary>
  private static DMDrawsChartDraws.GeoLocation? GetGeoLocation(DXO2016DrawChartDraw.GeoLocations openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocation>();
    if (element != null)
      return DMXDrawsChartDraws.GeoLocationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoLocation(DXO2016DrawChartDraw.GeoLocations openXmlElement, DMDrawsChartDraws.GeoLocation? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoLocationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoLocation>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGeoLocation(DXO2016DrawChartDraw.GeoLocations openXmlElement, DMDrawsChartDraws.GeoLocation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoLocation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoLocationConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoLocation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocations? CreateModelElement(DXO2016DrawChartDraw.GeoLocations? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocations();
      value.GeoLocation = GetGeoLocation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoLocations? openXmlElement, DMDrawsChartDraws.GeoLocations? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoLocation(openXmlElement, value.GeoLocation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoLocations value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoLocations, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoLocations openXmlElement, DMDrawsChartDraws.GeoLocations value)
  {
    SetGeoLocation(openXmlElement, value?.GeoLocation);
  }
}
