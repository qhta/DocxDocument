namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocations Class.
/// </summary>
public static class GeoLocationsConverter
{
  /// <summary>
  /// GeoLocation.
  /// </summary>
  private static DMDCDs.GeoLocation? GetGeoLocation(DXO16DCD.GeoLocations openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.GeoLocation>();
    if (element != null)
      return DMXDCDs.GeoLocationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoLocation(DXO16DCD.GeoLocations openXmlElement, DMDCDs.GeoLocation? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.GeoLocationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.GeoLocation>(), value, diffs, objName);
  }
  
  private static void SetGeoLocation(DXO16DCD.GeoLocations openXmlElement, DMDCDs.GeoLocation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.GeoLocation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.GeoLocationConverter.CreateOpenXmlElement<DXO16DCD.GeoLocation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocations? CreateModelElement(DXO16DCD.GeoLocations? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocations();
      value.GeoLocation = GetGeoLocation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoLocations? openXmlElement, DMDCDs.GeoLocations? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoLocations value)
    where OpenXmlElementType: DXO16DCD.GeoLocations, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoLocations openXmlElement, DMDCDs.GeoLocations value)
  {
    SetGeoLocation(openXmlElement, value?.GeoLocation);
  }
}
