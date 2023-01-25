namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SphereCoordinates Class.
/// </summary>
public static class SphereCoordinatesConverter
{
  /// <summary>
  /// lat, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLattitude(DXO2010W.SphereCoordinates openXmlElement)
  {
    return openXmlElement?.Lattitude?.Value;
  }
  
  private static bool CmpLattitude(DXO2010W.SphereCoordinates openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Lattitude?.Value == value) return true;
    diffs?.Add(objName, "Lattitude", openXmlElement?.Lattitude?.Value, value);
    return false;
  }
  
  private static void SetLattitude(DXO2010W.SphereCoordinates openXmlElement, Int32? value)
  {
    openXmlElement.Lattitude = value;
  }
  
  /// <summary>
  /// lon, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLongitude(DXO2010W.SphereCoordinates openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }
  
  private static bool CmpLongitude(DXO2010W.SphereCoordinates openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Longitude?.Value == value) return true;
    diffs?.Add(objName, "Longitude", openXmlElement?.Longitude?.Value, value);
    return false;
  }
  
  private static void SetLongitude(DXO2010W.SphereCoordinates openXmlElement, Int32? value)
  {
    openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// rev, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetRevolution(DXO2010W.SphereCoordinates openXmlElement)
  {
    return openXmlElement?.Revolution?.Value;
  }
  
  private static bool CmpRevolution(DXO2010W.SphereCoordinates openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Revolution?.Value == value) return true;
    diffs?.Add(objName, "Revolution", openXmlElement?.Revolution?.Value, value);
    return false;
  }
  
  private static void SetRevolution(DXO2010W.SphereCoordinates openXmlElement, Int32? value)
  {
    openXmlElement.Revolution = value;
  }
  
  public static DMW.SphereCoordinates? CreateModelElement(DXO2010W.SphereCoordinates? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SphereCoordinates();
      value.Lattitude = GetLattitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      value.Revolution = GetRevolution(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.SphereCoordinates? openXmlElement, DMW.SphereCoordinates? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLattitude(openXmlElement, value.Lattitude, diffs, objName))
        ok = false;
      if (!CmpLongitude(openXmlElement, value.Longitude, diffs, objName))
        ok = false;
      if (!CmpRevolution(openXmlElement, value.Revolution, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SphereCoordinates? value)
    where OpenXmlElementType: DXO2010W.SphereCoordinates, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLattitude(openXmlElement, value?.Lattitude);
      SetLongitude(openXmlElement, value?.Longitude);
      SetRevolution(openXmlElement, value?.Revolution);
      return openXmlElement;
    }
    return default;
  }
}
