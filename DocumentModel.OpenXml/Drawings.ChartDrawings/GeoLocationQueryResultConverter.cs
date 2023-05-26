namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public static class GeoLocationQueryResultConverter
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  private static DMDCDs.GeoLocationQuery? GetGeoLocationQuery(DXO16DCD.GeoLocationQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoLocationQuery>();
    if (element != null)
      return DMXDCDs.GeoLocationQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoLocationQuery(DXO16DCD.GeoLocationQueryResult openXmlElement, DMDCDs.GeoLocationQuery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoLocationQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoLocationQuery>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoLocationQuery(DXO16DCD.GeoLocationQueryResult openXmlElement, DMDCDs.GeoLocationQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoLocationQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoLocationQueryConverter.CreateOpenXmlElement<DXO16DCD.GeoLocationQuery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  private static DMDCDs.GeoLocations? GetGeoLocations(DXO16DCD.GeoLocationQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoLocations>();
    if (element != null)
      return DMXDCDs.GeoLocationsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoLocations(DXO16DCD.GeoLocationQueryResult openXmlElement, DMDCDs.GeoLocations? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.GeoLocationsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoLocations>(), value, diffs, objName, propName);
  }
  
  private static void SetGeoLocations(DXO16DCD.GeoLocationQueryResult openXmlElement, DMDCDs.GeoLocations? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoLocations>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoLocationsConverter.CreateOpenXmlElement<DXO16DCD.GeoLocations>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult? CreateModelElement(DXO16DCD.GeoLocationQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult();
      value.GeoLocationQuery = GetGeoLocationQuery(openXmlElement);
      value.GeoLocations = GetGeoLocations(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoLocationQueryResult? openXmlElement, DMDCDs.GeoLocationQueryResult? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoLocationQuery(openXmlElement, value.GeoLocationQuery, diffs, objName, propName))
        ok = false;
      if (!CmpGeoLocations(openXmlElement, value.GeoLocations, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoLocationQueryResult value)
    where OpenXmlElementType: DXO16DCD.GeoLocationQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoLocationQueryResult openXmlElement, DMDCDs.GeoLocationQueryResult value)
  {
    SetGeoLocationQuery(openXmlElement, value?.GeoLocationQuery);
    SetGeoLocations(openXmlElement, value?.GeoLocations);
  }
}
