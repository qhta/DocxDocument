namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Rotation converter from/to OpenXml.
///</summary>
public static class RotationConverter
{
  /// <summary>
  /// Latitude
  /// </summary>
  private static Int32? GetLatitude(DXDraw.Rotation openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }
  
  private static bool CmpLatitude(DXDraw.Rotation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Latitude?.Value == value) return true;
    diffs?.Add(objName, "Latitude", openXmlElement?.Latitude?.Value, value);
    return false;
  }
  
  private static void SetLatitude(DXDraw.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// Longitude
  /// </summary>
  private static Int32? GetLongitude(DXDraw.Rotation openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }
  
  private static bool CmpLongitude(DXDraw.Rotation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Longitude?.Value == value) return true;
    diffs?.Add(objName, "Longitude", openXmlElement?.Longitude?.Value, value);
    return false;
  }
  
  private static void SetLongitude(DXDraw.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// Revolution
  /// </summary>
  private static Int32? GetRevolution(DXDraw.Rotation openXmlElement)
  {
    return openXmlElement?.Revolution?.Value;
  }
  
  private static bool CmpRevolution(DXDraw.Rotation openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Revolution?.Value == value) return true;
    diffs?.Add(objName, "Revolution", openXmlElement?.Revolution?.Value, value);
    return false;
  }
  
  private static void SetRevolution(DXDraw.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Revolution = value;
  }
  
  public static DocumentModel.Drawings.Rotation? CreateModelElement(DXDraw.Rotation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Rotation();
      value.Latitude = GetLatitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      value.Revolution = GetRevolution(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Rotation? openXmlElement, DMDraws.Rotation? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLatitude(openXmlElement, value.Latitude, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Rotation value)
    where OpenXmlElementType: DXDraw.Rotation, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Rotation openXmlElement, DMDraws.Rotation value)
  {
    SetLatitude(openXmlElement, value?.Latitude);
    SetLongitude(openXmlElement, value?.Longitude);
    SetRevolution(openXmlElement, value?.Revolution);
  }
}
