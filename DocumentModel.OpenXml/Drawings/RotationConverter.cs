namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Rotation.
/// </summary>
public static class RotationConverter
{
  /// <summary>
  /// Latitude
  /// </summary>
  private static Int32? GetLatitude(DXD.Rotation openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }
  
  private static bool CmpLatitude(DXD.Rotation openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Latitude?.Value == value) return true;
    diffs?.Add(objName, "Latitude", openXmlElement?.Latitude?.Value, value);
    return false;
  }
  
  private static void SetLatitude(DXD.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// Longitude
  /// </summary>
  private static Int32? GetLongitude(DXD.Rotation openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }
  
  private static bool CmpLongitude(DXD.Rotation openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Longitude?.Value == value) return true;
    diffs?.Add(objName, "Longitude", openXmlElement?.Longitude?.Value, value);
    return false;
  }
  
  private static void SetLongitude(DXD.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Longitude = value;
  }
  
  /// <summary>
  /// Revolution
  /// </summary>
  private static Int32? GetRevolution(DXD.Rotation openXmlElement)
  {
    return openXmlElement?.Revolution?.Value;
  }
  
  private static bool CmpRevolution(DXD.Rotation openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Revolution?.Value == value) return true;
    diffs?.Add(objName, "Revolution", openXmlElement?.Revolution?.Value, value);
    return false;
  }
  
  private static void SetRevolution(DXD.Rotation openXmlElement, Int32? value)
  {
    openXmlElement.Revolution = value;
  }
  
  public static DocumentModel.Drawings.Rotation? CreateModelElement(DXD.Rotation? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.Rotation? openXmlElement, DMD.Rotation? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLatitude(openXmlElement, value.Latitude, diffs, objName, propName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Rotation value)
    where OpenXmlElementType: DXD.Rotation, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Rotation openXmlElement, DMD.Rotation value)
  {
    SetLatitude(openXmlElement, value?.Latitude);
    SetLongitude(openXmlElement, value?.Longitude);
    SetRevolution(openXmlElement, value?.Revolution);
  }
}
