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
    return DMXDrawsChartDraws.GeoLocationConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocation>());
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
  
  public static DMDrawsChartDraws.GeoLocations? CreateModelElement(DXO2016DrawChartDraw.GeoLocations? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoLocations();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoLocations? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoLocations, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoLocation(openXmlElement, value?.GeoLocation);
      return openXmlElement;
    }
    return default;
  }
}
