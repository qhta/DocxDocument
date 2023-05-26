namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SphereCoordinates Class.
/// </summary>
public static class SphereCoordinatesConverter
{
  /// <summary>
  /// lat, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLattitude(DXO10W.SphereCoordinates openXmlElement)
  {
    return openXmlElement?.Lattitude?.Value;
  }
  
  private static bool CmpLattitude(DXO10W.SphereCoordinates openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Lattitude?.Value == value) return true;
    diffs?.Add(objName, "Lattitude", openXmlElement?.Lattitude?.Value, value);
    return false;
  }
  
  private static void SetLattitude(DXO10W.SphereCoordinates openXmlElement, Int32? value)
  {
    openXmlElement.Lattitude = value;
  }
  
  /// <summary>
  /// lon, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLongitude(DXO10W.SphereCoordinates openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }
  
  private static bool CmpLongitude(DXO10W.SphereCoordinates openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Longitude?.Value == value) return true;
    diffs?.Add(objName, "Longitude", openXmlElement?.Longitude?.Value, value);
    return false;
  }
  
  private static void SetLongitude(DXO10W.SphereCoordinates openXmlElement, Int32? value)
  {
    openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// rev, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetRevolution(DXO10W.SphereCoordinates openXmlElement)
  {
    return openXmlElement?.Revolution?.Value;
  }
  
  private static bool CmpRevolution(DXO10W.SphereCoordinates openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Revolution?.Value == value) return true;
    diffs?.Add(objName, "Revolution", openXmlElement?.Revolution?.Value, value);
    return false;
  }
  
  private static void SetRevolution(DXO10W.SphereCoordinates openXmlElement, Int32? value)
  {
    openXmlElement.Revolution = value;
  }
  
  public static DMW.SphereCoordinates? CreateModelElement(DXO10W.SphereCoordinates? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10W.SphereCoordinates? openXmlElement, DMW.SphereCoordinates? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLattitude(openXmlElement, value.Lattitude, diffs, objName, propName))
        ok = false;
      if (!CmpLongitude(openXmlElement, value.Longitude, diffs, objName, propName))
        ok = false;
      if (!CmpRevolution(openXmlElement, value.Revolution, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SphereCoordinates value)
    where OpenXmlElementType: DXO10W.SphereCoordinates, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.SphereCoordinates openXmlElement, DMW.SphereCoordinates value)
  {
    SetLattitude(openXmlElement, value?.Lattitude);
    SetLongitude(openXmlElement, value?.Longitude);
    SetRevolution(openXmlElement, value?.Revolution);
  }
}
