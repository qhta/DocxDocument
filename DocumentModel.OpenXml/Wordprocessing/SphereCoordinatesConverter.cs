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
    return openXmlElement.Lattitude?.Value;
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
    return openXmlElement.Longitude?.Value;
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
    return openXmlElement.Revolution?.Value;
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
